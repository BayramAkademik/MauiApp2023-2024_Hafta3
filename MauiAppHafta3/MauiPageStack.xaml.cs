namespace MauiAppHafta3
{
    public partial class MauiPageStack : ContentPage
    {
        public MauiPageStack()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            sLogin.IsVisible = !sLogin.IsVisible;
            sSignin.IsVisible = !sSignin.IsVisible;

            //Navigation.PushModalAsync(new MauiPageTab());
        }
    }
}
