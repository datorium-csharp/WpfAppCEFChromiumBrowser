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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace WpfAppCEFChromiumBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser browser;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        public void InitializeBrowser()
        {
            browser = new ChromiumWebBrowser();
            browser.LoadUrl("https://datorium.eu");
            tabItem1.Content = browser;
        }
    }
}
