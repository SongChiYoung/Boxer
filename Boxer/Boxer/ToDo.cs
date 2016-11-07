using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boxer
{
    public partial class ToDo : Form
    {
        public ToDo(string func)
        {
            InitializeComponent();
            FuncName.Text = func;
        }

        private void ToDo_Load(object sender, EventArgs e)
        {
            FuncName.Location = new Point(this.Width / 2 - FuncName.Width/2, this.Height / 2);
        }
    }
}
