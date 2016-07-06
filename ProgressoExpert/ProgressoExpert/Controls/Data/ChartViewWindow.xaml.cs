﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgressoExpert.Controls.Data
{
    /// <summary>
    /// Логика взаимодействия для ChartViewWindow.xaml
    /// </summary>
    public partial class ChartViewWindow : Window
    {
        public ChartViewWindow()
        {
            InitializeComponent();
        }

        public ChartViewWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            Top = 100;
            Left = 0;
            Width = mainWindow.RenderSize.Width;
            Height = mainWindow.RenderSize.Height - 100;
            Background = new SolidColorBrush() { Color = Colors.White, Opacity = 0.5 };
        }

        private void Window_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void chart_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Close();
        }
    }
}
