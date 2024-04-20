namespace PatternBuilder.DirectorsBuilder
{
    using PatternBuilder.Dto.InformationClasses;
    using PatternBuilder.Interfaces.BuilderInformationClasses;

    /// <summary>
    ///     Класс, который управляет билдингом объекта <see cref="CarInformationExport"/>.
    /// </summary>
    public class CarInformationExportDirector
    {
        /// <inheritdoc cref="ICarInformationExportBuilder"/>
        private readonly ICarInformationExportBuilder _builder;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="builder"> <see cref="ICarInformationExportBuilder"/> </param>
        public CarInformationExportDirector(ICarInformationExportBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        ///     Построить объект <see cref="CarInformationExport"/>.
        /// </summary>
        public void Build()
        {
            _builder.BuildHeader()
                    .BuildBody()
                    .BuildFooter();
        }
    }
}
