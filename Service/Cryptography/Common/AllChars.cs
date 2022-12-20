namespace PasswordManager.Service.Cryptography.Common
{
    public class AllChars
    {
        public List<string> alphabet { get; set; }
        public List<string> consonants { get; set; }
        public List<string> vowels { get; set; }
        public List<string> numbers { get; set; }
        public List<string> specialChars { get; set; }

        public AllChars()
        {
            alphabet = new();
            alphabet.Add("A");
            alphabet.Add("B");
            alphabet.Add("C");
            alphabet.Add("D");
            alphabet.Add("E");
            alphabet.Add("F");
            alphabet.Add("G");
            alphabet.Add("H");
            alphabet.Add("I");
            alphabet.Add("J");
            alphabet.Add("K");
            alphabet.Add("L");
            alphabet.Add("M");
            alphabet.Add("N");
            alphabet.Add("O");
            alphabet.Add("P");
            alphabet.Add("R");
            alphabet.Add("S");
            alphabet.Add("T");
            alphabet.Add("U");
            alphabet.Add("W");
            alphabet.Add("X");
            alphabet.Add("Y");
            alphabet.Add("Z"); //24 elements, 0-23

            consonants = new();
            consonants.Add("b"); //1
            consonants.Add("c"); //2
            consonants.Add("d"); //3
            consonants.Add("f"); //4
            consonants.Add("g"); //5
            consonants.Add("h"); //6
            consonants.Add("j"); //7
            consonants.Add("k"); //8
            consonants.Add("l"); //9
            consonants.Add("m"); //10
            consonants.Add("n"); //11
            consonants.Add("p"); //12
            consonants.Add("r"); //13
            consonants.Add("s"); //14
            consonants.Add("t"); //15
            consonants.Add("w"); //16
            consonants.Add("z"); //17 elements, 0-16

            vowels = new();
            vowels.Add("a"); //1
            vowels.Add("e"); //2
            vowels.Add("i"); //3
            vowels.Add("o"); //4
            vowels.Add("u"); //5
            vowels.Add("y"); //6 elements, 0-5

            numbers = new();
            numbers.Add("9"); //
            numbers.Add("8"); //
            numbers.Add("7"); //
            numbers.Add("6"); //
            numbers.Add("5"); //
            numbers.Add("4"); //
            numbers.Add("3"); //
            numbers.Add("2"); //
            numbers.Add("1"); //
            numbers.Add("0"); //10 elements, 0-9

            specialChars = new();
            specialChars.Add("`"); //
            specialChars.Add("~"); //
            specialChars.Add("!"); //
            specialChars.Add("@"); //
            specialChars.Add("#"); //
            specialChars.Add("$"); //
            specialChars.Add("%"); //
            specialChars.Add("^"); //
            specialChars.Add("&"); //
            specialChars.Add("*"); //
            specialChars.Add("("); //
            specialChars.Add(")"); //
            specialChars.Add("-"); //
            specialChars.Add("_"); //
            specialChars.Add("="); //
            specialChars.Add("+"); //
            specialChars.Add("["); //
            specialChars.Add("{"); //
            specialChars.Add("]"); //
            specialChars.Add("}"); //
            specialChars.Add(" "); //
            specialChars.Add("\u005c"); // this -> /
            specialChars.Add("|"); //
            specialChars.Add(";"); //
            specialChars.Add(":"); //
            specialChars.Add("'"); //
            specialChars.Add("\u02ba"); //this -> "
            specialChars.Add(","); //
            specialChars.Add("<"); //
            specialChars.Add("."); //
            specialChars.Add(">"); //
            specialChars.Add("/"); //
            specialChars.Add("?"); //33 elements, 0-32
        }
    }
}