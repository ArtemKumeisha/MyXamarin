using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;
using Image = System.Windows.Controls.Image;

namespace NativeRendererListView.WinPhone.CustomRenderers
{
    public class NativeWPListViewCell: ViewCellRenderer
    {
        private Label headingLabel, subheadingLabel;
        private Image image;

        public NativeWPListViewCell(String cellId)
        {
            image = new Image();

            headingLabel = new Label()
            {
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Lime,
                BackgroundColor = Color.Default
            };

            subheadingLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Lime,
                BackgroundColor = Color.Default
            };

        }
    }
}
