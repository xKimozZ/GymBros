﻿using DBapplication.GymBrosDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication.Admin_Menu
{
    public partial class Report4 : UserControl
    {
        public Report4()
        {
            InitializeComponent();
            usersTableAdapter.Fill(gymBrosDBDataSet.Users);
            reportViewer1.RefreshReport();
        }
    }
}
