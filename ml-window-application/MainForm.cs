using Ml_dex_industrial_intership;

namespace ml_window_application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyDigitsFiter(sender, e);
        }

        private void EpisodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyDigitsFiter(sender, e);
        }

        private void MembersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyDigitsFiter(sender, e);
        }

        private void ExpectedValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyNumbersFiter(sender, e, ExpectedValue.Text);
        }

        private void GenreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyLettersFiter(sender, e);
        }

        private void GenresLayoutPanel_Click(object sender, EventArgs e)
        {
            GenreTextBox.Focus();
        }

        private void GenreTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // If Enter is pressed, replace the TextBox with a Label showing the genre text
            if (e.KeyChar == (char)Keys.Enter && (sender as TextBox).Text != "")
            {
                TextBox GenreTextBox = sender as TextBox;
                GenresLayoutPanel.Controls.Remove(GenreTextBox);
                GenresLayoutPanel.Controls.Add(new Label
                {
                    Text = GenreTextBox.Text,
                    AutoSize = true,
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray,
                    Font = new Font(GenreTextBox.Font, FontStyle.Regular)
                });
                CreateNewGenreTextBox(GenreTextBox);
                GenreTextBox.Dispose();
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                // If backspace is pressed, remove the last genre TextBox if it exists
                int tbIndex = GenresLayoutPanel.Controls.Count - 1;
                if (GenresLayoutPanel.Controls.Count > 0 && (GenresLayoutPanel.Controls[tbIndex] as TextBox).Text == "")
                {
                    string tempText = "";
                    TextBox lastTextBox = GenresLayoutPanel.Controls[GenresLayoutPanel.Controls.Count - 1] as TextBox;
                    GenresLayoutPanel.Controls.Remove(lastTextBox);
                    if (GenresLayoutPanel.Controls.Count > 0 && GenresLayoutPanel.Controls[GenresLayoutPanel.Controls.Count - 1] is Label)
                    {
                        int lIndex = GenresLayoutPanel.Controls.Count - 1;
                        tempText = (GenresLayoutPanel.Controls[lIndex] as Label).Text;
                        GenresLayoutPanel.Controls.RemoveAt(lIndex);
                    }
                    CreateNewGenreTextBox(lastTextBox, tempText);
                    lastTextBox.Dispose();
                    e.Handled = true;

                }
            }

            else if (e.KeyChar == (char)Keys.Escape)
            {
                TextBox GenreTextBox = sender as TextBox;
                GenresLayoutPanel.Controls.Remove(GenreTextBox);
                e.Handled = true;
            }
            else
            {
                e.Handled = OnlyLettersFiter(sender, e);
            }
        }

        private void PredictButton_Click(object sender, EventArgs e)
        {
            if (!CheckRequiredFields()) return;

            string name = NameTexBox.Text.Trim();
            List<string> genresList = new List<string>();
            genresList.AddRange(GenresLayoutPanel.Controls.OfType<Label>().Select(l => l.Text.Trim()));
            genresList.Sort();
            string genres = string.Join(", ", genresList);
            string type = TypeComboBox.SelectedItem?.ToString() ?? string.Empty;
            float episodes = float.Parse(EpisodeTextBox.Text.Trim());
            float members = float.Parse(MembersTextBox.Text.Trim());


            PredictedValue.Text = PredictRating(name, genres, type, episodes, members).ToString("F2");

        }

    }
}
