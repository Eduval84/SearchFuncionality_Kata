using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestSearchFuncionalityKata;

public class SearchFunctionality
{
    private static string[] _cityNames = new[] {"Paris","Budapest","Skopje","Rotterdam","Valencia","Vancouver","Amsterdam","Vienna","Sydney","New York City","London","Bangkok", "Hong Kong", "Dubai", "Rome","Istanbul" };

    public static IEnumerable<string> Search(string input)
    {
        if (input.Length < 2 )
            return Enumerable.Empty<string>();

        return Array.FindAll<String>(_cityNames, citys => citys.ToLower().Contains(input.ToLower()));
    }

}