using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_VIOLATION
{
    public class OverdraftAccount : BankAccount
    {
        public override decimal CalculateCreditLimit()
        {
            return Balance * 1.5m; 
        }
    }
}
