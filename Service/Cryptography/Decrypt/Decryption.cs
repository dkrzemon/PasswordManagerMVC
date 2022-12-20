using PasswordManager.Service.Cryptography.Common;
using PasswordManager.Service.Cryptography.Keys;
using System.Collections.Generic;

namespace PasswordManager.Service.Cryptography.Decrypt
{
    public class Decryption : DecryptionService
    {
        public List<string> DecryptionProcess(List<string> ListToDecryption)
        {
            List<string> Cipher = new();
            List<string> OrderOfKeys = new();
            List<int> ListToDecryptionInteger = new();

            Key consonant = new();
            Key vowel = new();
            Key number = new();
            Key specialChar = new();

            List<Key> ListKeys = new(){
                consonant,
                vowel,
                number,
                specialChar
            };

            AllChars allChars = new();
            List<List<string>> ListChars = new()
            {
                allChars.consonants,
                allChars.vowels,
                allChars.numbers,
                allChars.specialChars
            };


            ListToDecryptionInteger = GetKeys(ListToDecryption);

			for (int i = 0; i < ListKeys.Count; i++)
            {
				ListToDecryptionInteger = SetAmount(ListKeys[i], ListToDecryptionInteger);
            }

            for (int i = 0; i < ListKeys.Count; i++)
            {
				ListToDecryptionInteger = SetIndexes(ListKeys[i], ListToDecryptionInteger);
            }

            for (int i = 0; i < ListToDecryptionInteger.Count; i++)
            {
                OrderOfKeys.Add(CheckTypeOfKey(ListToDecryptionInteger[i]));
            }

            string temp; //as OrderOfKeys[x] in normal string (thank to switch, which want accept List<string>[x])

            for (int i = 0; i < OrderOfKeys.Count; i++)
            {
                temp = OrderOfKeys[i];

                switch (temp)
                {
                    case "consonant":
						Cipher.Add(UpdateCipher(ListKeys[0], allChars.consonants));
                        break;
                    case "consonantBig":
						Cipher.Add(UpdateCipher(ListKeys[0], allChars.consonants, "big"));
                        break;
                    case "vowel":
						Cipher.Add(UpdateCipher(ListKeys[1], allChars.vowels));
                        break;
                    case "vowelBig":
						Cipher.Add(UpdateCipher(ListKeys[1], allChars.vowels, "big"));
                        break;
                    case "number":
						Cipher.Add(UpdateCipher(ListKeys[2], allChars.numbers));
                        break;
                    case "specialChar":
						Cipher.Add(UpdateCipher(ListKeys[3], allChars.specialChars));
                        break;
                }
            }

            return Cipher;
        }

        public string StartProcessOfDecryption(string encryptedPassword)
        {
            string result;

			List<string> ListToDecryption = new();

            ListToDecryption = ConvertStringToList(encryptedPassword);

            ListToDecryption = DecryptionProcess(ListToDecryption);

            result = string.Join("", ListToDecryption.ToArray());

            return result;
        }
    }
}
