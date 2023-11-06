п»їnamespace BankAccount
{
    internal class StringLibrary : IDisposable
    {
        private string? _reverseString;
        private int _length;
        private readonly string _pathForRead = "C:\\Users\\indee\\source\\repos\\BankAccount\\BankAccount\\address.txt";
        private readonly string _pathForWrite = "C:\\Users\\indee\\source\\repos\\BankAccount\\BankAccount\\email.txt";
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
        public void SearchMail(ref string value)
        {
            var str_value = value.Split(" ");
            value = "";
            foreach (var item in str_value)
            {
                if (item.Contains("@"))
                {
                    value += $"{item} ";
                }
            }
            Console.WriteLine($"РЎС‚СЂРѕРєР° РІ РјРµС‚РѕРґРµ: {value}");
        }
        public void setStringInFile(string value)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_pathForWrite);
                SearchMail(ref value);
                sw.WriteLine(value);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Dispose();
            }           
        }

        public string getStringFromFile()
        {
            String? line;
            string newline = "";
            try
            {
                StreamReader sr = new StreamReader(_pathForRead);
                line = sr.ReadLine();
                newline += line;

                while (line != null)
                {
                    line = sr.ReadLine();
                    newline += line;
                }
                sr.Close();
                return newline;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Dispose();
            }
            return null!;
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
            if (ReverseString is not null)
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
        public void Dispose()
        {

        }
        public StringLibrary()
        {

        }
    }
}
