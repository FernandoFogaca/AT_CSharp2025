namespace AT_CSharp2025
{
    public class Exercicio09
    {
        public static void Testar()
        {
            // aqui eu guardo até 5 itens
            Product[] shopLedge = new Product[5];

            // quantos já coloquei no estoque
            int weeCounter = 0;

            bool carryOn = true;

            while (carryOn)
            {
                Console.WriteLine("\n--- Little Corner Shop Menu, mate ---");
                Console.WriteLine("1 - Pop a new item in");
                Console.WriteLine("2 - Have a look at what's there");
                Console.WriteLine("3 - I'm off now (Exit)");

                string fernPick = Console.ReadLine();

                if (fernPick == "1")
                {
                    // limite de 5 produtos
                    if (weeCounter == 5)
                    {
                        Console.WriteLine("Nah mate, shelf's full.");
                        continue;
                    }

                    Console.WriteLine("Name of the item:");
                    string labelMate = Console.ReadLine();

                    Console.WriteLine("How many do you fancy?");
                    string writtenAmount = Console.ReadLine();
                    int properAmount;

                    // tento converter a quantidade
                    bool amountOkay = int.TryParse(writtenAmount, out properAmount);

                    if (!amountOkay || properAmount < 0)
                    {
                        Console.WriteLine("That's not really a number, mate.");
                        continue;
                    }

                    Console.WriteLine("And the price (in quid):");
                    string scribbledQuid = Console.ReadLine();
                    decimal valueQuid;

                    // tento converter o preço
                    bool quidValid = decimal.TryParse(scribbledQuid, out valueQuid);

                    if (!quidValid || valueQuid < 0)
                    {
                        Console.WriteLine("Bit dodgy, that price.");
                        continue;
                    }

                    // aqui eu crio o item
                    Product fernItem = new Product();
                    fernItem.Name = labelMate;
                    fernItem.Amount = properAmount;
                    fernItem.QuidPrice = valueQuid;

                    shopLedge[weeCounter] = fernItem;
                    weeCounter++;

                    Console.WriteLine("Sorted! Item added.");
                }
                else if (fernPick == "2")
                {
                    // se não tiver nada ainda
                    if (weeCounter == 0)
                    {
                        Console.WriteLine("Empty… nothing here yet.");
                        continue;
                    }

                    Console.WriteLine("\n--- What's on the Ledge ---");

                    // mostro o que tem
                    for (int lad = 0; lad < weeCounter; lad++)
                    {
                        Product fernStuff = shopLedge[lad];
                        Console.WriteLine(
                            "Item: " + fernStuff.Name +
                            " | Amount: " + fernStuff.Amount +
                            " | Price: £" + fernStuff.QuidPrice
                        );
                    }
                }
                else if (fernPick == "3")
                {
                    Console.WriteLine("Right then, I'm off. Cheers mate!");
                    carryOn = false;
                }
                else
                {
                    Console.WriteLine("Not on the list, mate.");
                }
            }
        }
    }

    public class Product
    {
        // nome do produto
        public string Name;

        // quantidade
        public int Amount;

        // preço unitário
        public decimal QuidPrice;
    }
}