namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void AcessarGit(object sender, EventArgs e)
    {

        await Launcher.Default.OpenAsync("https://github.com/Victor-Picciutti");
    }
}