namespace PatternBuilder.Models.Car
{
    using Ardalis.GuardClauses;

    /// <summary>
    ///     Модель "Машина".
    /// </summary>
    public class Car
    {
        /// <summary>
        ///     Модель.
        /// </summary>
        public string Model { get; private set; } = string.Empty;

        /// <summary>
        ///     Марка.
        /// </summary>
        public string Brand { get; private set; } = string.Empty;

        /// <inheritdoc cref="CarAttributes"/>
        public CarAttributes Attributes { get; private set; }

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="model"> <see cref="Model"/> </param>
        /// <param name="brand"> <see cref="Brand"/> </param>
        /// <param name="attributes"> <see cref="Attributes"/> </param>
        public Car(string model, string brand,
            CarAttributes attributes) 
        { 
            Model = Guard.Against.NullOrWhiteSpace(model);
            Brand = Guard.Against.NullOrWhiteSpace(brand);
            Attributes = Guard.Against.Null(attributes);
        }
    }
}
