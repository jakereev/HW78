namespace HW78.Models
{
    public class Expense
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public ExpenseCategory Category { get; set; }

        public decimal Cost { get; set; }

        public string Comment { get; set; }
        public DateTime Date { get; set; }

    }

}
