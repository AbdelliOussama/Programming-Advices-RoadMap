namespace Course20.Console.GenericClasses_005
{
    internal class GenericClassStartHere
    {
        public GenericClassStartHere() => startHere();

        public void startHere()
        {
            GenericBox<int> intBox = new(1);
            System.Console.WriteLine(intBox.getContent());

            GenericBox<string> stringBox2 = new("hello world");
            System.Console.WriteLine(stringBox2.getContent());
        }
    }
}
