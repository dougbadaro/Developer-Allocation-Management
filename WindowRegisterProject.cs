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
    public partial class WindowRegisterProject : Form
    {
        private static WindowRegisterProject _instance;
        public static WindowRegisterProject GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new WindowRegisterProject();
            }

            return _instance;
        }

        public WindowRegisterProject()
        {
            InitializeComponent();
        }
    }
}
