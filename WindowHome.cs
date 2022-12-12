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
    public partial class WindowHome : Form
    {
        private static WindowHome _instance;
        public static WindowHome GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowHome();
            }

            return _instance;
        }
        public WindowHome()
        {
            InitializeComponent();
        }
    }
}
