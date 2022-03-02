using SysAnd.UIForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd
{
    public partial class frmSysAnd : Form
    {
        public frmSysAnd()
        {
            InitializeComponent();
        }

        private void defeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void lblLoggin_Click(object sender, EventArgs e)
        {

        }
    }
}
