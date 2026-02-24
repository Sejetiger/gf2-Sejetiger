using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            Console.WriteLine("Indtast en alder: ");
            string ageinput = Console.ReadLine();
            int age = int.Parse(ageinput);
            if (age < 18)
            {
                Console.WriteLine("Du er under 18 år gammel.");
            }
            else if (age == 18)
            {
                Console.WriteLine("Du er præcis 18 år gammel.");
            }
            else
            {
                Console.WriteLine("Du er over 18 år gammel.");
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast et tal: ");
            string numberinput = Console.ReadLine();
            int number= int.Parse(numberinput);
            bool lige = number % 2 == 0;
            if (lige)
            {
                Console.WriteLine("Tallet er lige.");
            }
            else
            {
                Console.WriteLine("Tallet er ulige.");
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast et tal: ");
            string talinput = Console.ReadLine();
            int tal = int.Parse(talinput);
            bool ulige= tal%2 ==1;
            switch (ulige)
            {
                case true:
                    Console.WriteLine("Tallet er ulige.");
                    break;
                case false:
                    Console.WriteLine("Tallet er lige.");
                    break;
            }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("indtast et tal");
            string gusdc =Console.ReadLine();
            int gusd = int.Parse(gusdc);
            bool gusda = gusd % 2 == 0;
            string result = gusda ? "Tallet er lige." : "Tallet er ulige.";
            Console.WriteLine(result);
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            Console.WriteLine("Hvad er hovedstaden i Danmark?");
            string answer1 = Console.ReadLine();
            bool correct1 = answer1.Equals("København", StringComparison.OrdinalIgnoreCase);  
            string feedback1 = correct1 ? "Korrekt!" : "Forkert, det rigtige svar er København.";
            Console.WriteLine("hvad er Gustav yndlings spil?");
            string answer2 = Console.ReadLine();
            bool correct2 = answer2.Equals("skyrim", StringComparison.OrdinalIgnoreCase);
            string feedback2 = correct2 ? "Korrekt!" : "Forkert, det rigtige svar er Skyrim.";
            Console.WriteLine("Hvad er 2 + 2?");
            string question3 = "Hvad er 2 + 2?";
            int answer3 = int.Parse(Console.ReadLine());
            bool correct3 = answer3 == 4;
            string feedback3 = correct3 ? "Korrekt!" : "Forkert, det rigtige svar er 4.";
            string finalFeedback = $"Du fik {(correct1 ? 1 : 0) + (correct2 ? 1 : 0) + (correct3 ? 1 : 0)} ud af 3 rigtige.";
            Console.WriteLine(feedback1);
            Console.WriteLine(feedback2);
            Console.WriteLine(feedback3);
            Console.WriteLine(finalFeedback);
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            Console.WriteLine("Indtast en karakter (12, 10, 7, 4, 02, 00 eller -3):");
            string gradeInput = Console.ReadLine();
            int grade = int.Parse(gradeInput);
            switch (grade)
            {
                case 12:
                    Console.WriteLine("Super flot!");
                    break;
                case 10:
                    Console.WriteLine("Godt klaret!");
                    break;
                case 7:
                    Console.WriteLine("Du kan gøre det bedre.");
                    break;
                case 4:
                    Console.WriteLine("Du skal arbejde hårdere.");
                    break;
                case 2:
                    Console.WriteLine("Du har brug for meget forbedring.");
                    break;
                case 0:
                    Console.WriteLine("Du har ikke bestået.");
                    break;
                case -3:
                    Console.WriteLine("Du har dumpet.");
                    break;
                default:
                    Console.WriteLine("Ugyldig karakter. Indtast en gyldig karakter (12, 10, 7, 4, 02, 00 eller -3).");
                    break;
            }
        }
    }
}
