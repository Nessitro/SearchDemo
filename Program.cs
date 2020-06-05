using System;
using System.Linq;
using System.Collections.Generic;
using NinjaNye.SearchExtensions;

namespace AdvancedSearch
{
    class Program
    {
        static void Main(string[] args)
        {
             var userList = new List<string>(){
                "abdellah",
                "Abdellah",
                "abdellah ",
                "Abdellah ",
                " ousrhire",
                " Ousrhire",
                " ousrhire",
                " Ousrhire",
                " Ousrhire",
                " Ousrhire",
                " Ousrhire",
                "Abdellah Ousrhire",
                "abdellah ousrhire",
            };

            var keyword = "ousrhire abdellah"
            .ToLower()
            .Split(" ")
            .Select(s=>s?.Trim())
            .ToArray();

            Console.WriteLine($"KEYWORD: {keyword}");

            var result = userList
            .Search(s=>s)
            .Containing(keyword)
            .ToList();



            result
            .ForEach((res)=>{
            Console.WriteLine(res);
            });

            Console.ReadLine();
        }
    }
}
