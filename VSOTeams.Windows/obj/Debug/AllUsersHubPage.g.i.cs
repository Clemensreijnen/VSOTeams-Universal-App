﻿

#pragma checksum "C:\Users\Clemens\Source\Repos\VSOTeams\VSOTeams\VSOTeams.Windows\AllUsersHubPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D4DE539E7E85A02F537348AD67752267"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSOTeams
{
    partial class AllUsersHubPage : global::VSOTeams.ViewBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::VSOTeams.ViewBase allUsers; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock pageTitle; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.HubSection HubStart; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.HubSection HubAllUsers; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///AllUsersHubPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            allUsers = (global::VSOTeams.ViewBase)this.FindName("allUsers");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            HubStart = (global::Windows.UI.Xaml.Controls.HubSection)this.FindName("HubStart");
            HubAllUsers = (global::Windows.UI.Xaml.Controls.HubSection)this.FindName("HubAllUsers");
        }
    }
}



