namespace eGym.UI.Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void uposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEmployee frm = new frmEmployee();
            //frm.MdiParent= this;
            //frm.Show();

            //this.Close();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAccount frm = new frmAccount();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void planIshraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiet frm = new frmDiet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void planTreningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraining frm = new frmTraining();
            frm.MdiParent = this;
            frm.Show();
        }

        private void zahtjevZaTerminimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservation frm = new frmReservation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void izjestajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledRasporedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsOverview frm = new frmReservationsOverview();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviUposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frm = new frmCreateEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.MdiParent = this;
            frm.Show();
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
