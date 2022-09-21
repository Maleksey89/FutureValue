using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage ="Please Enter a monthly investment.")]
        [Range(1,500,ErrorMessage ="Monthly Investment amount must be between 1 and 500")]
        public decimal MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please Enter a yearly interest rate.")]
        [Range(.1, 10.0, ErrorMessage = "Yearly Interest Rate must be between 0.1 and 10.0")]
        public decimal YearlyInterestRate { get; set; }

        [Required(ErrorMessage ="Please Enter a number of years")]
        [Range(1,50, ErrorMessage ="Number Of years must be between 1 and 50")]
        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * 
                    (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
