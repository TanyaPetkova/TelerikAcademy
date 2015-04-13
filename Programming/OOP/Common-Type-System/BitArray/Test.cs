namespace BitArray
{
    using System;

    class Test
    {
        static void Main()
        {
            BitArray64 bitaArray = new BitArray64(100);
            BitArray64 otherBitaArray = new BitArray64(100);

            Console.WriteLine(string.Join("", bitaArray.BitArray));
            Console.WriteLine(string.Join("", otherBitaArray.BitArray));
            Console.WriteLine(bitaArray.Equals(otherBitaArray)); //False
            Console.WriteLine(bitaArray.GetHashCode());
            Console.WriteLine(otherBitaArray.GetHashCode());
            
        }
    }
}
