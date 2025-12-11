namespace AT_CSharp2025;

public class Exercicio07
{
    public static void Testar()
        {
            // aqui eu crio uma conta para testar
            BankAccount myAccountINGBank = new BankAccount("Fernando Padilha");

            // aqui eu faço um depósito
            myAccountINGBank.Deposit(500);

            // aqui eu mostro o saldo
            myAccountINGBank.ShowBalance();

            // tentativa de saque maior que o saldo
            myAccountINGBank.Withdraw(700);

            // saque que funciona
            myAccountINGBank.Withdraw(200);

            // saldo depois das operações
            myAccountINGBank.ShowBalance();
        }
    }

    public class BankAccount
    {
        // aqui vai o nome do dono da conta
        public string Owner;

        // o saldo fica privado pra ninguém mexer direto
        private decimal balance;

        // construtor da conta
        public BankAccount(string ownerName)
        {
            // aqui eu guardo o dono da conta
            Owner = ownerName;

            // saldo começa zerado
            balance = 0;
        }

        // aqui eu adiciono dinheiro na conta
        public void Deposit(decimal amount)
        {
            // não deixo colocar valor negativo
            if (amount <= 0)
            {
                Console.WriteLine("The deposit must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine("Deposit of " + amount + " successful.");
        }

        // aqui eu tiro dinheiro da conta
        public void Withdraw(decimal amount)
        {
            // se tentar tirar mais do que tem, eu não deixo
            if (amount > balance)
            {
                Console.WriteLine("Not enough balance for this withdraw.");
                return;
            }

            balance -= amount;
            Console.WriteLine("Withdraw of " + amount + " done.");
        }

        // aqui eu mostro o saldo atual
        public void ShowBalance()
        {
            Console.WriteLine("Owner: " + Owner);
            Console.WriteLine("Current balance: " + balance);
        }
    }
    
    
    
    
    
    
    