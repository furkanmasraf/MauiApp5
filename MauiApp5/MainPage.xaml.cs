namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        String img1_str = "mauii.jpg";
        String img2_str = "ma.jpg";
        String img3_str = "mau.jpg";
        String img4_str = "maui.jpg";
        public MainPage()
        {
            InitializeComponent();
        }

        private void clickme_Clicked(object sender, EventArgs e)
        {
            img1.Source = img1_str;
            img2.Source = img2_str;
            img3.Source = img3_str;
            img4.Source = img4_str;
            String temp;
            temp = img3_str;
            img3_str = img4_str;
            img4_str = img2_str;
            img2_str = img1_str;
            img1_str = temp;
        }
    }

}
