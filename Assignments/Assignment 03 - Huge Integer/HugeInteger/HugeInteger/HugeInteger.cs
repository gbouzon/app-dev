using System;
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

        public int[] Input()
        {
            return Array.ConvertAll(this.NumberStr.ToCharArray(), c => (int)Char.GetNumericValue(c));
        }

        public override string ToString()
        {
            return NumberStr; //to print object
        }
            

        public string ToString(int[] intArray)
        {
            return string.Join("", intArray); //transforms array back into string
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

        public int[] ToIntArray(HugeInteger h, int maxLength)
        {
            if (h.NumberStr.Length == maxLength)
                return h.Input();
            else
            {
                int[] num1 = new int[maxLength];
                int length = maxLength - h.NumberStr.Length;
                h.Input().CopyTo(num1, length);
                return num1;
            }
        }

        public HugeInteger Add(HugeInteger h1, HugeInteger h2)
        {
            if (IsNegative(h1) && IsNegative(h2))
            {
                string h1New = h1.NumberStr.Replace("-", "0");
                string h2New = h2.NumberStr.Replace("-", "0");
                HugeInteger finalResult = Add(new HugeInteger(h1New), new HugeInteger(h2New));
                return new HugeInteger("-" + finalResult.NumberStr);
            }

            else if (IsNegative(h1))
                return Subtract(h2, new HugeInteger(h1.NumberStr.Replace("-", "0")));

            else if (IsNegative(h2))
                return Subtract(h1, new HugeInteger(h2.NumberStr.Replace("-", "0")));
           
            else
            {
                //get max length between h1 and h2 to have 2 arrays of the same size
                int maxLength = Math.Max(h1.NumberStr.Length, h2.NumberStr.Length);

                //creating int arrays
                int[] num1 = ToIntArray(h1, maxLength);
                int[] num2 = ToIntArray(h2, maxLength);
                int[] surplus = new int[maxLength]; //to add when num1+num2 > 9
                int[] result = new int[maxLength + 1];

                for (int i = maxLength - 1; i >= 0; i--)
                {
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

                return new HugeInteger(ToString(result));
            }
        }

        public void Borrow(int position, int[] array) 
        {
            //gives 10 units to number after position
            //takes 1 unit from number at position
            if (array[position] != 0)
            {
                array[position + 1] += 10;
                array[position]--;
            }

            else
                if (position > 0)
                    Borrow(position - 1, array); 
        }

        public HugeInteger Subtract(HugeInteger h1, HugeInteger h2)
        {
            if (IsNegative(h1) && IsNegative(h2))
                return Add(h1, new HugeInteger(h2.NumberStr.Replace("-", "0")));

            else if (IsNegative(h1))
                return Add(h1, new HugeInteger("-" + h2.NumberStr));

            else if (IsNegative(h2))
                return Add(h1, new HugeInteger(h2.NumberStr.Replace("-", "0")));

            else
            {
                //get max length between h1 and h2 to have 2 arrays of the same size
                int maxLength = Math.Max(h1.NumberStr.Length, h2.NumberStr.Length);

                //creating int arrays
                int[] num1 = ToIntArray(h1, maxLength);
                int[] num2 = ToIntArray(h2, maxLength);
                int[] result = new int[maxLength];

                string finalResult = "";

                for (int i = maxLength - 1; i >= 0; i--)
                {
                    if (IsGreaterThanOrEqualTo(h1, h2))
                    {
                        while (num1[i] - num2[i] < 0 && i > 0)
                            Borrow(i - 1, num1);

                        result[i] = num1[i] - num2[i];
                        finalResult = ToString(result);
                    }
                    else
                    {
                        while (num2[i] - num1[i] < 0 && i > 0)
                            Borrow(i - 1, num2);

                        result[i] = num2[i] - num1[i];
                        finalResult = "-" + ToString(result);
                    }
                }
                return new HugeInteger(finalResult);
            }
        }

        public Boolean IsZero(HugeInteger h1)
        {
            for (int i = 0; i < h1.Input().Length; i++)
                if (h1.Input()[i] != 0)
                    return false;

            return true; //only returns true if ALL chars in the array are zero
        }

        public Boolean IsNegative(HugeInteger h1)
        {
            if (h1.NumberStr[0].Equals('-'))
                return true;

            return false;
        }

        public Boolean IsEqualTo(HugeInteger h1, HugeInteger h2)
        {
            //get max length between h1 and h2
            int maxLength = Math.Max(h1.NumberStr.Length, h2.NumberStr.Length);

            //2 arrays of the same size in case we have the same number but one with extra zeros at the beginning
            int[] num1 = ToIntArray(h1, maxLength);
            int[] num2 = ToIntArray(h2, maxLength);

            for (int i = 0; i < maxLength; i++)
                if (num1[i] != num2[i])
                    return false;

            return true;
        }

        public Boolean IsNotEqualTo(HugeInteger h1, HugeInteger h2)
        {
            if (IsEqualTo(h1, h2))
                return false;

            return true;
        }

        public Boolean IsGreaterThan(HugeInteger h1, HugeInteger h2)
        {
            if (IsEqualTo(h1, h2))
                return false;

            else if (IsNegative(h1) && IsNegative(h2))
                return IsLessThan(new HugeInteger(h1.NumberStr.Replace("-", "0")), new HugeInteger(h2.NumberStr.Replace("-", "0")));

            else if (IsNegative(h1))
                return false;

            else if (IsNegative(h2))
                return true;

            else
            {
                //get max length between h1 and h2
                int maxLength = Math.Max(h1.NumberStr.Length, h2.NumberStr.Length);

                //2 arrays of the same size in case we have the same number but one with extra zeros at the beginning
                int[] num1 = ToIntArray(h1, maxLength);
                int[] num2 = ToIntArray(h2, maxLength);

                for (int i = 0; i < maxLength; i++)
                {
                    if (num1[i] > num2[i])
                        return true;
                    else if (num1[i] < num2[i])
                        return false;
                }
                return false;
            }
        }

        public Boolean IsLessThan(HugeInteger h1, HugeInteger h2)
        {
            if (IsEqualTo(h1, h2) || IsGreaterThan(h1, h2))
                return false;

            return true;
        }

        public Boolean IsGreaterThanOrEqualTo(HugeInteger h1, HugeInteger h2)
        {
            if (IsGreaterThan(h1, h2) || IsEqualTo(h1, h2))
                return true;

            return false;
        }

        public Boolean IsLessThanOrEqualTo(HugeInteger h1, HugeInteger h2)
        {
            if (IsLessThan(h1, h2) || IsEqualTo(h1, h2))
                return true;

            return false;
        }
    }
}
