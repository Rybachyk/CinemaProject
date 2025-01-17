namespace Cinema.Models.DataBaseModels
{
    public class Halls
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public string Name { get; set; } // Назва залу
        public int Capacity { get; set; } // Кількість місць
    }
}
