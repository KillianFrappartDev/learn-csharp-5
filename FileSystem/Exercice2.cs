using System;
using System.IO;

namespace FileSystem
{
    public class Exercice2
    {
        public static string Answer(string path)
        {
            var text = File.ReadAllText(path);
            var textArr = text.Split(" ", text.Length);
            var longest = textArr[0];

            for (var i = 1; i < textArr.Length; i++)
            {
                if (textArr[i].Length > longest.Length) longest = textArr[i];
            }

            return longest;
        }
    }
}