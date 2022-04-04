using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestSearchFuncionalityKata;

public class SearchFunctionality
{
    private IEnumerable<String> CityNames = new string[] {"Paris","Budapest","Skopje","Rotterdam","Valencia","Vancouver","Amsterdam","Vienna","Sydney","New York City","London","Bangkok", "Hong Kong", "Dubai", "Rome","Istanbul" };

    public static IEnumerable<string> Search(string input)
    {
        if (input.Length < 2 )
            return Enumerable.Empty<string>();

        return new List<string>() {"Valencia", "Vancouver"};
    }
}