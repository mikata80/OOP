using System;
using System.Collections.Generic;
using System.Numerics;
 

namespace Static_Members_and_Namespaces
{

    class loadBitArray
    {
        public static void Main()
        {
            BitArray bits = new BitArray(10);
            Console.WriteLine(bits.ToString());
        }
    }
    class BitArray


    {
        private byte[] bits;

        public BitArray(int n)
        {
            if (n < 1 || n > 100000)
            {
                throw new IndexOutOfRangeException("The value must be in range [1..100000]");
            }

            this.bits = new byte[n];
        }

        public byte this[int index]
        {
            get
            {
                return this.bits[index];
            }
            set
            {
                if (index < 0 || index > this.bits.Length - 1)
                {
                    throw new IndexOutOfRangeException("The value must be in range [0.." + (this.bits.Length - 1) + "]");
                }
                if (value != 0 && value != 1)
                {
                    throw new IndexOutOfRangeException("The value must be 1 or 0");
                }
                this.bits[index] = value;
            }
        }

        public override string ToString()
        {
            BigInteger number = new BigInteger(0) ;

            for (int i = 0; i < this.bits.Length; i++)
            {
                if (this.bits[i] == 1)
                {
                    number += BigInteger.Pow(2, i);
                }
            }

            return number.ToString();
        }
        //private byte[] arrBits;

        //public BitArray(int size)
        //{
        //    if (size < 0 || size > 100000)
        //    {
        //        throw new ArgumentOutOfRangeException("The size must be betwee 1 and 100 000!");
        //    }
        //    else
        //    {
        //        this.arrBits = new byte[size];
        //    }
        //}

        //public byte this[int size]
        //{
        //    get
        //    {
        //        return this.arrBits[size];
        //    }
        //    set
        //    {
        //        if (size < 0 || size > this.arrBits.Length - 1)
        //        {
        //            throw new IndexOutOfRangeException("The value must be in range [0.." + (this.arrBits.Length - 1) + "]");
        //        }
        //        if (value != 0 && value != 1)
        //        {
        //            throw new IndexOutOfRangeException("The value must be 1 or 0");
        //        }
        //        this.arrBits[size] = value;
        //    }
        //}
        //public override string ToString()
        //{

        //    string res = "";
        //    for (int i = 0; i < arrBits.Length; i++)
        //    {
        //        res += String.Format("bits[{0}] = {1}\n",i,arrBits[i]);
        //    }


        //    return res;
        //}

    }

}
