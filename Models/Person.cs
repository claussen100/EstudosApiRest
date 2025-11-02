namespace EstudosApiRest.Models
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; }
        public required string Name { get; set; }
    }
}
