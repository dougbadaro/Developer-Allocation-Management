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
    public partial class WindowRegisterDev : Form
    {
        private static WindowRegisterDev _instance;
        public static WindowRegisterDev GetInstance()
        {
            if ( _instance == null || _instance.IsDisposed )
            {
                _instance = new WindowRegisterDev();
            }

            return _instance;
        }
        public WindowRegisterDev()
        {
            InitializeComponent();
        }
    }
}
