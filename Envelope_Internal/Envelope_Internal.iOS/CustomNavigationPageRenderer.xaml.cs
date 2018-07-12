using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationPageRenderer))]
namespace Envelope_Internal.iOS
{
  
    
  
        public class CustomNavigationPageRenderer : NavigationRenderer
        {
            protected override void OnElementChanged(VisualElementChangedEventArgs e)
            {
                base.OnElementChanged(e);

                if (e.NewElement != null)
                {
                    var att = new UITextAttributes();
                    // TODO: Create your FontSize and FontWeight here
                    var fontSize = Font.SystemFontOfSize(30.0);
                    var boldFontSize = Font.SystemFontOfSize(35.0, FontAttributes.Bold);
                    // TODO: Apply your selected FontSize and FontWeight combination here
                    att.Font = boldFontSize.ToUIFont();
                    UINavigationBar.Appearance.SetTitleTextAttributes(att);
                }
            }
        }
  
}