namespace Herramienta_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long vn2;
            double impuesto, vresultsuma;
            vn2 = Convert.ToInt32(txtpre.Text);
            impuesto = vn2 * 0.15;
            vresultsuma = impuesto + vn2;
            txtimp.Text = Convert.ToString(impuesto);
            txtto.Text = Convert.ToString(vresultsuma);
        }
    }
}