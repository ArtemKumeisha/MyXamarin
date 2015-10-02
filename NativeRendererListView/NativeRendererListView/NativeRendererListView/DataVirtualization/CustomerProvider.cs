using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeRendererListView.DataSources;

namespace NativeRendererListView.DataVirtualization
{
    public class CustomerProvider:IItemsProvider<DataSource>
    {
        public int FetchCount()
        {
            throw new NotImplementedException();
        }

        public IList<DataSource> FetchRange(int startIndex, int count)
        {
            throw new NotImplementedException();
        }
    }
}
