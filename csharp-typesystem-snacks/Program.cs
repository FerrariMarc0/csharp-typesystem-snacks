using System.Globalization;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SNACK 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
            Console.WriteLine("SNACK 1:");
            Console.WriteLine("Inserire due numeri: ");
            Console.Write("Primo numero: ");
            int userNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Secondo numero: ");
            int userNumber2 = int.Parse(Console.ReadLine());

            if(userNumber1 == userNumber2)
            {
                Console.WriteLine($"I numeri inseriti hanno lo stesso valore.");
            }
            else if(userNumber1 > userNumber2)
            {
                Console.WriteLine($"Il numero maggiore è {userNumber1}.");
            }
            else
            {
                Console.WriteLine($"Il numero maggiore tra i due è {userNumber2}.");
            }

            Console.WriteLine();

            //SNACK 2:  L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
            Console.WriteLine("SNACK 2:");
            Console.WriteLine("Inserire due parole");
            string userWord1 = Console.ReadLine();
            string userWord2 = Console.ReadLine();

            if(userWord1.Length == userWord2.Length)
            {
                Console.WriteLine("Le parole inserite hanno la stessa lunghezza.");
            }else if(userWord1.Length > userWord2.Length)
            {
                Console.WriteLine($"Parola piu corta: {userWord2}.");
                Console.WriteLine($"Parola piu lunga: {userWord1}.");
            }
            else
            {
                Console.WriteLine($"Parola piu corta: {userWord1}.");
                Console.WriteLine($"Parola piu lunga: {userWord2}.");
            }

            Console.WriteLine();

            //SNACK 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
            Console.WriteLine("SNACK 3:");
            int[] userNumbers = new int[10];
            int sum = 0;
            Console.WriteLine("Inserisci 10 numeri");

            for (int i = 0; i < userNumbers.Length; i++)
            {

                Console.Write($"Inserisci il {i + 1}° numero: ");
                userNumbers[i] = int.Parse(Console.ReadLine());
                
            }
            
            foreach(int number in userNumbers)
            {
                sum += number;
            }
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}.");

            Console.WriteLine();

            //SNACK 4: Calcola la somma e la media dei numeri da 2 a 10.
            Console.WriteLine("SNACK 4:");
            int sum = 0;
            float average = 0.0f;
            for (int i = 2; i <= 10; i++)
            {
                sum += i;
            }
            average = (float)sum / 9;
            Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sum} e la media è {average}");

            Console.WriteLine();

            //SNACK 5:  Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine("SNACK 3:");
            Console.Write("Inserire un numero: ");
            int userNum = int.Parse(Console.ReadLine());

            if(userNum % 2 == 0)
            {
                Console.WriteLine(userNum);
            }
            else
            {
                Console.WriteLine(userNum + 1);
            }

            Console.WriteLine();

            //SNACK 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.


            Console.WriteLine();

            //SNACK 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.


            Console.WriteLine();

            //SNACK 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.


            Console.WriteLine();

            //SNACK 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.


            Console.WriteLine();

            //SNACK 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.


        }
    }
}