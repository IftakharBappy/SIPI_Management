﻿#pragma checksum "..\..\..\..\UI\PIS\GradeUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02BF5E828813DFDEE3B4AD5036614043"
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


namespace SIPI_SL.UI.PIS {
    
    
    /// <summary>
    /// GradeUI
    /// </summary>
    public partial class GradeUI : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvUserGroup;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditUserGroup;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveUserGroup;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox2;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserGroupName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddUserGroup;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UI\PIS\GradeUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button groupClosebutton;
        
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
            System.Uri resourceLocater = new System.Uri("/SIPI_SL;component/ui/pis/gradeui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\PIS\GradeUI.xaml"
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
            this.groupBox1 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.lvUserGroup = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.EditUserGroup = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\..\UI\PIS\GradeUI.xaml"
            this.EditUserGroup.Click += new System.Windows.RoutedEventHandler(this.EditUserGroupClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RemoveUserGroup = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\..\UI\PIS\GradeUI.xaml"
            this.RemoveUserGroup.Click += new System.Windows.RoutedEventHandler(this.RemoveUserGroupClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.groupBox2 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.txtUserGroupName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddUserGroup = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\UI\PIS\GradeUI.xaml"
            this.btnAddUserGroup.Click += new System.Windows.RoutedEventHandler(this.BtnAddUserGroupClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.groupClosebutton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\UI\PIS\GradeUI.xaml"
            this.groupClosebutton.Click += new System.Windows.RoutedEventHandler(this.groupClosebutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

