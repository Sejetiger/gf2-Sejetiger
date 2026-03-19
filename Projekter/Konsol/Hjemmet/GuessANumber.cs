namespace Hjemmet
{
    public class GuessANumber
    {
        //Computeren vælger et tilfældigt tal mellem 1 og 100. Du skal gætte tallet. Hver gang du gætter, får du at vide om det rigtige tal er højere eller lavere. Spillet fortsætter, indtil du gætter rigtigt.
        public void Start()
        {
            Console.WriteLine("Gæt et tal ");
            string input = Console.ReadLine();
            int guess= int.Parse(input);
            int numberToGuess = new Random().Next(1, 101);
            if (guess > numberToGuess) 
            { 
                Console.WriteLine("Det rigtige tal er lavere");
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("Det rigtige tal er højere");
            }
            else
            {
                Console.WriteLine("Du gættede rigtigt!");
            }




        }
    }
}