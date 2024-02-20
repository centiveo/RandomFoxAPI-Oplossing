using System.Text.Json;

namespace RandomFoxAPI_Oplossing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetFoxImage_Click(object sender, EventArgs e)
        {
            using HttpClient client = new();
            await ProcessFoxImageAsync(client);
        }

        private async Task ProcessFoxImageAsync(HttpClient client)
        {
            var json = await client.GetStringAsync(
                 "https://randomfox.ca/floof/");

            var foxImage = JsonSerializer.Deserialize<FoxImage>(json);
           
            picFox.ImageLocation = foxImage.image;
        }

    }
}