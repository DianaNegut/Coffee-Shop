﻿#pragma checksum "..\..\..\Ferestre Angajati\firstMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43423546CD8B3D69243F908957A4D479BC356A3E36C29D2C6B58865D8868C240"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Angajati;
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


namespace Angajati {
    
    
    /// <summary>
    /// firstMenu
    /// </summary>
    public partial class firstMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 107 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reservation;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button comenzi;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aboutus;
        
        #line default
        #line hidden
        
        
        #line 330 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button user;
        
        #line default
        #line hidden
        
        
        #line 367 "..\..\..\Ferestre Angajati\firstMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Angajati;component/ferestre%20angajati/firstmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ferestre Angajati\firstMenu.xaml"
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
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.home.Click += new System.Windows.RoutedEventHandler(this.home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.reservation = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.reservation.Click += new System.Windows.RoutedEventHandler(this.reservation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comenzi = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.comenzi.Click += new System.Windows.RoutedEventHandler(this.comenzi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.aboutus = ((System.Windows.Controls.Button)(target));
            
            #line 257 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.aboutus.Click += new System.Windows.RoutedEventHandler(this.aboutus_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.user = ((System.Windows.Controls.Button)(target));
            
            #line 330 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.user.Click += new System.Windows.RoutedEventHandler(this.user_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 368 "..\..\..\Ferestre Angajati\firstMenu.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

