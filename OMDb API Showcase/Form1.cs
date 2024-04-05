using Newtonsoft.Json.Linq;
using OMDb_API_Showcase.Properties;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace OMDb_API_Showcase
{
    public partial class Form1 : Form
    {
        const string API_KEY = "&apikey=a0631fcf";

        public Form1()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void label_SizeChanged(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            if (label != null)
            {
                label.Left = (ClientSize.Width - label.Size.Width) / 2;
            }
        }

        private string TextFormatting(string text, int max)
        {
            StringBuilder formattedText = new StringBuilder();
            int index = 0;

            while (index < text.Length)
            {
                int endIndex = index + max;

                if (endIndex >= text.Length)
                {
                    endIndex = text.Length;
                }
                    
                else
                {
                    while (endIndex > index && !char.IsWhiteSpace(text[endIndex - 1]))
                    {
                        endIndex--;
                    }
                }

                formattedText.Append(text.Substring(index, endIndex - index).Trim());

                if (endIndex < text.Length)
                {
                    formattedText.AppendLine();
                }
                    
                index = endIndex;
            }

            return formattedText.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelName.Text = string.Empty;
            labelYear.Text = string.Empty;
            labelGenres.Text = string.Empty;
            labelDescription.Text = string.Empty;

            picturePoster.Image = Resources.default_image;

            buttonSearch.Enabled = true;

            mainGroupBox.Visible = false;
            mainGroupBox.Enabled = false;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name is empty!");
                return;
            }

            string request = $"http://www.omdbapi.com/?t={textBoxName.Text}";

            if(textBoxYear.Text.Length != 0)
            {
                int year = int.Parse(textBoxYear.Text);
                request += $"&y={year}";
            }

            if(comboBoxType.SelectedIndex != -1)
            {
                string str = (string)comboBoxType.Items[comboBoxType.SelectedIndex];
                string result = char.ToLower(str[0]) + str.Substring(1);
                request += $"&type={result}";
            }
            request += API_KEY;

            bool status = await DisplayMovieDetails(request);

            if(status)
            {
                buttonSearch.Enabled = false;

                mainGroupBox.Enabled = true;
                mainGroupBox.Visible = true;
            }
        }

        private async Task<bool> DisplayMovieDetails(string request)
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(request);

                    string body = await response.Content.ReadAsStringAsync();

                    if (body.Contains("Movie not found!") || body.Contains("Error"))
                    {
                        MessageBox.Show("Movie not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else
                    {
                        JObject json = JObject.Parse(body);

                        labelName.Text = json["Title"].ToString();
                        labelYear.Text = json["Year"].ToString();
                        labelGenres.Text = json["Genre"].ToString();

                        labelDescription.Text = TextFormatting(json["Plot"].ToString(), 40);

                        string posterUrl = json["Poster"].ToString();

                        picturePoster.Load(posterUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return true;
        }
    }
}
