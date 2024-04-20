namespace PatternBuilder.Dto.InformationClasses
{
    using System.Text;

    /// <summary>
    ///     Информация о машинах с помощью экспорта.
    /// </summary>
    /// <remarks>
    ///     В данном примере будет просто вывод в консоль,
    ///     но никто не запрещает использовать этот класс
    ///     для дальнейшего реально построенного отчета.
    /// </remarks>
    public class CarInformationExport
    {
        /// <summary>
        ///     Шапка.
        /// </summary>
        public string Header { get; set; } = string.Empty;

        /// <summary>
        ///     Тело.
        /// </summary>
        public string Body { get; set; } = string.Empty;

        /// <summary>
        ///     Подвал.
        /// </summary>
        public string Footer { get; set; } = string.Empty;

        /// <summary>
        ///     Переопределенный метод ToString().
        /// </summary>
        public override string ToString() =>
            new StringBuilder()
            .Append(Header)
            .Append(Body)
            .Append(Footer)
            .ToString();
    }
}
