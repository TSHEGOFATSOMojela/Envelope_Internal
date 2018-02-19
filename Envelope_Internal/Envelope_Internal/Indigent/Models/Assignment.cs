using System;
using System.Collections.Generic;
using System.Text;
using Envelope_Internal.Indigent.Services;
using SQLite;

namespace Envelope_Internal.Indigent.Models
{
     public class Assignment1
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string applicantDetails { get; set; }
            public string Status { get; set; }
            public string FieldWorkrId { get; set; }
        }
}
