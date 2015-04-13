namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class BitArray64 : IEnumerable<int>
    {
        private readonly ulong number;

        public BitArray64(ulong number)
        {
            this.number = number;
        }

        public int[] BitArray
        {
            get
            {
                return this.GetBits();
            }
        }

        public int this[int index]
        {
            get 
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("The index is out of range!");
                }

                int[] bits = this.GetBits();

                return bits[index];
            }
        }

        private int[] GetBits()
        {
            ulong number = this.number;

            int[] bits = new int[64];
            int counter = 63;

            while (number / 2 != 0)
            {
                bits[counter] = (int)number % 2;
                number /= 2;
                counter--;
            }

            bits[counter] = (int)number % 2;
            counter--;

            while (counter != 0)
            {
                bits[counter] = 0;
                counter--;
            }

            return bits;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var bit in this.BitArray)
            {
                yield return bit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitarray = obj as BitArray64;

            if (bitarray == null)
            {
                return false;
            }

            for (int i = 0; i < this.BitArray.Length; i++)
            {
                if (this.BitArray[i] != bitarray[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            FieldInfo[] fields = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            int hashCode = fields[0].GetHashCode();

            for (int i = 1; i < fields.Length; i++)
            {
                hashCode ^= fields[i].GetHashCode();
            }

            return hashCode;
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return BitArray64.Equals(firstArray, secondArray);
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(BitArray64.Equals(firstArray, secondArray));
        }
    }
}
