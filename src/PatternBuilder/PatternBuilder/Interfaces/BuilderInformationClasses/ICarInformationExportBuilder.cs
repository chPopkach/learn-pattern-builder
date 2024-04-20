namespace PatternBuilder.Interfaces.BuilderInformationClasses
{
    using PatternBuilder.Dto.InformationClasses;

    /// <summary>
    ///     Интерфейс билдера класса <see cref="CarInformationExport"/>.
    /// </summary>
    public interface ICarInformationExportBuilder
    {
        /// <summary>
        ///     Построить шапку экспорта.
        /// </summary>
        /// <returns> Билдер. </returns>
        ICarInformationExportBuilder BuildHeader();

        /// <summary>
        ///     Построить тело экспорта.
        /// </summary>
        /// <returns> Билдер. </returns>
        ICarInformationExportBuilder BuildBody();

        /// <summary>
        ///     Построить подвал экспорта.
        /// </summary>
        /// <returns> Билдер. </returns>
        ICarInformationExportBuilder BuildFooter();

        /// <summary>
        ///     Получить экспорт.
        /// </summary>
        /// <returns> Объект <see cref="CarInformationExport"/>. </returns>
        CarInformationExport GetExport();
    }
}
