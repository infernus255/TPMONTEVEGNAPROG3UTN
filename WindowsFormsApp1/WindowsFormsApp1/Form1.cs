using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ventanaPpll : Form
    {
        public ventanaPpll()
        {
            InitializeComponent();
        }

        private void btnMenuPersonas_Click(object sender, EventArgs e)
        {
            ventanaPersonas vp = new ventanaPersonas();
            vp.MdiParent = this;
            vp.Show();
        }

        private void btnMenuObjetos_Click(object sender, EventArgs e)
        {
            ventanaObj vo = new ventanaObj();
            vo.MdiParent = this;
            vo.Show();
        }
    }
}
