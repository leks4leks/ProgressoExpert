﻿#pragma checksum "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9BE1E0A5C05AC704869A41E473682B8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
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


namespace Whush.Demo.Styles.CustomizedWindow {
    
    
    /// <summary>
    /// VS2012WindowStyle
    /// </summary>
    public partial class VS2012WindowStyle : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/ProgressoExpert;component/styles/customizedwindow/vs2012windowstyle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
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
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 85 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBarMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 86 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TitleBarMouseMove);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 104 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.IconMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 125 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinButtonClick);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 144 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaxButtonClick);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 164 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 181 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorth);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 189 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouth);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 198 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeWest);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 206 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeEast);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 214 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthWest);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 215 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthEast);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 216 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthWest);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 217 "..\..\..\..\Styles\CustomizedWindow\VS2012WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthEast);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

