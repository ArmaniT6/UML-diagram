public class Drink : Product // drink ärver från product
{
    public Drink(string name, int price) : base(name, price) // skickar vidare värden
    {
    }

    public override string Use() // egen use för drink
    {
        return $"Du dricker {Name}."; // text för drink
    }
}