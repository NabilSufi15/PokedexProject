﻿#pragma checksum "..\..\..\PokedexUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F66C8AB6CEC8030D3E43F75A34053B564DCC96A5"
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
    /// PokedexUC
    /// </summary>
    public partial class PokedexUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TransitionSlide;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxPokemon;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pkImage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextType;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextDescription;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextHeight;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\PokedexUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextWeight;
        
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
            System.Uri resourceLocater = new System.Uri("/Pokedex;component/pokedexuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PokedexUC.xaml"
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
            this.TransitionSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 2:
            this.SearchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\PokedexUC.xaml"
            this.SearchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListBoxPokemon = ((System.Windows.Controls.ListBox)(target));
            
            #line 17 "..\..\..\PokedexUC.xaml"
            this.ListBoxPokemon.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxPokemon_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pkImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.TextId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TextName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TextDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TextHeight = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TextWeight = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 65 "..\..\..\PokedexUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Speech);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 68 "..\..\..\PokedexUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cry);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 75 "..\..\..\PokedexUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Stats);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

