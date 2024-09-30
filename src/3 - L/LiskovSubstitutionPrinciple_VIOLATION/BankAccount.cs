using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple_VIOLATION
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public virtual decimal CalculateCreditLimit()
        {
            return Balance * 2;
        }
    }
}
