namespace Clothing_Store
{
    public partial class Shoes_Area : Form
    {
        String Tenis, Bota, Sapato, Cal�ado;
        String Vermelho, Preto, Branco, Cor;

        public Shoes_Area()
        {
            InitializeComponent();

        }

        private void Bt_Generate_Click(object sender, EventArgs e)
        {
            Tb_Result.Text = null;

            Cal�ado = Cbo_Shoes.Text;
            Cor = Cbo_Color.Text;

            Tb_Result.Text = Cal�ado + Cor;
        }
    }
}