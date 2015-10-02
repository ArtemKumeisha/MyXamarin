using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeRendererListView.DataSources;
using NativeRendererListView.Renderers;
using Xamarin.Forms.Platform.WinPhone;

namespace NativeRendererListView.WinPhone.CustomRenderers
{
    public  class NativeWPListViewSource:TableView
    {
        private IList<DataSource> tableItems;
        private NativeListView listView;

        public IEnumerable<DataSource> Items
        {
            set { tableItems = value.ToList(); }
        }

        public NativeWPListViewSource(NativeListView view)
        {
            listView = view;
            tableItems = view.Items.ToList();
        }

    }
}
