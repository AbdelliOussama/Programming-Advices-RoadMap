namespace Course20.Console.GenericMethods_004
{
    internal class UtilityStartHere
    {
        public UtilityStartHere() => startHere();

        private void startHere()
        {
            int first = 1, second = 2;
            System.Console.WriteLine($"first is: {first}, second is: {second}");
            Utility.swap(ref first, ref second);
            System.Console.WriteLine("after swapping");
            System.Console.WriteLine($"first is: {first}, second is: {second}");
            System.Console.WriteLine("_______________________________________");
            string x = "Hello", y = "world";
            System.Console.WriteLine($"x is: {x}, y is: {y}");
            Utility.swap(ref x, ref y);
            System.Console.WriteLine("after swapping");
            System.Console.WriteLine($"x is: {x}, x is: {y}");
        }
    }
}