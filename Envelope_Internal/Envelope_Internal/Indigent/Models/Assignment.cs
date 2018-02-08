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
            public string Name { get; set; }
            public string Notes { get; set; }
            public bool Done { get; set; }
        }
}
