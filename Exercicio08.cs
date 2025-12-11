namespace AT_CSharp2025;

public class Exercicio08
{
    public static void Testar()
    {
        // aqui eu crio um funcionário normal
        Employee worker = new Employee();
        worker.Name = "Fernando Padilha";
        worker.Job = "Support Analyst";
        worker.BaseSalary = 3800;

        // aqui eu crio um gerente
        Manager boss = new Manager();
        boss.Name = " Maria Oliveira ";
        boss.Job = " Team Manager ";
        boss.BaseSalary = 4000;

        // aqui eu mostro os salários
        worker.ShowSalary();
        boss.ShowSalary();
    }
}

public class Employee
{
    // aqui eu guardo os dados do funcionário
    public string Name;
    public string Job;
    public double BaseSalary;

    // aqui eu mostro o salário sem bônus
    public virtual void ShowSalary()
    {
        Console.WriteLine(" Name: " + Name);
        Console.WriteLine(" Job: " + Job);
        Console.WriteLine(" Salary: " + BaseSalary);
        Console.WriteLine();
    }
}

public class Manager : Employee
{
    // o gerente ganha 20% a mais
    public override void ShowSalary()
    {
        double total = BaseSalary + (BaseSalary * 0.20);

        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Job: " + Job);
        Console.WriteLine("Salary with bonus: " + total);
        Console.WriteLine();
    }
}