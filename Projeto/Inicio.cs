namespace Projeto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre childForm = new Sobre();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Sobre = new Form();   
        }
    }
}
