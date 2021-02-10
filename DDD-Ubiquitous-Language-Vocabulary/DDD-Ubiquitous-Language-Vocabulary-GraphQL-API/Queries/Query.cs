using System.Collections.Generic;
using System.Linq;
using HotChocolate.Data;
using DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Models;

namespace DDD_Ubiquitous_Language_Vocabulary_GraphQL_API.Queries
{
    public class Query
    {
        public static List<Term> _terms = new List<Term>();
        
        public Query()
        {
            _terms.Add(new Term("Ubiquitous Language", "A UL"));
            _terms.Add(new Term("Query", "A Query"));
            _terms.Add(new Term("Request", "A Request"));
            _terms.Add(new Term("Response", "A Response"));
        }

        [UseFiltering]
        [UseSorting]
        public IQueryable<Term> GetTerms()
        {
            return _terms.AsQueryable();
        }
    }
}