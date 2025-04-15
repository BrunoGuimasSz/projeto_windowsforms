namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.MdiParent = this;
            childForm.Show();

        }


    }
}
