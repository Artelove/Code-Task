using System;
class HelloWorld
{
    static void Main()
    {
        HelloWorld helloWorld = new HelloWorld();
        Console.WriteLine(helloWorld.IsPalindrome(1000000001));
    }
    public bool IsPalindrome(int x)
    {
        int a, b, tmpX = x;
        int counter = 1;
        int digitCounter = 0;
        if(x<0) return false; 
        while (tmpX > 0)
        {
            digitCounter++;
            tmpX /= 10;
        }
       
        digitCounter--;
        while (true)
        {
            a = x % (IntPow(10,counter)) / (IntPow(10,counter - 1));
            b = x / IntPow(10,digitCounter) % (IntPow(10, 1));
            if (counter == 1) b = x / IntPow(10, digitCounter) % 10;
            if (digitCounter < counter) return true;
            if (a != b) 
                return false;
            counter++;
            digitCounter--;
        }
        return true;
    }

    private int IntPow(int degree, int count)
    {
        int value = degree;
        for (int i = 1; i < count; i++)
        {
            value *= degree;
        }
        if (count == 0) return 1;
        return value;
    }
}
    