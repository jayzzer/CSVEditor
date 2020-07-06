using CsvHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVEditor
{
    public static class DataHandler
    {
        public static readonly int RowsPerPage = 10;
        public static int MaxPage { get => maxPage; set => maxPage = value < 1 ? 1 : value; }

        private static int currentPage = 1;
        private static int maxPage = 1;
        private static string filename;
        private static List<ClientInfo> parsedData = new List<ClientInfo>();

        public static void ReadFile(string filePath)
        {
            filename = filePath;
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                parsedData = csv.GetRecords<ClientInfo>().ToList();
            }

            SetCurrentPage(1);
            UpdateMaxPage();
        }

        public static int GetRowsCount()
        {
            return parsedData.Count;
        }

        public static List<ClientInfo> GetParsedData(int page)
        {
            int index = (page - 1) * RowsPerPage;
            int count = RowsPerPage > parsedData.Count - index ? parsedData.Count - index : RowsPerPage;

            return parsedData.GetRange(index, count);
        }


        public static void AddRow(ClientInfo newInfo)
        {
            parsedData.Add(newInfo);

            UpdateMaxPage();
            WriteChanges();
        }

        public static void DeleteRows(DataGridViewRow row)
        {
            parsedData.RemoveAt(row.Index + (currentPage - 1) * RowsPerPage);
            
            UpdateMaxPage();
            WriteChanges();
        }

        private static void UpdateMaxPage()
        {
            MaxPage = Convert.ToInt32(Math.Ceiling(parsedData.Count / (double)RowsPerPage));
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.UpdatePageNumView();
        }

        public static void UpdateRow(int index, ClientInfo newInfo)
        {
            int elIndex = index + (currentPage - 1) * RowsPerPage;
            parsedData[elIndex] = newInfo;

            WriteChanges();
        }

        public static int GetCurrentPage()
        {
            return currentPage;
        }

        public static void SetCurrentPage(int value)
        {
            currentPage = value < 1 ? 1 : value > MaxPage ? MaxPage : value;

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.UpdatePageNumView();
            mainForm.UpdateTable();
        }

        private static void WriteChanges()
        {
            using (var writer = new StreamWriter(filename))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.WriteRecords(parsedData);
            }
        }
    }
}
