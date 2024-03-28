namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        float total = 0;
        float gorjeta = 0;
        float valor = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //valor da refeicao (entry)
            //gorjeta (label)
            //total (label)
            //slider para a % de gorjeta
            //preset buttons para % de gorjeta

            //arredonda o total com gorjeta pra baixo (button)
            //arredonda pra cima (button)
            valor = Int32.Parse(ValorEntry.Text);
            total = gorjeta + valor;

        }
    }

}
