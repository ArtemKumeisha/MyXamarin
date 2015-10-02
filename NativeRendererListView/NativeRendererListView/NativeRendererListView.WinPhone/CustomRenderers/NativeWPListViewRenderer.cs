using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using NativeRendererListView.DataSources;
using NativeRendererListView.Renderers;
using NativeRendererListView.WinPhone.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly:ExportRenderer(typeof(NativeListView), typeof(NativeWPListViewRenderer))]
namespace NativeRendererListView.WinPhone.CustomRenderers
{
    public class NativeWPListViewRenderer:ViewRenderer<NativeListView, System.Windows.Controls.ListBox>
    {
        public NativeWPListViewRenderer() { }

        protected override void OnElementChanged(ElementChangedEventArgs<NativeListView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new ListBox());
            }
            if (e.OldElement != null)
            {
                // unsubscribe
            }
            if (e.NewElement != null)
            {
                //subscribe
                var s = new NativeWPListViewSource(e.NewElement);
                Control.DataContext = s;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == NativeListView.ItemsProperty.PropertyName)
            {
                var s = new NativeWPListViewSource(Element);
                //Control.
            }
        }
    }
}
