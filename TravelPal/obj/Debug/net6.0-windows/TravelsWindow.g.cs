﻿#pragma checksum "..\..\..\TravelsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981A972A9A7720E319F1461899F28622566EF163"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TravelPal;


namespace TravelPal {
    
    
    /// <summary>
    /// TravelsWindow
    /// </summary>
    public partial class TravelsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsername;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUserDetails;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTravel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetails;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAsk;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignOut;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\TravelsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvCountrey;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TravelPal;component/travelswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TravelsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblUsername = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnUserDetails = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\TravelsWindow.xaml"
            this.btnUserDetails.Click += new System.Windows.RoutedEventHandler(this.btnUserDetails_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddTravel = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\TravelsWindow.xaml"
            this.btnAddTravel.Click += new System.Windows.RoutedEventHandler(this.btnAddTravel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDetails = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\TravelsWindow.xaml"
            this.btnDetails.Click += new System.Windows.RoutedEventHandler(this.btnDetails_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\TravelsWindow.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAsk = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\TravelsWindow.xaml"
            this.btnAsk.Click += new System.Windows.RoutedEventHandler(this.btnAsk_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSignOut = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\TravelsWindow.xaml"
            this.btnSignOut.Click += new System.Windows.RoutedEventHandler(this.btnSignOut_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lvCountrey = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

