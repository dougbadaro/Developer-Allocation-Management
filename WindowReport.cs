using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    public partial class WindowReport : Form
    {
        private static WindowReport _instance;
        public static WindowReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowReport();
            }

            return _instance;
        }
        public WindowReport()
        {
            InitializeComponent();
        }
    }
}
