﻿#pragma checksum "..\..\USProductDetail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6142D1044B54E60FDCF394F33A9E641C588ED3E21F21D65B50B97ECB497768AE"
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
    /// USProductDetail
    /// </summary>
    public partial class USProductDetail : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent TrainsitionigContentSlide;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel _frame;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl PreviewPhoto;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel _editProduct;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Minus;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _number;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\USProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Plus;
        
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
            System.Uri resourceLocater = new System.Uri("/1612459_CakeShop;component/usproductdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\USProductDetail.xaml"
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
            
            #line 16 "..\..\USProductDetail.xaml"
            ((_1612459_CakeShop.USProductDetail)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TrainsitionigContentSlide = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 3:
            this._frame = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.PreviewPhoto = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 5:
            this._editProduct = ((System.Windows.Controls.StackPanel)(target));
            
            #line 89 "..\..\USProductDetail.xaml"
            this._editProduct.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this._editProduct_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Minus = ((System.Windows.Controls.Border)(target));
            
            #line 107 "..\..\USProductDetail.xaml"
            this.Minus.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Minus_MouseUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this._number = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Plus = ((System.Windows.Controls.Border)(target));
            
            #line 119 "..\..\USProductDetail.xaml"
            this.Plus.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Plus_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 122 "..\..\USProductDetail.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.orderProduct);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

