namespace cadastroEmpresas
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos não estão vazios
                if (!string.IsNullOrEmpty(txtNome.Text) &&
                    !string.IsNullOrEmpty(txtCnpj.Text) &&
                    !string.IsNullOrEmpty(txtData.Text))
                {
                    // Instancia a classe cadastrarEmpresas
                    cadastrarEmpresas cadEmpresas = new cadastrarEmpresas
                    {
                        Nome = txtNome.Text,
                        Cnpj = txtCnpj.Text
                    };

                    // Tenta converter a data
                    if (!DateTime.TryParse(txtData.Text, out DateTime dataConvertida))
                    {
                        MessageBox.Show("Data inválida. Insira uma data no formato correto (ex: DD/MM/AAAA).");
                        return;
                    }
                    cadEmpresas.Data = dataConvertida;

                    // Tenta cadastrar no banco
                    if (cadEmpresas.Empresas())
                    {
                        MessageBox.Show($"A empresa {cadEmpresas.Nome} foi cadastrada com sucesso!");

                        // Limpa os campos após o sucesso
                        txtNome.Clear();
                        txtCnpj.Clear();
                        txtData.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar a empresa.");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar empresa: " + ex.Message);
            }
        }

    } 
}
