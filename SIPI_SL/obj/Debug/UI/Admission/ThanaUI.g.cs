﻿#pragma checksum "..\..\..\..\UI\Admission\ThanaUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7BC2B09F2FA5DC4CFB1DC7E2C5C7E87"
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
    /// ThanaUI
    /// </summary>
    public partial class ThanaUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThanaNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox banglaThanaNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ThanalistView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ZoneIformationList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditThanaContextMenu;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveThanaContextMenu;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\UI\Admission\ThanaUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox districtCombobax;
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/admission/thanaui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Admission\ThanaUI.xaml"
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
            this.ThanaNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.banglaThanaNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ThanalistView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.ZoneIformationList = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 5:
            this.EditThanaContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\..\UI\Admission\ThanaUI.xaml"
            this.EditThanaContextMenu.Click += new System.Windows.RoutedEventHandler(this.EditThanaContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoveThanaContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\..\..\UI\Admission\ThanaUI.xaml"
            this.RemoveThanaContextMenu.Click += new System.Windows.RoutedEventHandler(this.RemoveThanaContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\UI\Admission\ThanaUI.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.districtCombobax = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

