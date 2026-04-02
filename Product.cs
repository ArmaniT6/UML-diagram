public class Product
{
    public string Name { get; set; } // sparar namnet
    public int Price { get; set; } // sparar priset

    public Product(string name, int price) // konstruktor
    {
        Name = name; // ger namn till produkten
        Price = price; // ger pris till produkten
    }

    public virtual string Examine() // visar info om produkten
    {
        return $"{Name} kostar {Price} kr"; // returnerar produktens info
    }

    public virtual string Use() // används av produkten
    {
        return $"Du använder {Name}."; // standardtext
    }
}