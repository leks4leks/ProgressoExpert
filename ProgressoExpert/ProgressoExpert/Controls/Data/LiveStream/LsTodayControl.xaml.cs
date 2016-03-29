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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgressoExpert.Controls.Data.LiveStream
{
    /// <summary>
    /// Логика взаимодействия для LsTodayControl.xaml
    /// </summary>
    public partial class LsTodayControl : UserControl
    {
        LiveStreamModel ViewModel;

        public LsTodayControl()
        {
            InitializeComponent();
        }

        private void WindowsFormsHost_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }

        public void DataBind(LiveStreamModel model)
        {
            ViewModel = (LiveStreamModel)model;
            this.DataContext = (LiveStreamModel)model;
            if (ViewModel.CycleMoneyDiagram != null)
            {
                LoadDiagram();
            }
        }

        public void LoadDiagram()
        {

            chart.ChartAreas.Add(new ChartArea("Default"));
            chart.IsSoftShadows = false;

            var legend = new Legend("Legend1");
            var series = new Series("Series1");
            series.ShadowColor = System.Drawing.Color.Black;
            series.ShadowOffset = 1;

            series.ChartType = SeriesChartType.Doughnut;
            series.ChartArea = "Default";
            series.Legend = "Legend1";

            foreach (var item in ViewModel.CycleMoneyDiagram)
            {
                series.Points.Add(new DataPoint()
                {
                    Label = item.Value.ToString(),
                    XValue = (double)item.Value,
                    YValues = new double[] { (double)item.Value },
                    LegendText = item.Key.ToString(),
                    Color = System.Drawing.Color.FromArgb(137, 165, 78),
                    BorderColor = System.Drawing.Color.White
                });
            }

            chart.Series.Add(series);
            chart.Legends.Add(legend);
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
        }
    }
}