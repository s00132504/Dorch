﻿

#pragma checksum "C:\Users\ed\Documents\Visual Studio 2013\Projects\Dorch\Dorch\View\ViewTeam.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B2034AB48342DD80BED01961D875E64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dorch.View
{
    partial class ViewTeam : global::Dorch.Common.BindablePage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Dorch.Converters.ItemClickedConverter ItemClickedConverter; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid LayoutRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Hub TeamHub; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.HubSection RegularsSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.HubSection SelectedSection; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.CommandBar appBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///View/ViewTeam.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            ItemClickedConverter = (global::Dorch.Converters.ItemClickedConverter)this.FindName("ItemClickedConverter");
            LayoutRoot = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("LayoutRoot");
            TeamHub = (global::Windows.UI.Xaml.Controls.Hub)this.FindName("TeamHub");
            RegularsSection = (global::Windows.UI.Xaml.Controls.HubSection)this.FindName("RegularsSection");
            SelectedSection = (global::Windows.UI.Xaml.Controls.HubSection)this.FindName("SelectedSection");
            appBar = (global::Windows.UI.Xaml.Controls.CommandBar)this.FindName("appBar");
        }
    }
}



