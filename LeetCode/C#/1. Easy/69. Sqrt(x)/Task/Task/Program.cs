using System;
using System.Xml.Schema;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            int x = 2147395599;
            Console.WriteLine(program.MySqrt(x));
        }

        public int MySqrt(int x)
        {
            int start, end;
            long mid = 0;
            start = 0;
            end = x;
            if(x==1) return 1;
            if(x==0) return 0;

            while (start<=end)
            {
                mid = (start + end) / 2; 
    
                if (x >= (mid-1)*(mid-1) && x <= mid*mid )
                {
                    if(mid*mid==x) return (int)mid;
                    else return (int)(mid-1);
                }

                else if (mid * mid > x)
                {
                    end = (int)(mid-1);
                }

                else
                {start = (int)(mid+1);}
        
            }

            return (int)mid;
        }
    }
}