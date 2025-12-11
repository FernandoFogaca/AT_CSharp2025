namespace AT_CSharp2025
{
    public class Exercicio10
    {
        public static void Testar()
        {
            // aqui eu gero o número secreto
            Random britPicker = new Random();
            int secretLad = britPicker.Next(1, 51); // número entre 1 e 50

            // total de tentativas
            int guessing = 5;

            Console.WriteLine("Alright mate, guess the number (1 to 50). You’ve got 5 tries.");

            while (guessing > 0)
            {
                Console.WriteLine("\nHave a go, mate:");
                string scribble = Console.ReadLine();

                int guessAttempt;

                // aqui eu tento transformar o texto em número
                bool properNumber = int.TryParse(scribble, out guessAttempt);

                // se não virar número
                if (!properNumber)
                {
                    Console.WriteLine("That's not even a number, mate.");
                    continue;
                }

                // se o número estiver fora do intervalo
                if (guessAttempt < 1 || guessAttempt > 50)
                {
                    Console.WriteLine("Number's out of range, mate. Stick to 1 to 50.");
                    continue;
                }

                // se acertar
                if (guessAttempt == secretLad)
                {
                    Console.WriteLine("Bang on! You got it, well done!");
                    return;
                }

                // se errar
                Console.WriteLine("Nope, not that one.");

                guessing--; // tiro uma tentativa

                // digo quantas chances restam
                if (guessing > 0)
                {
                    Console.WriteLine("You've got " + guessing + " tries left.");
                }
            }

            // se acabar as tentativas
            Console.WriteLine("\nOut of tries, mate. The number was: " + secretLad);
        }
    }
}