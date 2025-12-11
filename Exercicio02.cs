namespace AT_CSharp2025
{
    public class Exercicio02
    {
        public static void Testar()
        {
            Console.WriteLine("Informe seu nome completo");
            string name = Console.ReadLine();

            string newName = "";

            for (int i = 0; i < name.Length; i++)
            {
                char letra = name[i];

                if (letra == ' ')
                {
                    newName += " ";
                }
                else
                {
                    char novLetra = letra;

                    if (letra >= 'a' && letra <= 'z')
                    {
                        novLetra = (char)(letra + 2);
                        if (novLetra > 'z')
                        {
                            novLetra = (char)(novLetra - 26);
                        }
                    }
                    else if (letra >= 'A' && letra <= 'Z')
                    {
                        novLetra = (char)(letra + 2);
                        if (novLetra > 'Z')
                        {
                            novLetra = (char)(novLetra - 26);
                        }
                    }

                    newName += novLetra;
                }
            }

            string[] parts = newName.Split(' ');
            string lastName = "";

            for (int j = 0; j < parts.Length; j++)
            {
                if (parts[j].Length > 0)
                {
                    string first = parts[j][0].ToString().ToUpper();
                    string rest = "";

                    if (parts[j].Length > 1)
                    {
                        rest = parts[j].Substring(1).ToLower();
                    }

                    lastName += first + rest;
                }

                if (j < parts.Length - 1)
                {
                    lastName += " ";
                }
            }

            Console.WriteLine("Resultado:");
            Console.WriteLine(lastName);
        }
    }
}