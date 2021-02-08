﻿using BasicRendering.Wpf.Properties;
using FigmaSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BasicRendering.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //var token = Environment.GetEnvironmentVariable("TOKEN");
            var token = "68053-90047720-9c08-4d61-95da-d704bf883f11";
            if (string.IsNullOrEmpty(token))
            {
                token = Settings.Default.TOKEN;
            }
            FigmaApplication.Init(token);
        }
    }
}
