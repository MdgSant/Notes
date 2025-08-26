namespace Notes
  //atualizeiooo
{
    public partial class MainPage : ContentPage
    {
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");
        string caminhoDaPasta = Path.Combine(FileSystem.AppDataDirectory);

        public MainPage()
        {
            InitializeComponent();
            if(File.Exists(caminho))
                CaixaEditor.Text = File.ReadAllText(caminho);
        }

       

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);
            DisplayAlert("Arquivo salvo", $"Arquivo {conteudo} foi salvo com sucesso", "Ok");
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            if(File.Exists(caminho))
            {
            File.Delete(caminho);
                DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso!", "Ok");
                CaixaEditor.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Erro", "Arquivo nao existe", "Ok");
            }
        }

        private async void AbrirGerenciador(object sender, EventArgs e)
        {
            await Launcher.Default.OpenAsync($"{caminhoDaPasta}");
        }

    }
    }
