using DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Models;
using DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Queries;

namespace DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Mutations
{
    public class Mutation
    {
        public AddTerm AddTerm(AddTermInput input)
        {
            var term = new Term(input.Name, input.Description);
            Query._terms.Add(term);
            return new AddTerm(term);
        }
    }

    public record AddTermInput(string Name, string Description);

    public record AddTerm(Term Term);
}