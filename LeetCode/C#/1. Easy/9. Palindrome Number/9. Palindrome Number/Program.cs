using System;
class Program
{
    static void Main()
    {
        int x = 123321;
        Program program = new Program();
        Console.WriteLine(program.IsPalindrome(x));
    }

    public bool IsPalindrome(int x)
    {
        string str;
        str = x.ToString();
        int centerCharIndex = str.Length / 2;
        for (int i = 0; i < centerCharIndex; i++)
        {
            if (str[i] != str[str.Length -1 - i])
                return false;
        }
        return true;
    }
}
