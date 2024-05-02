using KeyOneTest.Models;

namespace KeyOneTest.Repositories
{
    public class ObjectRepository 
    {
        public static List<Objeto> Objects = new()
        {
            new() { Id = 1, Value = 150, Category = "A", Date = "2024-04-30" },
            new() { Id = 2, Value = 90, Category = "A", Date = "2024-04-29" },
            new() { Id = 3, Value = 40, Category = "A", Date = "2024-04-28" },
            new() { Id = 4, Value = 30, Category = "A", Date = "2024-04-27" },
            new() { Id = 5, Value = 100, Category = "B", Date = "2024-04-26" },
            new() { Id = 6, Value = 120, Category = "B", Date = "2024-04-25" },
            new() { Id = 7, Value = 70, Category = "B", Date = "2024-04-24" },
            new() { Id = 8, Value = 20, Category = "B", Date = "2024-04-23" },
            new() { Id = 9, Value = 180, Category = "C", Date = "2024-04-22" },
            new() { Id = 10, Value = 130, Category = "C", Date = "2024-04-21" },
            new() { Id = 11, Value = 60, Category = "C", Date = "2024-04-19" },
            new() { Id = 12, Value = 200, Category = "C", Date = "2024-04-20" },
            new() { Id = 13, Value = 110, Category = "A", Date = "2024-04-18" },
            new() { Id = 14, Value = 120, Category = "B", Date = "2024-04-17" },
            new() { Id = 15, Value = 150, Category = "C", Date = "2024-04-16" }
        };

        public static List<string> Operations = new()
        {
            "filtrar", "agrupar", "ordenar", "transformar"
        };
    }
}
