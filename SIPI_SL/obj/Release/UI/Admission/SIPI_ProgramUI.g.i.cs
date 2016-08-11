﻿#pragma checksum "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D22D42F48B933FD03D3B9641D5CAA0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    /// SIPI_ProgramUI
    /// </summary>
    public partial class SIPI_ProgramUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SipiProgramNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SipiProgramTimeTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView sIPI_programlistView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ZoneIformationList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditDepartmentContextMenu;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveDepartmentContextMenu;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox banglaSipiProgramTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clearButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/admission/sipi_programui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
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
            this.SipiProgramNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SipiProgramTimeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sIPI_programlistView = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.ZoneIformationList = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 5:
            this.EditDepartmentContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
            this.EditDepartmentContextMenu.Click += new System.Windows.RoutedEventHandler(this.EditSipiProgramContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoveDepartmentContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
            this.RemoveDepartmentContextMenu.Click += new System.Windows.RoutedEventHandler(this.RemoveSipiProgramContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.banglaSipiProgramTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.clearButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\UI\Admission\SIPI_ProgramUI.xaml"
            this.clearButton.Click += new System.Windows.RoutedEventHandler(this.clearButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

