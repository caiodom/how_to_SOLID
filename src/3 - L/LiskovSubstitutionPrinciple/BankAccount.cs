namespace LiskovSubstitutionPrinciple;
public abstract class BankAccount
{
    public decimal Balance { get; set; }
    public abstract decimal CalculateCreditLimit();
}
