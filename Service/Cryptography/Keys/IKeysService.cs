namespace PasswordManager.Service.Cryptography.Keys
{
    public interface IKeysService
    {
        public List<string> Indexes { get; set; }
        public int Amount { get; set; }
    }
}