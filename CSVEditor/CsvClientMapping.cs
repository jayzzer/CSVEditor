using System.Globalization;
using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

namespace CSVEditor
{
    internal class CsvClientMapping : CsvMapping<ClientInfo>
    {
        public CsvClientMapping() : base()
        {
            MapProperty(0, x => x.Id, new Int32Converter());
            MapProperty(1, x => x.Client, new StringConverter());
            MapProperty(2, x => x.InsertDate, new DateTimeConverter("dd.MM.yyyy HH:mm:ss"));
        }
    }
}
