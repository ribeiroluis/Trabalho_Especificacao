using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGRI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInfraEstruturaEquipamentos equip = new frmInfraEstruturaEquipamentos();
            equip.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCoordenadoDiretor cord = new frmCoordenadoDiretor();            
            cord.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInfraEstruturaUsuarios user = new frmInfraEstruturaUsuarios();
            user.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProfessor prof = new frmProfessor();
            prof.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmInfraReservas res = new frmInfraReservas();
            res.ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarSenha alter = new frmAlterarSenha();
            alter.ShowDialog();
        }
    }
}
