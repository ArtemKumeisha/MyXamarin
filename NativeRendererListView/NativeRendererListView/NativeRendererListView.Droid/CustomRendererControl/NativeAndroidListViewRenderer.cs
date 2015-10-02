using System.ComponentModel;
using System.Linq;
using Android.Widget;
using NativeRendererListView.Droid.CustomRendererControl;
using NativeRendererListView.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly:ExportRenderer(typeof(NativeListView), typeof(NativeAndroidListViewRenderer))]
namespace NativeRendererListView.Droid.CustomRendererControl
{
    public class NativeAndroidListViewRenderer : ViewRenderer<NativeListView, global::Android.Widget.ListView>
    {
        public NativeAndroidListViewRenderer ()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<NativeListView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                SetNativeControl(new global::Android.Widget.ListView(Forms.Context));
            }
            if (e.OldElement != null)
            {
                // unsubscribe
                Control.ItemClick -= clicked;
            }

            if (e.NewElement != null)
            {
                //subscribe
                Control.Adapter = new NativeAndroidListViewAdapter(Forms.Context as Android.App.Activity, e.NewElement);
                Control.ItemClick += clicked;
            }
        }

        private void clicked(object sender, AdapterView.ItemClickEventArgs e)
        {
           Element.NotifyItemSelected(Element.Items.ToList()[e.Position]);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == NativeListView.ItemsProperty.PropertyName)
            {
                // update the Items list in the UITableViewSource
                Control.Adapter = new NativeAndroidListViewAdapter(Forms.Context as Android.App.Activity, Element);
            }
        }
    }
}