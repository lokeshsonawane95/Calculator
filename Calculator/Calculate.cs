using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int subtraction(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }
        public int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public float division(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
