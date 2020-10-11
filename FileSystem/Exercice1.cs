using System;
using System.IO;

namespace FileSystem
{
    public class Exercice1
    {
        public static int Answer(string path)
        {
            var text = File.ReadAllText(path);
            var textArr = text.Split(" ", text.Length);
            return textArr.Length;
        }
    }
}