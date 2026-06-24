namespace sistema_login_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string nome_usuario = caixa_usuario.Text;
            string senha = caixa_senha.Text;

            if(nome_usuario == "admin" && senha == "1234")
            {
                MessageBox.Show($"Seja bem vindo(a) {nome_usuario}");
            }
            else
            {
                MessageBox.Show($"Usuario ou senha não cadastrados!");
            }
            
        }

        
    }
}
