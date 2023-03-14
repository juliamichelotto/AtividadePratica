namespace AtividadePratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            SP sp = new SP();
            sp.Cpf = txtCPF.Text;
            sp.Nome = txtNome.Text;
            sp.Vd = double.Parse(txtVD.Text);
            sp.Dt = int.Parse(txtDT.Text);
            
            sp.Calculo();

            txtSb.Text = sp.Sb.ToString("n2");
            txtIr.Text = sp.Ir.ToString("n2");
            txtSl.Text = sp.Sl.ToString("n2");


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }
    }
}