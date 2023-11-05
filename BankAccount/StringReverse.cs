п»їnamespace BankAccount
{
    internal class StringLibrary
    {
        private string? _reverseString;
        private int _length;

        public string? ReverseString
        {
            get { return _reverseString; }
            set
            {
                if (value is not null)
                {
                    _reverseString = value;
                    StringLength = _reverseString.Length - 1;
                } 
                else
                {
                    _reverseString = null;
                }
            }
        }
        public void PrintString(string str)
        {
            Console.WriteLine(str);
        }
        private int StringLength
        {
            get { return _length; }
            set { _length = value; }
        }
        public string? returnReverseString()
        {
            if(ReverseString is not null)
            {
                char[] chars = ReverseString.ToCharArray();
                for (int i = 0; i < StringLength; i++)
                {
                    char temp = ReverseString[StringLength - i];
                    chars[StringLength - i] = ReverseString[i];
                    chars[i] = temp;
                }
                return new string(chars);
            }
            return null;
        }

        public StringLibrary()
        {

        }
    }
}
