using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using immmclient.cn.imaimaimai.www;
using System.Net;
using System.IO;

namespace immmclient
{
    public partial class WXWeb : Form
    {
        public WXWeb()
        {
            InitializeComponent();
        }
        private void btVisitWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.imaimaimai.cn");  
        }
    }
}
