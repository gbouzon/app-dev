﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HugeInteger
{
    class HugeInteger
    {

        //attributes
        private string numberStr;

        //parameterized constructor
        public HugeInteger(string numberStr)
        {
            NumberStr = numberStr;
        }

        public string NumberStr
        {
            get
            {
                return numberStr;
            }
            set
            {
                numberStr = value;
            }
        }

        public char[] Input()
        {
            return this.NumberStr.ToCharArray();
        }

        public override string ToString()
        {
            return NumberStr; //to print object
        }


        public string ToString(char[] charArray)
        {
            return string.Join("", charArray); //transforms array back into string
        }

        public HugeInteger Multiply(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        public HugeInteger Divide(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        public HugeInteger Remainder(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        //get biggest length
        //whoever has the biggest length can keep Input() return
        //the one with the smallest length will get a new array 
        //get maxlength - current length to get starting point
        //fill beginning until starting point with zeros. - default for int array
        public int[] ToIntArray(HugeInteger h, int maxLength)
        {
            if (h.NumberStr.Length == maxLength)
                return Array.ConvertAll(h.Input(), c => (int)Char.GetNumericValue(c));
            else
            {
                int[] num1 = new int[maxLength];
                int length = maxLength - h.NumberStr.Length;
                Array.ConvertAll(h.Input(), c => (int)Char.GetNumericValue(c)).CopyTo(num1, length);
                return num1;
            }
        }

        public HugeInteger Add(HugeInteger h1, HugeInteger h2)
        {
            //get max length between h1 and h2
            int maxLength = Math.Max(h1.NumberStr.Length, h2.NumberStr.Length);

            //creating int arrays
            int[] num1 = ToIntArray(h1, maxLength);
            int[] num2 = ToIntArray(h2, maxLength);
            int[] surplus = new int[maxLength]; //to add when num1+num2 > 9
            int[] result = new int[maxLength + 1];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                //CHECKING STUFF, DEBUGGING

                //Array.ForEach(surplus, Console.Write);
                //Console.WriteLine();
                //Array.ForEach(num1, Console.Write);
                //Console.WriteLine();
                //Array.ForEach(num2, Console.Write);
                //Console.WriteLine();
                //Array.ForEach(result, Console.Write);
                //Console.WriteLine();
                //Console.WriteLine();
                if (num1[i] + num2[i] + surplus[i] > 9)
                {
                    string localResult = (num1[i] + num2[i] + surplus[i]).ToString();
                    if (i != 0)
                    {
                        result[i + 1] = (int)Char.GetNumericValue(localResult[1]);
                        surplus[i - 1] = (int)Char.GetNumericValue(localResult[0]);
                    }
                    else
                    {
                        result[i + 1] = (int)Char.GetNumericValue(localResult[1]);
                        result[0] = (int)Char.GetNumericValue(localResult[0]);
                    }
                }
                else result[i + 1] = num1[i] + num2[i] + surplus[i];
            }

            //checking result array
            //Array.ForEach(result, Console.Write);
            //Console.WriteLine(result.Length);
            return new HugeInteger(string.Join("", result));
        }

        public HugeInteger Subtract(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        public Boolean IsZero(HugeInteger h1)
        {
            for (int i = 0; i < h1.Input().Length; i++)
                if (h1.Input()[i] != 0)
                    return false;

            return true; //only returns true if ALL chars in the array are zero
            //test it laters
        }

        public Boolean IsEqualTo(HugeInteger h1, HugeInteger h2)
        {
            //logic: if (h1.length>h2.length || h1.length<h2.length) && !IsZero return false;
            return false;
        }

        public Boolean IsNotEqualTo(HugeInteger h1, HugeInteger h2)
        {
            if (IsEqualTo(h1, h2))
                return false;
            return true;
        }
        public Boolean IsGreaterThan(HugeInteger h1, HugeInteger h2)
        {
            return false;
        }

        public Boolean IsLessThan(HugeInteger h1, HugeInteger h2)
        {
            return false;
        }

        public Boolean IsGreaterThanOrEqualTo(HugeInteger h1, HugeInteger h2)
        {
            return false;
        }

        public Boolean IsLessThanOrEqualTo(HugeInteger h1, HugeInteger h2)
        {
            return false;
        }
    }
}