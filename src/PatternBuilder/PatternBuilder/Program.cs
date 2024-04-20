namespace PatternBuilder
{
    using PatternBuilder.DirectorsBuilder;
    using PatternBuilder.Models.Car;
    using PatternBuilder.Services;

    public class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car("Lancer ES (CT9A)", "Mitsubishi", new CarAttributes("Уровень 1", "True", "False", "Уровень 2", "Уровень 2", "Не определено", "Уровень 1", "Уровень 1", "Уровень 3", "Уровень 1", "Уровень 1", "Уровень 1")),
                new Car("RX-7 (FD3S) (Series 6)", "Mazda", new CarAttributes("Уровень 1", "False", "True", "Уровень 2", "Уровень 2", "Не определено", "Уровень 1", "Уровень 1", "Уровень 1", "Уровень 2", "Уровень 1", "Уровень 1")),
                new Car("Tiburon GT (GK)", "Hyundai", new CarAttributes("Уровень 2", "True", "False", "Уровень 2", "Уровень 1", "Не определено", "Уровень 1", "Уровень 1", "Уровень 2", "Уровень 1", "Уровень 3", "Уровень 1"))
            };

            var builder = new CarInformationExportBuilder(cars);

            var director = new CarInformationExportDirector(builder);

            director.Build();

            var export = builder.GetExport();

            Console.WriteLine(export);

            Console.ReadKey();
        }
    }
}
