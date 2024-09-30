namespace LiskovSubstitutionPrinciple;
public class SavingsAccount : BankAccount
{
    public override decimal CalculateCreditLimit()
    {
        return Balance * 2;
    }
}
