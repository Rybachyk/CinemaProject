namespace Cinema.Models.DataBaseModels
{
    public class Sales_statistics
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public Guid SessionId { get; set; } // Ідентифікатор сеансу
        public int TicketsSold { get; set; } // Кількість проданих квитків
        public double Revenue { get; set; } // Дохід
    }
}
