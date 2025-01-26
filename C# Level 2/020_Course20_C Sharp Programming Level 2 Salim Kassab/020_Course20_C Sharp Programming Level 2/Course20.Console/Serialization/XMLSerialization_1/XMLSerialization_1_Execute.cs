namespace Course20.Console.Serialization_002.XMLSerialization_1
{
    internal class JSONSerialization_1_Execute
    {
        public JSONSerialization_1_Execute()
        {
            JSONSerialization_Saleem xMLSerialization_Saleem = new();
            //xMLSerialization_Saleem.serialize(new Person() { Id = 1, Name = "saleem", Age = 29 }, "person.xml");
            xMLSerialization_Saleem.deSerialize("person.xml", new Person());
        }
    }
}
