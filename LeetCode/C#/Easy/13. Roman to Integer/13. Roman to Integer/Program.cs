public class Solution
{
    static void Main()
    {
        string s = "IV";
        char [] charsRomanStr = s.ToCharArray();
        int charCounter = charsRomanStr.Length-1;
        int decimalDigitValue = 0;
        int digitSum = 0;
        while (charCounter >= 0)
        { 
            char currentChar = charsRomanStr[charCounter];
            switch (currentChar)
            {
                case 'I':
                    {
                        decimalDigitValue = 1;
                        break;
                    }
                case 'V':
                    {
                        decimalDigitValue = 5;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'I')
                            {
                                decimalDigitValue = 4;
                                charCounter--;
                            }

                        }
                        break;
                    }
                case 'X':
                    {
                        decimalDigitValue = 10;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'I')
                            {
                                decimalDigitValue = 9;
                                charCounter--;
                            }

                        }
                        break;
                    }
                case 'L':
                    {
                        decimalDigitValue = 50;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'X')
                            {
                                decimalDigitValue = 40;
                                charCounter--;
                            }

                        }
                        
                        break;
                    }
                case 'C':
                    {
                        decimalDigitValue = 100;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'X')
                            {
                                decimalDigitValue = 90;
                                charCounter--;
                            }

                        }
                        break;
                    }
                case 'D':
                    {
                        decimalDigitValue = 500;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'C')
                            {
                                decimalDigitValue = 400;
                                charCounter--;
                            }

                        }
                        break;
                    }
                case 'M':
                    {
                        decimalDigitValue = 1000;
                        if (charCounter - 1 >= 0)
                        {
                            if (charsRomanStr[charCounter - 1] == 'C')
                            {
                                decimalDigitValue = 900;
                                charCounter--;
                            }

                        }
                        break;
                    }
            }
            digitSum += decimalDigitValue;
            charCounter--;
        }
        Console.WriteLine(digitSum);
    }
}