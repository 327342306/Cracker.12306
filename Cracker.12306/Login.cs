﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cracker._12306
{
    public partial class Login : Form
    {
        Cracker._12306.Helper.Handle.Login _login = new Helper.Handle.Login();
        public Login()
        {
            InitializeComponent();
            _login.Init().GetDynamicFormUrl();
        }
    }
}
