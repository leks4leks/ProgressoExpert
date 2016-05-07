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

namespace ProgressoExpert.Controls.Data.ResBusiness
{
    /// <summary>
    /// Логика взаимодействия для RB_ProfitLossReport.xaml
    /// </summary>
    public partial class RB_ProfitLossReport : UserControl
    {
        public RB_ProfitLossReport()
        {
            InitializeComponent();
        }

        public void DataBind(MainModel vm)
        {
            DataContext = vm.ReportProfitAndLoss;
        }
    }
}
