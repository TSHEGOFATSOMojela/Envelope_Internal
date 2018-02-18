using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Envelope_Internal.Indigent.Models;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Envelope_Internal.Indigent;
using Xamarin.Forms;
using Envelope_Internal.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace Envelope_Internal.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}