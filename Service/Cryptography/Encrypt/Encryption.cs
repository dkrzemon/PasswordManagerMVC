using PasswordManager.Service.Cryptography.Common;
using PasswordManager.Service.Cryptography.Keys;

namespace PasswordManager.Service.Cryptography.Encrypt
{
    public class Encryption : EncryptionService
    {
        public List<string> EncryptionProcess(List<string> ListToEncryption)
        {
            List<string> Cipher = new();

            Key consonant = new();
            Key vowel = new();
            Key number = new();
            Key specialChar = new();

            List<Key> listKeys = new(){
                consonant,
                vowel,
                number,
                specialChar
            };

            AllChars allChars = new();
            List<List<string>> listChars = new()
            {
                allChars.consonants,
                allChars.vowels,
                allChars.numbers,
                allChars.specialChars
            };

            KeysService keysService = new();

            for (var i = 0; i < 4; i++)
            {
                keysService.SetIndexesAndAmount(listKeys[i], allChars.alphabet, listChars[i], ListToEncryption);
            }

            for (var i = 0; i < 8; i++)
            {
                Cipher = i < 4 ? AddAmountOfKeyToCipher(listKeys[i], Cipher) : Cipher = AddIndexesOfKeyToCipher(listKeys[i - 4], Cipher);
            }

            AddOrderOfKeysToCipher(ListToEncryption, listChars, Cipher);

            return Cipher;
        }

        public string StartProcessOfEncryption(string password)
        {
            string result;

            List<string> ListToEncryption = new();

            ListToEncryption = ConvertStringToList(password);

            ListToEncryption = EncryptionProcess(ListToEncryption);

            result = string.Join("", ListToEncryption.ToArray());

            return result;
        }
    }
}