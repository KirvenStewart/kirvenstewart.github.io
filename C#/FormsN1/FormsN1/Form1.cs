namespace FormsN1
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

        private void button1_Click(object sender, EventArgs e)
        {
            long vn1, vn2, vresultsuma, vresultresta,vresultdivi,vresultmulti;
            vn1 = Convert.ToInt32(txtn1.Text);
            vn2 = Convert.ToInt32(txtn2.Text);
            vresultsuma = vn1+ vn2;
            vresultresta = vn1 - vn2;
            vresultdivi = vn1 / vn2;
            vresultmulti = vn1 * vn2;
            txtsuma.Text = Convert.ToString(vresultsuma);
            txtresta.Text = Convert.ToString(vresultresta);
            txtmulti.Text = Convert.ToString(vresultmulti);
            txtdivi.Text = Convert.ToString(vresultdivi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtsuma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}