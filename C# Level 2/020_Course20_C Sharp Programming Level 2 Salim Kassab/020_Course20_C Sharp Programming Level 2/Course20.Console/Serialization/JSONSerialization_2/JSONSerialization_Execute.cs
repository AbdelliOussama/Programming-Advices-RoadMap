namespace Course20.Console.Serialization_002.JSONSerialization_2
{
    public class JSONSerialization_Execute
    {
        public JSONSerialization_Execute()
        {
            JSONSerialization_Saleem jSONSerialization_Saleem = new();
            //jSONSerialization_Saleem.serialize(new Person() { Id = 1, Name = "saleem", Age = 29 }, "person.json");
            jSONSerialization_Saleem.deSerialize("person.json",new Person());
        }

    }
}
