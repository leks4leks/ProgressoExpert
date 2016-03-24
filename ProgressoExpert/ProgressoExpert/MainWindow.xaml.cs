﻿using ProgressoExpert.Models.Models;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressoExpert
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainModel ViewModel;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel = new MainModel();
            HeaderControl.DataContext = ViewModel.InfoModel;
            MenuControl.DataContext = MenuControl.ViewModel = ViewModel;
            ViewModel.Test = false;
        }
    }
}
