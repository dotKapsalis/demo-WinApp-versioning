using System;

namespace demoTool.Desktop
{
    public class Calculator
    {
        public int AddNumbers(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return -1;
            }
            return a + b;
        }

        public int SubtractNumbers(int a, int b)
        {
            return a - b;
        }

        public static float DivideNumbers(float a, float b)
        {
            Console.WriteLine("Dividing {0} divided by {1}", a, b);
            if(b != 0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
