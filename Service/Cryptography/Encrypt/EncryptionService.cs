using PasswordManager.Service.Cryptography.Common;
using PasswordManager.Service.Cryptography.Keys;

namespace PasswordManager.Service.Cryptography.Encrypt
{
    public class EncryptionService : CryptService
    {
        public List<string> AddAmountOfKeyToCipher(Key IndividualKey, List<string> cipher)
        {
            cipher.Add("" + IndividualKey.Amount);
            cipher.Add(AddLetter());

            return cipher;
        }

        public List<string> AddIndexesOfKeyToCipher(Key IndividualKey, List<string> cipher)
        {
            foreach (string key in IndividualKey.Indexes)
            {
                cipher.Add(key);

                cipher.Add(AddLetter());
            }

            return cipher;
        }

        public List<string> AddOrderOfKeysToCipher(List<string> listToEncryption, List<List<string>> listChars, List<string> cipher)
        {
            List<int> listTemp = new();

            string stringTemp;

            for (int i = 0; i < listToEncryption.Count; i++) //loop of main text to encryption
            {
                stringTemp = listToEncryption[i].ToString();

                for (int j = 0; j < listChars.Count; j++) //loop of 4 arrays from listChars
                {
                    for (int k = 0; k < listChars[j].Count; k++) //loop of each one array from ListChars
                    {
                        if (stringTemp.ToLower() == listChars[j][k].ToString())
                        {
                            switch (j)
                            {
                                case 0: //consonant
                                    if (char.IsLower(stringTemp, 0))
                                    {
                                        listTemp.Add(DrawNumber("consonant"));
                                    }
                                    else
                                    {
                                        listTemp.Add(DrawNumber("consonantBig"));
                                    }

                                    break;
                                case 1: //vowel
                                    if (char.IsLower(stringTemp, 0))
                                    {
                                        listTemp.Add(DrawNumber("vowel"));
                                    }
                                    else
                                    {
                                        listTemp.Add(DrawNumber("vowelBig"));
                                    }
                                    break;
                                case 2: //number
                                    listTemp.Add(DrawNumber("number"));
                                    break;
                                case 3: //specialChar
                                    listTemp.Add(DrawNumber("specialChar"));
                                    break;
                                default:
                                    Console.WriteLine("EncryptService->AddOrderOfKeysToCipher()->switch");
                                    Thread.Sleep(1500);
                                    break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            foreach (int temp in listTemp)
            {
                cipher.Add(temp + "");
                cipher.Add(AddLetter());
            }

            return cipher;
        }

        public string AddLetter()
        {
            string temp;

            DrawLetter drawLetter = new();
            temp = drawLetter.DrawLetterFromAToZ();

            return temp;
        }

        public int DrawNumber(string whichOne)
        {
            Random generator = new();

            int numberToReturn = 0;

            switch (whichOne)
            {
                case "consonant":
                    numberToReturn = generator.Next(0, 3);
                    break;
                case "consonantBig":
                    numberToReturn = generator.Next(3, 6);
                    break;
                case "vowel":
                    numberToReturn = generator.Next(6, 9);
                    break;
                case "vowelBig":
                    numberToReturn = generator.Next(9, 12);
                    break;
                case "number":
                    numberToReturn = generator.Next(12, 15);
                    break;
                case "specialChar":
                    numberToReturn = generator.Next(15, 18);
                    break;
            }

            return numberToReturn;
        }
    }
}