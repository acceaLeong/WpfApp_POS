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
using WpfAppPOS1.ViewModels;

namespace WpfAppPOS1.Views
{
    /// <summary>
    /// Interaction logic for ManageStaff.xaml
    /// </summary>
    public partial class ManageStaff : UserControl  
    {
        public ManageStaff()
        {
            DataContext = new ManageStaffVM();
            InitializeComponent();
        }
    }
}
