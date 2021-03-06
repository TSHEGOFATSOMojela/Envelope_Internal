﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace Envelope_Internal
{
    public class CustomWebView : WebView
    {
        public static readonly BindableProperty UriProperty =
            BindableProperty.Create<CustomWebView, string>(p => p.Uri, default(string));

        public string Uri
        {
            get { return (string)GetValue(UriProperty); }
            set { SetValue(UriProperty, value); }
        }
    }
}
