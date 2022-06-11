using Newtonsoft.Json;
using System;
using System.IO;

namespace ObjektowaGra
{

    enum difficulties
    {
        easy,
        medium,
        hard
    }
    public class Item
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public string[] incorrect_asnwers = new string[0];
    }
    internal class Program: Item
    {
        public static List<Item> LoadJson()
        {
            using (StreamReader r = new StreamReader("questions.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                return items;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LoadJson());
            Console.ReadKey();
        }
    }
}