using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Poker
    {


        public bool Fourcard(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num1 == num2 && num1 == num3 && num1 == num4
                || num2 == num3 && num2 == num4 && num2 == num5)
            {
                return true;
            }

            return false;
        }

        public bool FullHouse(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num1 == num2 && num1 == num3 && num4 == num5
                || num1 == num2 && num3 == num4 && num3 == num5)
            {
                return true;
            }
                return false;
        }
        public bool Mountain(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {

            if (num1 == 9 && num2 == 10 && num3 == 11 && num4 == 12 && num5 == 13)
            {
                return true;
            }

            return false;
        }
        public bool Straith(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num2 == num1 + 1 && num3 == num1 + 2 && num4 == num1 + 3 && num5 == num1 + 4)
            {
                return true;
            }

            return false;
        }
        public bool Triple(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num1 == num2 && num1 == num3
                || num2 == num3 && num2 == num4
                || num3 == num4 && num3 == num5)
            {
                return true;
            }

            return false;
        }
        public bool TwoPaire(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num1 == num2 && num3 == num4
                || num1 == num2 && num4 == num5
                || num2 == num3 && num4 ==num5)
            {
                return true;
            }

            return false;
        }
        public bool OnePaire(ref int num1, ref int num2, ref int num3, ref int num4, ref int num5)
        {
            if (num1 == num2 || num2 == num3 || num3 == num4 || num4 == num5)
            {
                return true;
            }

            return false;
        }

    }

}
