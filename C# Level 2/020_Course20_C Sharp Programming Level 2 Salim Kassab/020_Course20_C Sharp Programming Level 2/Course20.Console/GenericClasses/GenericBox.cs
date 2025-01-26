namespace Course20.Console.GenericClasses_005
{
    internal class GenericBox<T>
    {
        private T _content;
        public GenericBox(T value) => _content = value;

        public T getContent() => _content;
    }
}
