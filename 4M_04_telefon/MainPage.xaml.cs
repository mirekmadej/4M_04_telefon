namespace _4M_04_telefon
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string numer = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1Clicked(object sender, EventArgs e)
        {
            numer += "1";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }
        private void btn2Clicked(object sender, EventArgs e)
        {
            numer += "2";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn3Clicked(object sender, EventArgs e)
        {
            numer += "3";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn4Clicked(object sender, EventArgs e)
        {
            numer += "4";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn5Clicked(object sender, EventArgs e)
        {
            numer += "5";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn6Clicked(object sender, EventArgs e)
        {
            numer += "6";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn7Clicked(object sender, EventArgs e)
        {
            numer += "7";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn8Clicked(object sender, EventArgs e)
        {
            numer += "8";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn9Clicked(object sender, EventArgs e)
        {
            numer += "9";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btn0Clicked(object sender, EventArgs e)
        {
            numer += "0";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btnStarClicked(object sender, EventArgs e)
        {
            numer += "*";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btnHashClicked(object sender, EventArgs e)
        {
            numer += "#";
            numerLbl.Text = numer;
            SemanticScreenReader.Announce(numerLbl.Text);
        }

        private void btnDelClicked(object sender, EventArgs e)
        {
            if(numer.Length > 0)
            {
                numer = numer.Substring(0, numer.Length - 1);
                numerLbl.Text = numer;

                SemanticScreenReader.Announce(numerLbl.Text);
            }
        }
        private async void btnCALLClicked(object sender, EventArgs e)
        {
            await DisplayAlert("telefon", $"dzwonię pod numer {numer}", "OK");
        }



    }
}