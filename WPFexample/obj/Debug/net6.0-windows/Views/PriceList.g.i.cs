﻿#pragma checksum "..\..\..\..\Views\PriceList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C84929DBB9F4FC242DD8592806C4B9996D773363"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPFexample.Views;


namespace WPFexample.Views {
    
    
    /// <summary>
    /// PriceList
    /// </summary>
    public partial class PriceList : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 32 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_Btn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MoneyText;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox categotiesList;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProductsList;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button makeOrder;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\PriceList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalPriceOrder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFexample;component/views/pricelist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PriceList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.exit_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\PriceList.xaml"
            this.exit_Btn.Click += new System.Windows.RoutedEventHandler(this.exit_btn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MoneyText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.categotiesList = ((System.Windows.Controls.ListBox)(target));
            
            #line 51 "..\..\..\..\Views\PriceList.xaml"
            this.categotiesList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.item_sel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProductsList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.makeOrder = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\Views\PriceList.xaml"
            this.makeOrder.Click += new System.Windows.RoutedEventHandler(this.MakeOrder);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TotalPriceOrder = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 96 "..\..\..\..\Views\PriceList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InOrder);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

