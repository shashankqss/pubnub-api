﻿#pragma checksum "C:\Users\Jhonny\Desktop\3.3.0.1\PubnubSilverlight.Example\Controls\PubnubDiagramItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5718F4271D36A2F1DF28A3224E0FE496"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PubNub_Messaging {
    
    
    public partial class PubnubDiagramItem : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle Column;
        
        internal System.Windows.Controls.TextBlock Value;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PubnubSilverlight.Example;component/Controls/PubnubDiagramItem.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Column = ((System.Windows.Shapes.Rectangle)(this.FindName("Column")));
            this.Value = ((System.Windows.Controls.TextBlock)(this.FindName("Value")));
        }
    }
}

