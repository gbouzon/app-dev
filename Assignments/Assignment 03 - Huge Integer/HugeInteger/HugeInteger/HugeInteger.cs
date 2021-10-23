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
        private String number;

        //constructor
        public HugeInteger(String number)
        {
            number = Number;
        }

        public String Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public char[] Input(HugeInteger h1)
        {
            return h1.Number.ToCharArray();
        }

        public String ToString(char[] charArray)
        {
            return charArray.ToString();
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

        public HugeInteger Add(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        public HugeInteger Subtract(HugeInteger h1, HugeInteger h2)
        {
            return new HugeInteger("change this later");
        }

        public Boolean IsZero(HugeInteger h1)
        {
            for (int i = 0; i < Input(h1).Length; i++)
                if (Input(h1)[i] != 0)
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
