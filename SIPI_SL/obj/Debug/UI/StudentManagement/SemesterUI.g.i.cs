﻿#pragma checksum "..\..\..\..\UI\StudentManagement\SemesterUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FEDF54EDF593FB80C80A204A6610C30"
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


namespace SIPI_SL.UI.StudentManagement {
    
    
    /// <summary>
    /// SemesterUI
    /// </summary>
    public partial class SemesterUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox semesterNoTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView semesterlistView;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ZoneIformationList;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditDistrictContextMenu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveDistrictContextMenu;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox banglaSenesterNoTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/studentmanagement/semesterui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
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
            this.semesterNoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.semesterlistView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.ZoneIformationList = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.EditDistrictContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
            this.EditDistrictContextMenu.Click += new System.Windows.RoutedEventHandler(this.EditSemesterContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveDistrictContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
            this.RemoveDistrictContextMenu.Click += new System.Windows.RoutedEventHandler(this.RemoveSemesterContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\UI\StudentManagement\SemesterUI.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.banglaSenesterNoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

