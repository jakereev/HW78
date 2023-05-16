using Microsoft.AspNetCore.Mvc;

namespace HW78.Models
{
    public class ExpenseStatisticsViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal TotalAmount { get; set; }
    }

}
