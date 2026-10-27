using PryCorderoREPASO;

namespace PryCorderoREPASO
{
    public partial class lblNombre : Form
    {
        private string? txtCarga;

        public string codigo { get; private set; }

        public lblNombre()
        {
            InitializeComponent();
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            string dato;
            int codigo;
            codigo = int.Parse(txtCodigo.Text);
            dato = txtNombre.Text;
            MessageBox.Show("Nombre: " + dato + " codigo: " + codigo);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Load(object sender, EventArgs e)
        {

        }

        private void lblcodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
  