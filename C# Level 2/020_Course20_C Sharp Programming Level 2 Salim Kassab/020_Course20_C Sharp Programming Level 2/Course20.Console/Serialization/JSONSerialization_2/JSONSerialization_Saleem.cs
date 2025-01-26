using System.Runtime.Serialization.Json;

namespace Course20.Console.Serialization_002.JSONSerialization_2
{
    public class JSONSerialization_Saleem
    {
        DataContractJsonSerializer serializer = new(typeof(Person));

        public void serialize(Person person, string outputJSONFilePath)
        {
            using MemoryStream stream = new();
            serializer.WriteObject(stream, person);
            string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());
            File.WriteAllText(outputJSONFilePath, jsonString);
        } 

        public void deSerialize(string jsonFilePath, Person deSerializedPerson)
        {
            using FileStream stream = new(jsonFilePath, FileMode.Open);
            deSerializedPerson = (Person)serializer.ReadObject(stream);
            System.Console.WriteLine($"id: {deSerializedPerson.Id}, name: {deSerializedPerson.Name}, age: {deSerializedPerson.Age}");
            System.Console.ReadKey();
        }
    }
}