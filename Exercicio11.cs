namespace AT_CSharp2025
{
    public class Exercicio11
    {
        public static void Testar()
        {
           
            string fileSpot = "contatos.txt";

            bool carryOn = true;

            while (carryOn)
            {
                // menu  aluno
                Console.WriteLine("\n=== Contact Bits ===");
                Console.WriteLine("1 - Add a new contact");
                Console.WriteLine("2 - List contacts");
                Console.WriteLine("3 - Exit");

                string tap = Console.ReadLine();

                if (tap == "1")
                {
                    AddOne(fileSpot);
                }
                else if (tap == "2")
                {
                    ShowAll(fileSpot);
                }
                else if (tap == "3")
                {
                    Console.WriteLine("Right, I'm off then...");
                    carryOn = false;
                }
                else
                {
                    Console.WriteLine("Don't know what that is.");
                }
            }
        }

        // aqui eu peço os dados e escrevo no arquivo
        public static void AddOne(string fileSpot)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Email:");
            string mail = Console.ReadLine();

            // aqui eu monto a linha para guardar no arquivo
            string row = name + "," + phone + "," + mail;

            try
            {
                // aqui eu coloco no arquivo sem apagar o que já tem
                using (StreamWriter pen = File.AppendText(fileSpot))
                {
                    pen.WriteLine(row);
                }

                Console.WriteLine(" Contact added ");
            }
            catch
            {
                // se der erro eu aviso
                Console.WriteLine(" Could not save it, mate.");
            }
        }

        // aqui eu abro o arquivo e listo tudo
        public static void ShowAll(string fileSpot)
        {
            // se o arquivo ainda não existe
            if (!File.Exists(fileSpot))
            {
                Console.WriteLine("No contacts saved yet.");
                return;
            }

            // aqui eu leio todas as linhas
            string[] lot = File.ReadAllLines(fileSpot);

            // se tiver vazio
            if (lot.Length == 0)
            {
                Console.WriteLine(" Nothing here yet ");
                return;
            }

            Console.WriteLine("\n Saved Contacts ");

            // aqui eu passo linha por linha e divido
            foreach (string row in lot)
            {
                // eu corto pelo separador
                string[] cut = row.Split(',');

                // verifico se veio certinho
                if (cut.Length == 3)
                {
                    string name = cut[0];
                    string phone = cut[1];
                    string mail = cut[2];

                    // aqui eu mostro no formato simples
                    Console.WriteLine("Name: " + name + " | Phone: " + phone + " | Email: " + mail);
                }
            }
        }
    }
}
