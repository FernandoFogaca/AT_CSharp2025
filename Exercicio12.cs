namespace AT_CSharp2025
{
    public class Exercicio12
    {
        public static void Testar()
        {
            // o arquivo onde vou guardar as coisas
            string place = "contatos.txt";

            bool running = true;

            while (running)
            {
                // menu simples
                Console.WriteLine("\n--- Contacts Bit ---");
                Console.WriteLine("1 - Add contact");
                Console.WriteLine("2 - Show contacts");
                Console.WriteLine("3 - Exit");

                string pick = Console.ReadLine();

                if (pick == "1")
                {
                    AddContact(place);
                }
                else if (pick == "2")
                {
                    ShowContacts(place);
                }
                else if (pick == "3")
                {
                    Console.WriteLine("Off I go then...");
                    running = false;
                }
                else
                {
                    Console.WriteLine("No clue what that is, mate.");
                }
            }
        }

        // adiciona um contacto no arquivo
        public static void AddContact(string spot)
        {
            Console.WriteLine("Name:");
            string n = Console.ReadLine();

            Console.WriteLine("Phone:");
            string ph = Console.ReadLine();

            Console.WriteLine("Email:");
            string em = Console.ReadLine();

            // linha que eu vou jogar no txt
            string line = n + "," + ph + "," + em;

            try
            {
                using (StreamWriter w = File.AppendText(spot))
                {
                    w.WriteLine(line);
                }
                Console.WriteLine("Sorted. Added.");
            }
            catch
            {
                Console.WriteLine("Couldn’t write to the file, mate.");
            }
        }

        // mostra os contactos no formato que o aluno escolher
        public static void ShowContacts(string spot)
        {
            if (!File.Exists(spot))
            {
                Console.WriteLine("Nothing saved yet.");
                return;
            }

            string[] all = File.ReadAllLines(spot);

            if (all.Length == 0)
            {
                Console.WriteLine("It's empty in here.");
                return;
            }

            // aqui eu transformo o txt em lista
            List<Contact> bag = new List<Contact>();

            foreach (string bit in all)
            {
                string[] cut = bit.Split(',');

                if (cut.Length == 3)
                {
                    Contact c = new Contact();
                    c.Name = cut[0];
                    c.Phone = cut[1];
                    c.Email = cut[2];

                    bag.Add(c);
                }
            }

            // o aluno escolhe como quer ver
            Console.WriteLine("\nHow to show?");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Table");
            Console.WriteLine("3 - Simple text");

            string pick = Console.ReadLine();

            ContactFormatter show;

            if (pick == "1")
            {
                show = new MarkdownFormatter();
            }
            else if (pick == "2")
            {
                show = new TabelaFormatter();
            }
            else if (pick == "3")
            {
                show = new RawTextFormatter();
            }
            else
            {
                Console.WriteLine("That’s not a thing.");
                return;
            }

            show.ExibirContatos(bag);
        }
    }

    // contacto normal
    public class Contact
    {
        public string Name;
        public string Phone;
        public string Email;
    }

    // classe base
    public abstract class ContactFormatter
    {
        public abstract void ExibirContatos(List<Contact> contatos);
    }

    // markdown simples
    public class MarkdownFormatter : ContactFormatter
    {
        public override void ExibirContatos(List<Contact> contatos)
        {
            Console.WriteLine("\n## Contacts\n");

            foreach (var c in contatos)
            {
                Console.WriteLine("- **Name:** " + c.Name);
                Console.WriteLine("- Phone: " + c.Phone);
                Console.WriteLine("- Email: " + c.Email);
                Console.WriteLine();
            }
        }
    }

    // tabela simples
    public class TabelaFormatter : ContactFormatter
    {
        public override void ExibirContatos(List<Contact> contatos)
        {
            Console.WriteLine("=== Contact Table ===");
            Console.WriteLine("Name | Phone | Email");
            Console.WriteLine("----------------------");

            foreach (var c in contatos)
            {
                Console.WriteLine(c.Name + " | " + c.Phone + " | " + c.Email);
            }
        }
    }

    // texto puro
    public class RawTextFormatter : ContactFormatter
    {
        public override void ExibirContatos(List<Contact> contatos)
   
        {
            foreach (var c in contatos)
            {
                Console.WriteLine("Name: " + c.Name + " | Phone: " + c.Phone + " | Email: " + c.Email);
            }
        }
    }
}
