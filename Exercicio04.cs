namespace AT_CSharp2025;

public class Exercicio04
{
    public static void Testar()
    {
        Console.WriteLine("Enter your birth date (dd/MM/yyyy):");
        string dateText = Console.ReadLine();

        DateTime birthDate;

        // aqui eu tento transformar o que o usuário digitou numa data
        bool typed = DateTime.TryParse(dateText, out birthDate);

        // se não virar data, eu paro aqui
        if (!typed)
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        // pego a data de hoje
        DateTime today = DateTime.Today;

        // aqui eu monto o aniversário deste ano
        DateTime nextBirthday = new DateTime(
            today.Year,
            birthDate.Month,
            birthDate.Day
        );

        // se o aniversário deste ano já passou, uso o próximo ano
        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        // aqui eu calculo quantos dias faltam
        TimeSpan difference = nextBirthday - today;
        int daysLeft = difference.Days;

        // se estiver muito perto, deixo uma mensagem a mais
        if (daysLeft < 7)
        {
            Console.WriteLine("Your birthday is very soon!\n Gefeliciteer\n Félicitations\n Congrats!");
        }

        Console.WriteLine("Days left: " + daysLeft);
    }
}
