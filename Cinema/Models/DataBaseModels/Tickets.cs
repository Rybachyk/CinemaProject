namespace Cinema.Models.DataBaseModels
{
    public class Tickets
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public Guid SessionId { get; set; } // Ідентифікатор сеансу
        public Guid UserId { get; set; } // Ідентифікатор користувача
        public int SeatNumber { get; set; } // Номер місця
        public string Status { get; set; } // Статус квитка (наприклад, "booked", "paid", "canceled")

        // Навігаційні властивості
        public Sessions Session { get; set; } // Зв'язок із сеансом
        public Users User { get; set; } // Зв'язок із користувачем
    }
}
