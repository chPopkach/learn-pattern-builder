namespace PatternBuilder.Services
{
    using Ardalis.GuardClauses;

    using PatternBuilder.Dto.InformationClasses;
    using PatternBuilder.Interfaces.BuilderInformationClasses;
    using PatternBuilder.Models.Car;
    using System.Linq;

    /// <summary>
    ///     Сервис билдера класса <see cref="CarInformationExport"/>.
    /// </summary>
    public class CarInformationExportBuilder : ICarInformationExportBuilder
    {
        /// <summary>
        ///     Объект <see cref="CarInformationExport"/>,
        ///     который получится в итоге.
        /// </summary>
        private CarInformationExport _carInformationExport;

        /// <summary>
        ///     Коллекция с объектами <see cref="Car"/>.
        /// </summary>
        private readonly List<Car> _cars;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="cars"> Коллекция объектов <see cref="Car"/>. </param>
        public CarInformationExportBuilder(List<Car> cars)
        {
            _carInformationExport = new CarInformationExport();
            _cars = Guard.Against.Null(cars);
        }

        /// <inheritdoc />
        public ICarInformationExportBuilder BuildHeader()
        {
            _carInformationExport.Header =
                $"CARS REPORT ON DATE: {DateTime.Now}\n" +
                $"\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }

        /// <inheritdoc />
        public ICarInformationExportBuilder BuildBody()
        {
            _carInformationExport.Body =
                string.Join(Environment.NewLine,
                    _cars.Select(car =>
                    $"#{_cars.IndexOf(car) + 1} Car model - {car.Model}\nCar brand - {car.Brand}\n\n" +
                        $"\tAttributes car:\n" +
                        $"\tEngine - {car.Attributes.Engine}\t\tFrontWheelDrive - {car.Attributes.FrontWheelDrive}\n" +
                        $"\tRearWheelDrive - {car.Attributes.RearWheelDrive}\t\tTransmission - {car.Attributes.Transmission}\n" +
                        $"\tTires - {car.Attributes.Tires}\t\tElectronicControlUnit - {car.Attributes.ElectronicControlUnit}\n" +
                        $"\tFuelSystem - {car.Attributes.FuelSystem}\t\tTurboPackage - {car.Attributes.TurboPackage}\n" +
                        $"\tBrakeKits - {car.Attributes.BrakeKits}\t\tWeightReductionKits - {car.Attributes.WeightReductionKits}\n" +
                        $"\tSuspensionPackage - {car.Attributes.SuspensionPackage}\t\tNitrousOxide - {car.Attributes.NitrousOxide}\n")) +
                $"\n----------------------------------------------------------------------------------------------------\n";

            return this;
        }

        /// <inheritdoc />
        public ICarInformationExportBuilder BuildFooter()
        {
            _carInformationExport.Footer =
                $"TOTAL CARS: {_cars.Count()}";

            return this;
        }

        /// <inheritdoc />
        public CarInformationExport GetExport()
        {
            var carInformationExport = _carInformationExport;

            _carInformationExport = new();

            return carInformationExport;
        }
    }
}
