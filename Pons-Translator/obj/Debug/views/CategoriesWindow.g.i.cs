﻿#pragma checksum "..\..\..\views\CategoriesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C686A932E6DD930881BCC1336FB3C5AD072404D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Pons_Translator;
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


namespace Pons_Translator {
    
    
    /// <summary>
    /// FashcardsWindow
    /// </summary>
    public partial class FashcardsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCategoryList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteCategory;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateCategory;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreateCategory;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCategoryName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCategoryName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCategoryID;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\views\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCategoryID;
        
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
            System.Uri resourceLocater = new System.Uri("/Pons-Translator;component/views/categorieswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\views\CategoriesWindow.xaml"
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
            this.lbCategoryList = ((System.Windows.Controls.ListBox)(target));
            
            #line 10 "..\..\..\views\CategoriesWindow.xaml"
            this.lbCategoryList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbCategoryList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDeleteCategory = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\views\CategoriesWindow.xaml"
            this.btnDeleteCategory.Click += new System.Windows.RoutedEventHandler(this.btnDeleteCategory_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnUpdateCategory = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\views\CategoriesWindow.xaml"
            this.btnUpdateCategory.Click += new System.Windows.RoutedEventHandler(this.btnUpdateCategory_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCreateCategory = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\views\CategoriesWindow.xaml"
            this.btnCreateCategory.Click += new System.Windows.RoutedEventHandler(this.btnCreateCategory_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblCategoryName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.tbCategoryName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblCategoryID = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.tbCategoryID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

