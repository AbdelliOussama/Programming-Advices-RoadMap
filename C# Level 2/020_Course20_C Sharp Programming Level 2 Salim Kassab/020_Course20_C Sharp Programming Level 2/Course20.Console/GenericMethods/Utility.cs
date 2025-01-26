namespace Course20.Console.GenericMethods_004
{
    internal  class Utility
    {
        public static void swap<T>(ref T first, ref T second)
        {
            T temp = second;
            second = first;
            first = temp;
        }
    }
}