using Newtonsoft.Json;
using System;
using System.IO;

namespace ObjektowaGra
{

    //lista enum na trudnosc, obecnie nigdzie nie uzywana, moze do wywalenia
    enum difficulties
    {
        easy,
        medium,
        hard
    }
    
    //klasa item, używana do przetrzymywania pytań
    public class Item
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public string[] incorrect_asnwers = new string[0];
    }
    
    //klasa gracza, zarówno AI jak i nasz
    public class Player
    {
        //zmienne
        int health;
        int wrongCount;
        int rightCount;
	
        //konstruktor gracza
        public Player(int desiredHealth)
        {
            health = desiredHealth;
            wrongCount = 0;
            rightCount = 0;
        }
	
        //metoda zadania obrażeń
        public static void damageTaken(Player hero, List<Item> lista)
        {
            switch (lista.difficulty)
            {
                case "easy":
                    hero.health = hero.health - 1;
                    break;
                case "medium":
                    hero.health = hero.health - 2;
                    break;
                case "hard":
                    hero.health = hero.health - 4;
                    break;
                default:
                    Console.WriteLine("Błąd obliczania obrażeń");
                    break;
            }
        }
    }
    
    internal class Program: Item
    {
        //import pytań w formacie JSON
        public static List<Item> LoadJson()
        {
            using (StreamReader r = new StreamReader("questions.json"))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                return items;
            }
        }
        
        //MAIN METHOD
        static void Main(string[] args)
        {
            Console.WriteLine(LoadJson());
            Console.ReadKey();
        }
    }
}
