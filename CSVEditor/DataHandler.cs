using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace CSVEditor
{
    public static class DataHandler
    {
        private static CsvParserOptions csvParserOptions = new CsvParserOptions(true, ';');
        private static CsvClientMapping csvMapper = new CsvClientMapping();
        private static CsvParser<ClientInfo> csvParser = new CsvParser<ClientInfo>(csvParserOptions, csvMapper);
        private static List<CsvMappingResult<ClientInfo>> parsedData;

        public static void ReadFile(string filename)
        {
            parsedData = csvParser.ReadFromFile(filename, Encoding.UTF8).ToList();
        }

        public static int GetRowsCount()
        {
            return parsedData.Count;
        }

        public static ClientInfo GetRow(int index)
        {
            return parsedData[index].Result;
        }
    }
}
