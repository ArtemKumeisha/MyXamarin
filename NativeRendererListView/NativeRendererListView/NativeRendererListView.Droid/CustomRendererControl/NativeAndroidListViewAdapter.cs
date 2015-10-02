using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NativeRendererListView.DataSources;
using NativeRendererListView.Renderers;
using Xamarin.Forms.Platform.Android;

namespace NativeRendererListView.Droid.CustomRendererControl
{
    /// <summary>
    /// This adapter uses a view defined in /Resources/Layout/NativeAndroidListViewCell.axml
    /// as the cell layout
    /// </summary>
    public class NativeAndroidListViewAdapter:BaseAdapter<DataSource>
    {
        private readonly Activity context;
        IList<DataSource> tableItems = new List<DataSource>();

        public IEnumerable<DataSource> Items
        {
            set { tableItems = value.ToList(); }
        }

        public NativeAndroidListViewAdapter(Activity context, NativeListView view)
        {
            this.context = context;
            tableItems = view.Items.ToList();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Android.Views.View GetView(int position, Android.Views.View convertView, ViewGroup parent)
        {
            var item = tableItems[position];
            var view = convertView;
            if (view == null) // no view to re-use, create new
            {
                //view = context.LayoutInflater.Inflate()
                view = context.LayoutInflater.Inflate(Resource.Layout.NativeAndroidCell, null);
            }
            else
            {
                // re-use, clear image
                // doesn't seem to help
                //view.FindViewById<ImageView> (Resource.Id.Image).Drawable.Dispose ();
            }
            view.FindViewById<TextView>(Resource.Id.Text1).Text = item.Name;
            view.FindViewById<TextView>(Resource.Id.Text2).Text = item.Category;
            
            // grab the old image and dispose of it
            // TODO: optimize if the image is the *same* and we want to just keep it
            if (view.FindViewById<ImageView>(Resource.Id.Image).Drawable != null)
            {
                using (var image = view.FindViewById<ImageView>(Resource.Id.Image).Drawable as BitmapDrawable)
                {
                    if (image != null)
                    {
                        if(image.Bitmap != null)
                            image.Bitmap.Dispose();
                    }
                }
            }

            // If a new image is required, display it
            if (!String.IsNullOrWhiteSpace(item.ImageFilename))
            {
                context.Resources.GetBitmapAsync(item.ImageFilename).ContinueWith((t) =>
                {
                    var bitmap = t.Result;
                    if (bitmap != null)
                    {
                        view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(bitmap);
                        bitmap.Dispose();
                    }
                },TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                // clear the image
                view.FindViewById<ImageView>(Resource.Id.Image).SetImageBitmap(null);
            }
            return view;
        }

        public override int Count
        {
            get { return tableItems.Count; }
        }

        public override DataSource this[int position]
        {
            get { return tableItems[position]; }
        }
    }
}