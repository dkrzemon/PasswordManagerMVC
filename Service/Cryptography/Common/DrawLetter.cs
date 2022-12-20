namespace PasswordManager.Service.Cryptography.Common
{
    public class DrawLetter
    {
        public string DrawLetterFromAToZ()
        {
            AllChars allChars = new(); //load all arrays from class AllChars
            Random generator = new();

            int number = generator.Next(23);
            string letterToReturn;

            letterToReturn = allChars.alphabet[number];

            if (number % 2 == 0) letterToReturn = letterToReturn.ToLower();

            return letterToReturn;
        }
    }
}