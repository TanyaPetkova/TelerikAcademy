namespace _01.StringBuilderExtension
{
    using System;
    using System.Text;

    static class ExtensionMethod
    {
        private static void ValidateParameters(StringBuilder inputString, int index, int length)
        {
            if (index < 0 || index > inputString.Length - 1)
            {
                throw new IndexOutOfRangeException("The input index is outside the string boudaries.");
            }

            if (index + length > inputString.Length )
            {
                throw new IndexOutOfRangeException("The last index of the desired part of the string is greater than its length.");
            }

            if (length > inputString.Length || length < 0)
            {
                throw new IndexOutOfRangeException("The desired length is outside the string boudaries.");
            }
        }

        //First variant using String.Substring()
        //public static StringBuilder Substring(this StringBuilder inputString, int index, int length)
        //{
        //    ValidateParameters(inputString, index, length);
        //    StringBuilder newString = new StringBuilder();

        //    newString.Append(inputString.ToString().Substring(index, length));

        //    return newString;
        //}

        //Second variant using for loop
        public static StringBuilder Substring(this StringBuilder inputString, int index, int length)
        {
            ValidateParameters(inputString, index, length); 
            StringBuilder newString = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                newString.Append(inputString[i]);
            }

            return newString;
        }
    }
}
