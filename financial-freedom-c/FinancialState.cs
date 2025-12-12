using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financial_freedom_c
{
    public static class FinancialState
    {
        public static decimal MonthlyIncome { get; set; }
        public static decimal ExtraIncome { get; set; }
        public static decimal MonthlyExpenses { get; set; }

        
        public static decimal InvestmentPercentage { get; set; }

        
        public static decimal TotalIncome
        {
            get { return MonthlyIncome + ExtraIncome; }
        }

        public static decimal SavingsCapacity
        {
            get { return TotalIncome - MonthlyExpenses; }
        }


        public static decimal InvestmentAmount { get; set; }

       
     
    }
}
