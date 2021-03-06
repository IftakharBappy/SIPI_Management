﻿#pragma checksum "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FE0B60CDCE5990014D80DD670AC43396"
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
    /// AdmissonOfficeUI
    /// </summary>
    public partial class AdmissonOfficeUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox officeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView admissionOfficeView;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu admissionOffice;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditProgramContextMenu;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveProgramContextMenu;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox campusCombobax;
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/admission/admissionofficeui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
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
            this.officeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.admissionOfficeView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.admissionOffice = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.EditProgramContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
            this.EditProgramContextMenu.Click += new System.Windows.RoutedEventHandler(this.EditProgramContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveProgramContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
            this.RemoveProgramContextMenu.Click += new System.Windows.RoutedEventHandler(this.RemoveProgramContextMenu_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.submitButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UI\Admission\AdmissionOfficeUI.xaml"
            this.submitButton.Click += new System.Windows.RoutedEventHandler(this.submitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.campusCombobax = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

