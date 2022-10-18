using Microsoft.EntityFrameworkCore;

namespace RecordingOfViolations.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Violation[] violations =
            {
                 new Violation {
                        ViolationId = 1,
                        Address = "вулиця Інститутська, 22",
                        Policeman = "Кукурудза Валерій",
                        Offender = "Cпівак Олег",
                        Reason = "Порушення правил користування ременями безпеки або мотошоломами",
                        Price = 1750,
                        Date = DateTime.Now.AddDays(-8),
                 },
                 new Violation {
                        ViolationId = 2,
                        Address = "Львівське шосе, 38/1",
                        Policeman = "Щур Сергій",
                        Offender = "Ткачук Петро",
                        Reason = "Нетверезий стан",
                        Price = 510,
                        Date = DateTime.Now.AddDays(-23),
                 },
                 new Violation {
                        ViolationId = 3,
                        Address = "вулиця Соборна, 11",
                        Policeman = "Щур Сергій",
                        Offender = "Олійник Яна",
                        Reason = "Порушення правил перевезення дітей",
                        Price = 750,
                        Date = DateTime.Now.AddDays(-2),
                 },
                 new Violation {
                        ViolationId = 4,
                        Address = "вулиця Трудова, 6А",
                        Policeman = "Кукурудза Валерій",
                        Offender = "Пристувчук Олександр",
                        Reason = "Порушення правил зупинки маршрутних таксі",
                        Price = 15000,
                        Date = DateTime.Now.AddDays(-14),
                 }
            };

            modelBuilder.Entity<Violation>().HasData(violations);
        }
    }
}
