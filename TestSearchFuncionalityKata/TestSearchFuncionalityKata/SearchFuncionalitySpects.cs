using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using FluentAssertions;
using Xunit;

namespace TestSearchFuncionalityKata
{
    public class SearchFuncionalitySpects
    {
        [Fact]
        public void If_the_search_text_is_fewer_than_2_characters_then_should_return_no_results()
        {
            string input = "V";

            IEnumerable<String> result = SearchFunctionality.Search(input);

            Assert.Empty(result);
        }

        [Fact]
        public void If_the_search_text_is_equal_o_r_morethn__chaactes_then_it_should_return_all_the_city_names_starting_with_the_exact_search_text()
        {
            string input = "Va";

            IEnumerable<String> result = SearchFunctionality.Search(input);

            result.Should().BeEquivalentTo(new List<string>() { "Valencia", "Vancouver" });
        }


        [Fact]
        public void If_the_search_text_is_equal_o_r_morethn__chaactes_then_it_should_return_all_the_city_names_starting_with_the_text_allow_tolower_text()
        {
            string input = "va";

            IEnumerable<String> result = SearchFunctionality.Search(input);

            result.Should().BeEquivalentTo(new List<string>() { "Valencia", "Vancouver" });
        }


        [Fact]
        public void The_search_functionality_should_work_also_when_the_search_text_is_just_a_part_of_a_city_name()
        {
            string input = "ape";

            IEnumerable<String> result = SearchFunctionality.Search(input);

            result.Should().BeEquivalentTo(new List<string>() { "Budapest"});
        }


        [Fact]
        public void if_the_search_text_is_a_asterisk_then_it_should_return_all_the_city_names()
        {
            string input = "*";

            IEnumerable<String> result = SearchFunctionality.Search(input);

            result.Should().BeEquivalentTo(new List<string>() { "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" });
        }
    }
}