﻿#pragma checksum "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F193FC42A9A6F2B0738409CE3E75184D"
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


namespace SIPI_SL.UI.StudentManagement {
    
    
    /// <summary>
    /// StudentManagementMainUI
    /// </summary>
    public partial class StudentManagementMainUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/studentmanagement/studentmanagementmainui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
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
            
            #line 10 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Program);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Department);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 12 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Batch);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 14 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 15 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Time);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 16 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_AssignTeacher);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_RutinCreate);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 30 "..\..\..\..\UI\StudentManagement\StudentManagementMainUI.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_AddTeacher);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

