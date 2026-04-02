public class Snack : Product // snack ärver från product
{
    public Snack(string name, int price) : base(name, price) // skickar vidare värden
    {
    }

    public override string Use() // egen use för snack
    {
        return $"Du äter {Name}."; // text för snack
    }
}