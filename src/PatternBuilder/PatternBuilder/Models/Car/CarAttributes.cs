namespace PatternBuilder
{
    /// <summary>
    ///     Атрибуты машины.
    /// </summary>
    /// <remarks>
    ///     Для примера были выбраны характеристики машины,
    ///     которые можно улучшать в игре NeedForSpeed Underground.
    ///     
    ///     Данный класс выступает в роли описания
    ///     каждого из атрибута машины.
    /// </remarks>
    public class CarAttributes
    {
        /// <summary>
        ///     Двигатель машины.
        /// </summary>
        public string Engine { get; private set; } = string.Empty;

        /// <summary>
        ///     Передний привод.
        /// </summary>
        public string FrontWheelDrive { get; private set; } = string.Empty;

        /// <summary>
        ///     Задний привод.
        /// </summary>
        public string RearWheelDrive { get; private set; } = string.Empty;

        /// <summary>
        ///     Трансмиссия.
        /// </summary>
        public string Transmission { get; private set; } = string.Empty;

        /// <summary>
        ///     Шины.
        /// </summary>
        public string Tires { get; private set; } = string.Empty;

        /// <summary>
        ///     Электронный блок управления (E.C.U.).
        /// </summary>
        public string ElectronicControlUnit { get; private set; } = string.Empty;

        /// <summary>
        ///     Топливная система.
        /// </summary>
        public string FuelSystem { get; private set; } = string.Empty;

        /// <summary>
        ///     Турбо пакет.
        /// </summary>
        public string TurboPackage { get; private set; } = string.Empty;

        /// <summary>
        ///     Тормоза.
        /// </summary>
        public string BrakeKits { get; private set; } = string.Empty;

        /// <summary>
        ///     Уменьшение веса.
        /// </summary>
        public string WeightReductionKits { get; private set; } = string.Empty;

        /// <summary>
        ///     Пакет сцепления.
        /// </summary>
        public string SuspensionPackage { get; private set; } = string.Empty;

        /// <summary>
        ///     Закись азота.
        /// </summary>
        public string NitrousOxide { get; private set; } = string.Empty;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="engine"> <see cref="Engine"/>. </param>
        /// <param name="frontWheelDrive"> <see cref="FrontWheelDrive"/>. </param>
        /// <param name="rearWheelDrive"> <see cref="RearWheelDrive"/>. </param>
        /// <param name="transmission"> <see cref="Transmission"/>. </param>
        /// <param name="tires"> <see cref="Tires"/>. </param>
        /// <param name="electronicControlUnit"> <see cref="ElectronicControlUnit"/>. </param>
        /// <param name="fuelSystem"> <see cref="FuelSystem"/>. </param>
        /// <param name="turboPackage"> <see cref="TurboPackage"/>. </param>
        /// <param name="brakeKits"> <see cref="BrakeKits"/>. </param>
        /// <param name="weightReductionKits"> <see cref="WeightReductionKits"/>. </param>
        /// <param name="suspensionPackage"> <see cref="SuspensionPackage"/>. </param>
        /// <param name="nitrousOxide"> <see cref="NitrousOxide"/>. </param>
        public CarAttributes(string engine, string frontWheelDrive,
            string rearWheelDrive, string transmission,
            string tires, string electronicControlUnit,
            string fuelSystem, string turboPackage,
            string brakeKits, string weightReductionKits,
            string suspensionPackage, string nitrousOxide)
        {
            Engine = engine;
            FrontWheelDrive = frontWheelDrive;
            RearWheelDrive = rearWheelDrive;
            Transmission = transmission;
            Tires = tires;
            ElectronicControlUnit = electronicControlUnit;
            FuelSystem = fuelSystem;
            TurboPackage = turboPackage;
            BrakeKits = brakeKits;
            WeightReductionKits = weightReductionKits;
            SuspensionPackage = suspensionPackage;
            NitrousOxide = nitrousOxide;
        }
    }
}
