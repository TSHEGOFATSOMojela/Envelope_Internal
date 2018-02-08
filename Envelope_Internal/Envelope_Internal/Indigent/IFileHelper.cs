using System;
using System.Collections.Generic;
using System.Text;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Services;

namespace Envelope_Internal.Indigent.Models
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
