using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DxExample
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            new CategoryView { Dock = DockStyle.Fill, Parent = this }; 
        }
    }
}
