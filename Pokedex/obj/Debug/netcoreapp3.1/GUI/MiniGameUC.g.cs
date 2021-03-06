﻿#pragma checksum "..\..\..\..\GUI\MiniGameUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DBD062CF74B27553CDE0C34A6E8767F92971867F"
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
using Pokedex;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Pokedex {
    
    
    /// <summary>
    /// MiniGameUC
    /// </summary>
    public partial class MiniGameUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image water1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image grass1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image fire1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image water2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image grass2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image fire2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DrawText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LossText;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\GUI\MiniGameUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WinsText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pokedex;component/gui/minigameuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\MiniGameUC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\GUI\MiniGameUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Water);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\..\GUI\MiniGameUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Fire);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\..\GUI\MiniGameUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Grass);
            
            #line default
            #line hidden
            return;
            case 4:
            this.water1 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.grass1 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.fire1 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.water2 = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.grass2 = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.fire2 = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.DrawText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.LossText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.WinsText = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

