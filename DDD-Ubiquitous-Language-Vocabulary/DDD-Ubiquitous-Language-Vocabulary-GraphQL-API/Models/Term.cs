namespace DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Models
{
    public class Term
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public Term(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}