using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama Menu;
        MenuStrip mnstrip;
        FormLogin frmLogin;
        void frmLogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }

        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;  
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
           // Menu = this();


        }



        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void mainKategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void riwayatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void MenuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
            //frmLogin = new FormLogin();
            //frmLogin.Show();
        }

        private void MenuMaster_Click(object sender, EventArgs e)
        {

        }

        private void MenuFile_Click(object sender, EventArgs e)
        {

        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }
    }
}
