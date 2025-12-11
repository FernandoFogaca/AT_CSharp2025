namespace AT_CSharp2025;

public class Exercicio03
{
    public static void Testar()
    {
        Console.WriteLine("Enter the first number");
        string response1 = Console.ReadLine();

        Console.WriteLine(" Enter the second number ");
        string response2 = Console.ReadLine();

        double number01;
        double number02;
        
        // aqui eu tento converter o que o usuário digitou para número
        bool cijfer1 = double.TryParse(response1, out number01);
        bool cijfer2 = double.TryParse(response2, out number02);

        // se algum deles não virar número para aqui.
        if (!cijfer1 || !cijfer2)
        {
            Console.WriteLine("Invalid number.");
            return;
        }
        Console.WriteLine("Choose the operation:");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");

        string option = Console.ReadLine();

        double result = 0;
        bool valid = true;

        
        // aqui eu vejo qual operação foi escolhida
        if (option == "1")
        {
            result = number02 + number01;
        }
        else if (option == "2")
        {
            result = number02 - number01;
        }
        else if (option == "3")
        {
            result = number02 * number01;
        }
        else if (option == "4")
        {
            // não deixo dividir por zero
            if (number01 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }

            result = number02 / number01;
        }
        else
        {
            // se cair aqui é porque digitou algo que não existe
            valid = false;
        }

        // se estiver tudo certo, eu mostro o resultado final
        if (valid)
        {
            Console.WriteLine("Result: " + result);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}


    
