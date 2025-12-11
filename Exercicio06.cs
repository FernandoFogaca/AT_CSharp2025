namespace AT_CSharp2025;

public class Exercicio06
{
    public static void Testar()
    {
        // aqui eu crio um aluno com meus próprios dados
        Student pupil = new Student();
        pupil.Name = "Fernando Padilha Fogaça";
        pupil.Register = "2025A123"; 
        pupil.Course = " Systems Analysis and Development ";
        pupil.Average = 8.2;

        // aqui eu mostro tudo na tela
        pupil.ShowData();

        // aqui eu mostro se ele passou ou não
        string result = pupil.CheckApproval();
        Console.WriteLine("Status: " + result);
    }
}

public class Student
{
    // aqui eu guardo os dados do aluno
    public string Name;
    public string Register;
    public string Course;
    public double Average;

    // aqui eu mostro os dados do aluno
    public void ShowData()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Register: " + Register);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("Average: " + Average);
    }

    // aqui eu verifico se ele passou
    public string CheckApproval()
    {
        // se a média for 7 ou maior ele passou
        if (Average >= 7)
        {
            return "Approved";
        }
        else
        {
            return "Failed";
        }
    }
}