﻿#pragma checksum "..\..\SplashScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FAA6071CCE730A8F2C07F8AE3BBA4981F65382F0A61BC27E5302B8BBF42B3135"
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
using _1612459_CakeShop;


namespace _1612459_CakeShop {
    
    
    /// <summary>
    /// SplashScreen
    /// </summary>
    public partial class SplashScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\SplashScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush BackgoundImg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SplashScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Title;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SplashScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\SplashScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Check;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SplashScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Continue;
        
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
            System.Uri resourceLocater = new System.Uri("/1612459_CakeShop;component/splashscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SplashScreen.xaml"
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
            
            #line 16 "..\..\SplashScreen.xaml"
            ((_1612459_CakeShop.SplashScreen)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackgoundImg = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.Title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Check = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\SplashScreen.xaml"
            this.Check.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\SplashScreen.xaml"
            this.Check.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Continue = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\SplashScreen.xaml"
            this.Continue.Click += new System.Windows.RoutedEventHandler(this.Continue_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

