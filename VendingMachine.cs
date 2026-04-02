using System; // behövs för console
using System.Collections.Generic; // behövs för list

public class VendingMachine
{
    public List<Product> Products { get; set; } // lista med produkter
    public int MoneyPool { get; set; } // pengar i automaten

    public VendingMachine() // konstruktor
    {
        Products = new List<Product>() // skapar produktlistan
        {
            new Drink("Cola", 25), // lägger till drink
            new Drink("Fanta", 25), // lägger till drink
            new Drink("Vatten", 15), // lägger till drink
            new Snack("Chips", 20), // lägger till snack
            new Snack("Choklad", 22), // lägger till snack
            new Snack("Kex", 18), // lägger till snack
            new Toy("Toy Car", 50) // lägger till toy
        };

        MoneyPool = 0; // startvärde på pengar
    }

    public void InsertMoney(int amount) // lägger in pengar
    {
        if (amount == 5 || amount == 10 || amount == 20 || amount == 50) // kollar giltig valör
        {
            MoneyPool += amount; // lägger till pengar
            Console.WriteLine($"Du stoppade in {amount} kr. Saldo: {MoneyPool} kr"); // visar saldo
        }
        else
        {
            Console.WriteLine("Ogiltig valör."); // felmeddelande
        }
    }

    public void ShowProducts() // visar alla produkter
    {
        for (int i = 0; i < Products.Count; i++) // loopar igenom listan
        {
            Console.WriteLine($"{i + 1}. {Products[i].Examine()}"); // skriver ut produkt
        }
    }

    public void Purchase(int productNumber) // köper en produkt
    {
        if (productNumber < 1 || productNumber > Products.Count) // kollar om numret finns
        {
            Console.WriteLine("Ogiltigt produktnummer."); // felmeddelande
            return; // stoppar metoden
        }

        Product chosenProduct = Products[productNumber - 1]; // hämtar vald produkt

        if (MoneyPool >= chosenProduct.Price) // kollar om pengarna räcker
        {
            MoneyPool -= chosenProduct.Price; // drar av priset
            Console.WriteLine($"Du köpte {chosenProduct.Name}."); // visar köp
            Console.WriteLine(chosenProduct.Use()); // visar användning
            Console.WriteLine($"Kvar i saldo: {MoneyPool} kr"); // visar kvarvarande pengar
        }
        else
        {
            Console.WriteLine("För lite pengar."); // felmeddelande
        }
    }

    public int EndTransaction() // avslutar köpet
    {
        int tillbaka = MoneyPool; // sparar växeln
        MoneyPool = 0; // nollställer pengar
        return tillbaka; // skickar tillbaka växeln
    }
}