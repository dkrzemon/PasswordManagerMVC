namespace PasswordManager.Service.Cryptography.Common
{
    public class CryptService
    {
        public List<string> ConvertStringToList(string password)
        {
            List<string> list = new();
            list.AddRange(password.Select(c => c.ToString())); //convert type of TextToEncryption from string to list

            return list;
        }
    }
}
