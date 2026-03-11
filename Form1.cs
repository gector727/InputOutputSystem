namespace TPModul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string namaPraktikum = txtInput.Text;
            lblOutput.Text = "Halo " + namaPraktikum;
        }
    }
}
