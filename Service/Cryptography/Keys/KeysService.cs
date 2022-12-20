namespace PasswordManager.Service.Cryptography.Keys
{
    public class KeysService
    {
        public void SetIndexesAndAmount(IKeysService IndividualKey, List<string> BigLetters, List<string> ArrayCharsToCheck, List<string> listToEncryption)
        {
            int Indexes;
            IndividualKey.Indexes = new();
            IndividualKey.Amount = 0;

            foreach (string key in listToEncryption)
            {
                foreach (string temp in ArrayCharsToCheck)
                {
                    if (key.ToLower() == temp)
                    {
                        Indexes = ArrayCharsToCheck.IndexOf(key.ToLower());

                        IndividualKey.Indexes.Add("" + Indexes);
                        IndividualKey.Amount++;
                    }
                }
            }
        }
    }
}