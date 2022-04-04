using System.Collections;
using Xunit;

namespace TestSearchFuncionalityKata
{
    public class SearchFuncionalitySpects
    {
        [Fact]
        public void If_the_search_text_is_fewer_than_2_characters_then_should_return_no_results()
        {
            string input = "V";

            IEnumerable result = SearchFunctionality.Search(input);

            Assert.Empty(result);
        }
    }
}