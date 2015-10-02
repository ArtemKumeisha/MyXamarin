using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using NativeRendererListView.iOS.CustomRenderers;
using NativeRendererListView.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(NativeListView), typeof(NativeiOSListViewRenderer))]
namespace NativeRendererListView.iOS.CustomRenderers
{
    public class NativeiOSListViewRenderer:ViewRenderer<NativeListView, UITableView>
    {
        public NativeiOSListViewRenderer() { }

        protected override void OnElementChanged(ElementChangedEventArgs<NativeListView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new UITableView());
            }

            if (e.OldElement != null)
            {
                // unsubscribe
            }

            if (e.NewElement != null)
            {
                // subscribe

                var s = new NativeListViewSource(e.NewElement);
                Control.Source = s;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == NativeListView.ItemsProperty.PropertyName)
            {
                // update the Items list in the UITableViewSource
                var s = new NativeListViewSource(Element);

                Control.Source = s;
            }
        }
        public override SizeRequest GetDesiredSize(double widthConstraint, double heightConstraint)
        {
            return Control.GetSizeRequest(widthConstraint, heightConstraint, 44, 44);
        }
    }
}