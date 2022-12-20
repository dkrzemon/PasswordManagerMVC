namespace PasswordManager.Service.Cryptography.Keys
{
    public class Key : IKeysService
    {
        public List<string> Indexes { get; set; }
        public int Amount { get; set; }
    }
}