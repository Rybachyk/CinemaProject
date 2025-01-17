namespace Cinema.Models.DataBaseModels
{
    public class Sessions
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public Guid MovieId { get; set; } // Ідентифікатор фільму
        public Guid HallId { get; set; } // Ідентифікатор залу
        public DateTime StartTime { get; set; } // Час початку сеансу
        public DateTime EndTime { get; set; } // Час завершення сеансу
        public decimal TicketPrice { get; set; } // Ціна квитка

        // Навігаційні властивості
        public Movies Movie { get; set; } // Зв'язок із фільмом
        public Halls Hall { get; set; } // Зв'язок із залом
    }
}
