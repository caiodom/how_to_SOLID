namespace LiskovSubstitutionPrinciple;
public class OverdraftAccount:BankAccount
{
    public override decimal CalculateCreditLimit()
    {
        return (Balance * 2) + 500;
    }
}
