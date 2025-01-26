using System.Xml.Serialization;

namespace Course20.Console.Serialization_002.XMLSerialization_1
{
    internal class JSONSerialization_Saleem
    {
        XmlSerializer serializer = new(typeof(Person));

        public void serialize(Person person, string outputXMLFilePath)
        {
            using TextWriter writer = new StreamWriter(outputXMLFilePath);
            serializer.Serialize(writer, person);
        }

        public void deSerialize(string xmlFilePath, Person deSerializedPerson)
        {
            using TextReader reader = new StreamReader(xmlFilePath);
            deSerializedPerson = (Person)serializer.Deserialize(reader);
            System.Console.WriteLine($"Id: {deSerializedPerson.Id}, Name: {deSerializedPerson.Name}, Age: {deSerializedPerson.Age}");
            System.Console.ReadKey();
        }
    }
}