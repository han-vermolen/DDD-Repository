namespace DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Queries
{
    public class Query
    {
        public Hello GetHello()
        {
            return new("Test");
        }
    }

    public class Hello
    {
        public Hello(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}