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
    public partial class WindowAbout : Form
    {
        private static WindowAbout _instance;
        public static WindowAbout GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowAbout();
            }

            return _instance;
        }
        private WindowAbout()
        {
            InitializeComponent();
        }
    }
}
