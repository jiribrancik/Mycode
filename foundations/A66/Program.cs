using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A66
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jirib\OneDrive\Plocha\FileExample.txt";
            Dictionary<string, int> res = GetA66ChipUsage(filePath);
        }
        static Dictionary<string, int> GetA66ChipUsage(string filePath)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] content;
            try
            {
                content = File.ReadAllLines(filePath);
            }
            catch (Exception)
            {

                throw new Exception("A problem occurred with reading the file.");
            }

            for (int i = 0; i < content.Length; i++)
            {
                string line = content[i];
                string[] parts = line.Split(',');
                if (line.Contains("A66 - 04 FÕBEJÁRAT (F-1) Door #1"))
                {
                    if (result.ContainsKey(parts[12]))
                    {
                        result[parts[12]]++;
                    }
                    else
                    {
                        result.Add(parts[12], 1);
                    }
                }

            }
            foreach (KeyValuePair<string, int> kvp in result)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }

            return result;
        }
    }
}