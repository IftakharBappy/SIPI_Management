﻿#pragma checksum "..\..\..\..\UI\Admission\DistrictUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CA0A4CABE0A0909FBDC28FE3E9B54F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RootLibrary.WPF.Localization;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SIPI_SL.UI.Admission {
    
    
    /// <summary>
    /// DistrictUI
    /// </summary>
    public partial class DistrictUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox districtNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView DistrictlistView;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ZoneIformationList;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditDistrictContextMenu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveDistrictContextMenu;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\UI\Admission\DistrictUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox banglaDistrictTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/admission/districtui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Admission\DistrictUI.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.districtNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DistrictlistView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.ZoneIformationList = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.EditDistrictContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\..\..\UI\Admission\DistrictUI.xaml"
            this.EditDistrictContextMenu.Click += new System.Windows.RoutedEventHandler(this.EditDistrictContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveDistrictContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\..\UI\Admission\DistrictUI.xaml"
            this.RemoveDistrictContextMenu.Click += new System.Windows.RoutedEventHandler(this.RemoveDistrictContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\UI\Admission\DistrictUI.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.banglaDistrictTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

