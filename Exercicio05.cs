namespace AT_CSharp2025;

public class Exercicio05
{

    public static void Testar()
    {
        Console.WriteLine(" Enter today's date (dd/mm/yyyy)");
        string input = Console.ReadLine();

        DateTime today; 

// aqui eu tento transformar o texto digitado numa data
        bool typed = DateTime.TryParse(input, out today);

        // se não virar uma data eu paro
        if (!typed)
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        // aqui eu coloco a data da minha formatura (fixa)
        DateTime graduationDate = new DateTime(2026, 12, 15);

        // se o usuário botar uma data no futuro, eu não deixo
        if (today > DateTime.Today)
        {
            Console.WriteLine("The date cannot be in the future.");
            return;
        }

        // se a data de formatura já passou
        if (today > graduationDate)
        {
            Console.WriteLine("You should be graduated already!");
            return;
        }

        // aqui eu calculo anos, meses e dias até a formatura
        int yearsLeft = graduationDate.Year - today.Year;
        int monthsLeft = graduationDate.Month - today.Month;
        int daysLeft = graduationDate.Day - today.Day;

        // ajustando os valores quando der número negativo
        if (daysLeft < 0)
        {
            monthsLeft--;
            daysLeft += DateTime.DaysInMonth(today.Year, today.Month);
        }

        if (monthsLeft < 0)
        {
            yearsLeft--;
            monthsLeft += 12;
        }

        Console.WriteLine("Time until graduation:");
        Console.WriteLine(yearsLeft + " years, " + monthsLeft + " months and " + daysLeft + " days.");

        // mensagem especial se estiver perto
        if (yearsLeft == 0 && monthsLeft < 6)
        {
            Console.WriteLine("The final stretch has arrived!");
        }
    }
}

    