using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeRendererListView.DataSources;

namespace NativeRendererListView.DataVirtualization
{
    public  class DataSourceProvider:IItemsProvider<DataSource>
    {
        private readonly IEnumerable<DataSource> source;
        public DataSourceProvider()
        {
            source = DataSource.GetDataSourcesList();
        }

        public int FetchCount()
        {
            return DataSource.GetDataSourcesList().Count;
        }

        public IList<DataSource> FetchRange(int startIndex, int count)
        {
            return null;
        }
    }
}
