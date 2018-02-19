using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Envelope_Internal.Indigent.Models
{
    public class assignment
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string status { get; set; }
        public string applicantDetails { get; set; }
        public string _id { get; set; }
        public string fieldWorkerID { get; set; }
    }
}
