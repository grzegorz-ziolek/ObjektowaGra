using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

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
   //TODO: wymagane dalej by incorrect_answers było array - poprawić deserializację JSON
    public class Item
    {
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public IList<string> incorrect_answers { get; set; }
    }
    
    //klasa gracza, zarówno AI jak i nasz
    public class Player
    {
        //zmienne
        int health;
        int wrongCount;
        int rightCount;
	
        //konstruktor gracza; wymagane: (oczekiwane życie bohatera)
        public Player(int desiredHealth)
        {
            health = desiredHealth;
            wrongCount = 0;
            rightCount = 0;
        }
	
        //metoda zadania obrażeń; wymagane: (jaki heros dostaje obrażenia, pytanie w formie array z danymi)
        public static void damageTaken(Player hero, Item lista)
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
                    throw new ArgumentException("Błąd obliczania obrażeń w metodzie damageTaken");
                    break;
            }
        }
    }
	
	//ogólne metody dotyczące obecnie aktywnego zbioru pytań
	//TODO? dodać możliwość supportu wielu plików z pytaniami?
	public class Quiz : IEnumerable
    {

		Stack<int> chosenBefore = new Stack<int>();

		//metoda wybierania pytania oraz przeciwdziałanie powtórzeniom; 
		//wymagane (pełna ilość pytań w JSON, stack wykorzystanych do tej pory pytań z puli)
		//zwracane - index w zakresie 0 - pełna ilość pytań oznaczający index wybranego pytania
		public static int chooseQuestion(int totalCount, Stack<int> chosenBefore)
		{
			int index;
			var random = new Random();
			do
			{
			index = random.Next(0, totalCount);
			}while(chosenBefore.Contains(index));
			chosenBefore.Push(index);
			return index;
		}

		//metoda wyboru miejsca odpowiedzi; zwraca położenie poprawnej odpowiedzi w skali innych (np. prz 4 odp to wartość od 0 do 3)
		public static int chooseCorrectAnswerPlacement(List<Item> items, int index, Stack<int> chosenBefore)
		{
			int totalCount = items.Count;
			int nr = index;
			Console.WriteLine(items[nr].question + "\n");
			var random = new Random();
			string correctAnswer = items[nr].correct_answer;
			int correctAnswerPlacement;
            string[] incorrectAnswersAll = new string[items[nr].incorrect_answers.Count()];   //zliczenie ile błędnych, utworzenie array stringów tych odpowiedzi
			switch (items[nr].incorrect_answers.Count())
				{
					case 2:
					correctAnswerPlacement = random.Next(0, 2);
					break;
					
					case 3:
					correctAnswerPlacement = random.Next(0, 3);
					break;
					
					case 4:
					correctAnswerPlacement = random.Next(0, 4);
					break;
					
					default:
					throw new ArgumentException("Błędna ilość odpowiedzi przekazana do metody chooseCorrectAnswerPlacement");
					break;
					
				}
			return correctAnswerPlacement;
		}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    
    class Program: Item
    {
        //import pytań w formacie JSON
        public static List<Item> LoadJson()
        {
            using (StreamReader r = new StreamReader("questions.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
        
        //MAIN METHOD
        static void Main(string[] args)
        {
            List <Item> items = LoadJson();
            Console.WriteLine(items[1].category);
            Console.WriteLine(items[1].type);
            Console.WriteLine(items[1].difficulty);
            Console.WriteLine(items[1].question);
            Console.WriteLine(items[1].correct_answer);
            Console.WriteLine(items[1].incorrect_answers[0]);
            Console.ReadKey();
        }
    }
}
