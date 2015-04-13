namespace VersionAttribute
{
    using System;
    using System.Reflection;

    [VersionAttribute(2, 11)]
    class Test
    {
        static void Main()
        {
            object[] allAttributes = typeof(Test).GetCustomAttributes(false);

            foreach (var attribute in allAttributes)
            {
               Console.WriteLine("{0}: {1}", attribute.GetType().Name, attribute);
            }
        }
    }
}
