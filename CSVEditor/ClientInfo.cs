using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEditor
{
    public class ClientInfo
    {
        [Name("id")]
        public int Id { get; set; }
        [Name("client")]
        public string Client { get; set; }
        [Name("insert_date")]
        public DateTime InsertDate { get; set; }

        public ClientInfo(int id, string client, DateTime insertDate)
        {
            Id = id;
            Client = client;
            InsertDate = insertDate;
        }

        public ClientInfo()
        {
            Id = 0;
            Client = "";
            InsertDate = DateTime.Now;
        }
    }
}
