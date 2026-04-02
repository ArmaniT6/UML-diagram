public class Toy : Product // toy ärver från product
{
    public Toy(string name, int price) : base(name, price) // skickar vidare värden
    {
    }

    public override string Use() // egen use för toy
    {
        return $"Du leker med {Name}."; // text för toy
    }
}