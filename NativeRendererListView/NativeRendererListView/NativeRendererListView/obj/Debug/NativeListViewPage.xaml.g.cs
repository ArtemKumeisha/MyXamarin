//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NativeRendererListView.View {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class NativeListViewPage : ContentPage {
        
        private Label StartLabel;
        
        private global::NativeRendererListView.Renderers.NativeListView NativeList;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(NativeListViewPage));
            StartLabel = this.FindByName<Label>("StartLabel");
            NativeList = this.FindByName<global::NativeRendererListView.Renderers.NativeListView>("NativeList");
        }
    }
}
