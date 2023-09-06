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
            int sum1 = 0;
            float average = 0.0f;
            for (int i = 2; i <= 10; i++)
            {
                sum1 += i;
            }
            average = (float)sum1 / 9;
            Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sum1} e la media è {average}");

            Console.WriteLine();

            //SNACK 5:  Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            Console.WriteLine("SNACK 5:");
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
            Console.WriteLine("SNACK 6:");
            string[] blackList = {"Luca", "Leonardo", "Cinzia", "Bryan", "Davide"};
            Console.Write("Inserisci il tuo nome: ");
            string name = Console.ReadLine();
            bool join = false;
            
            for (int i = 0; i < blackList.Length; i++)
            {
                if (blackList[i] == name )
                {
                    join = true;
                }
            }
            if (join == true)
            {
                Console.WriteLine($"Prego Sig.{name}, lei può entrare.");
            }
            else
            {
                Console.WriteLine($"Spiacente Sig.{name}, il suo nome non è in lista...vada all'anagrafe e cambi nome");
            }

            Console.WriteLine();

            //SNACK 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            Console.WriteLine("SNACK 7:");
            int[] oddNumbers = new int[6];
            int index = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Inserisci il {i + 1}° numero: ");
                int number1 = int.Parse(Console.ReadLine());

                if (number1 % 2 != 0)
                {
                    oddNumbers[index] = number1;
                    index++;
                }
            }
            Console.Write("Numeri inseriti: ");
            for(int x = 0; x < index; x++)
            {
                Console.Write($"{oddNumbers[x]}, ");
            }

            Console.WriteLine();

            //SNACK 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            Console.WriteLine("SNACK 8:");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21};
            int sum2 = 0;
             for(int i = 0; i < numbers2.Length; i++)
            {
                if(i % 2 != 0)
                {
                    sum2 += numbers2[i];
                }
            }
             Console.WriteLine($"La somma degli elementi in posizione dispari è: {sum2}.");

            Console.WriteLine();

            //SNACK 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            Console.WriteLine("SNACK 9:");
            int[] numbers3 = new int[0];
            int sum3 = 0;

            while( sum3 < 50 )
            {
                Console.Write("Inserisci un numero: ");
                int number = int.Parse(Console.ReadLine());
                int[] newArray = new int[numbers3.Length + 1];

                for(int i = 0; i < numbers3.Length; i++)
                {
                    newArray[i] = numbers3[i];
                }
                newArray[numbers3.Length] = number;
                numbers3 = newArray;
                sum3 += number;
            }
            Console.Write("Array definitivo: ");
            foreach(int number in numbers3)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            //SNACK 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
            Console.WriteLine("SNACK 10:");
            Console.Write("Inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());

            //Da completare
        }
    }
}