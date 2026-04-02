using System; // behövs för console

class Program
{
    static void Main(string[] args) // programmet startar här
    {
        VendingMachine machine = new VendingMachine(); // skapar automat
        bool running = true; // håller programmet igång

        while (running) // loopar tills användaren avslutar
        {
            Console.WriteLine("\n--- Varuautomat ---"); // rubrik
            Console.WriteLine("1. Visa produkter"); // menyval 1
            Console.WriteLine("2. Stoppa in pengar"); // menyval 2
            Console.WriteLine("3. Köp produkt"); // menyval 3
            Console.WriteLine("4. Avsluta köp"); // menyval 4
            Console.WriteLine("5. Avsluta program"); // menyval 5
            Console.Write("Välj: "); // ber om val

            string choice = Console.ReadLine(); // läser användarens val

            switch (choice) // kollar vilket val som gjordes
            {
                case "1":
                    machine.ShowProducts(); // visar produkter
                    break;

                case "2":
                    Console.Write("Ange belopp (5, 10, 20, 50): "); // ber om pengar
                    if (int.TryParse(Console.ReadLine(), out int amount)) // försöker läsa tal
                    {
                        machine.InsertMoney(amount); // lägger in pengar
                    }
                    else
                    {
                        Console.WriteLine("Du måste skriva ett tal."); // felmeddelande
                    }
                    break;

                case "3":
                    machine.ShowProducts(); // visar produkter först
                    Console.Write("Välj produktnummer: "); // ber om produktnummer
                    if (int.TryParse(Console.ReadLine(), out int productNumber)) // försöker läsa tal
                    {
                        machine.Purchase(productNumber); // köper produkt
                    }
                    else
                    {
                        Console.WriteLine("Du måste skriva ett tal."); // felmeddelande
                    }
                    break;

                case "4":
                    int tillbaka = machine.EndTransaction(); // avslutar köp
                    Console.WriteLine($"Du fick tillbaka {tillbaka} kr."); // visar växel
                    break;

                case "5":
                    running = false; // stänger programmet
                    break;

                default:
                    Console.WriteLine("Ogiltigt val."); // fel vid fel val
                    break;
            }
        }
    }
}