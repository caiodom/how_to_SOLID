using LiskovSubstitutionPrinciple_VIOLATION;

BankAccount savingsAccount = new SavingsAccount
{
    Balance = 1000
};

decimal savingsCreditLimit = savingsAccount.CalculateCreditLimit();
Console.WriteLine($"Savings Account Credit Limit: {savingsCreditLimit}"); // Output: 2000

BankAccount overdraftAccount = new OverdraftAccount
{
    Balance = 1000
};

decimal overdraftCreditLimit = overdraftAccount.CalculateCreditLimit();
Console.WriteLine($"Overdraft Account Credit Limit: {overdraftCreditLimit}"); // Output: 1500 (Error, should be 2500)