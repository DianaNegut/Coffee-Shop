﻿#pragma checksum "..\..\..\Plata\Plati.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61DC730A99FF686045141D332B27D69E5C384C68A06CBEDA9DE06EFB35EED2DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Angajati.Plata {
    
    
    /// <summary>
    /// Plati
    /// </summary>
    public partial class Plati : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SumaPlata;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nr1;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nr2;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nr3;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nr4;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DayTextBox;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\Plata\Plati.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonthTextBox;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\Plata\Plati.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Angajati;component/plata/plati.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Plata\Plati.xaml"
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
            this.SumaPlata = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 27 "..\..\..\Plata\Plati.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_AnularePlata);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nr1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 106 "..\..\..\Plata\Plati.xaml"
            this.nr1.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 107 "..\..\..\Plata\Plati.xaml"
            this.nr1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.nr2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 120 "..\..\..\Plata\Plati.xaml"
            this.nr2.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 121 "..\..\..\Plata\Plati.xaml"
            this.nr2.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.nr3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 133 "..\..\..\Plata\Plati.xaml"
            this.nr3.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 134 "..\..\..\Plata\Plati.xaml"
            this.nr3.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.nr4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 146 "..\..\..\Plata\Plati.xaml"
            this.nr4.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 147 "..\..\..\Plata\Plati.xaml"
            this.nr4.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 166 "..\..\..\Plata\Plati.xaml"
            ((System.Windows.Controls.TextBox)(target)).GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 167 "..\..\..\Plata\Plati.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInputName);
            
            #line default
            #line hidden
            
            #line 167 "..\..\..\Plata\Plati.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DayTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 184 "..\..\..\Plata\Plati.xaml"
            this.DayTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocusData);
            
            #line default
            #line hidden
            
            #line 185 "..\..\..\Plata\Plati.xaml"
            this.DayTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInputData);
            
            #line default
            #line hidden
            
            #line 186 "..\..\..\Plata\Plati.xaml"
            this.DayTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDownData);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MonthTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 206 "..\..\..\Plata\Plati.xaml"
            this.MonthTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocusData);
            
            #line default
            #line hidden
            
            #line 207 "..\..\..\Plata\Plati.xaml"
            this.MonthTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_PreviewTextInputData);
            
            #line default
            #line hidden
            
            #line 208 "..\..\..\Plata\Plati.xaml"
            this.MonthTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_PreviewKeyDownData);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 225 "..\..\..\Plata\Plati.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 227 "..\..\..\Plata\Plati.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

