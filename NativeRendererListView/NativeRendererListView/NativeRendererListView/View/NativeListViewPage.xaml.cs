using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeRendererListView.DataSources;
using NativeRendererListView.DataVirtualization;
using Xamarin.Forms;

namespace NativeRendererListView.View
{  /// <summary>
    /// This page uses a custom renderer that wraps native list controls:
    ///    iOS :           UITableView
    ///    Android :       ListView   (do not confuse with Xamarin.Forms ListView)
    ///    Windows Phone : ?
    /// 
    /// It uses a CUSTOM row/cell class that is defined natively which 
    /// is still faster than a Xamarin.Forms-defined ViewCell subclass.
    /// </summary>
    public partial class NativeListViewPage : ContentPage
    {
        public NativeListViewPage()
        {
            InitializeComponent();
            StartLabel.Text = Device.OnPlatform("Custom UITableView+UICell", "Custom ListView+Cell",
                "Custom renderer todo");
            DataSourceProvider sourceProvider = new DataSourceProvider();
            //NativeList.Items = new VirtualizingCollection<DataSource>(sourceProvider);
            NativeList.Items = DataSource.GetDataSourcesList();
        }

    private async void NativeListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushModalAsync (new DetailPage(e.SelectedItem));
        //await DisplayAlert("clicked", "one of the rows was clicked", "ok");
    }
    }
}
