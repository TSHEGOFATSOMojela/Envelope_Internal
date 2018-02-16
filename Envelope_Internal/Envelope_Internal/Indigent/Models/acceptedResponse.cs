using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Envelope_Internal.Indigent.Models
{
    public class StatusResponse
    {
        public string StatusDescription { get; set; }
        public string StatusCode { get; set; }
    }

    public class acceptedResponse
    {
        public StatusResponse StatusResponse { get; set; }
    }
}
