namespace ml_window_application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // filter to allow only digits in the textbox
        private bool OnlyDigitsFiter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            return false;
        }

        // filter to allow only numbers in the textbox
        private bool OnlyNumbersFiter(object sender, KeyPressEventArgs e, string Text)
        {
            bool isHandled = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                isHandled = true;
            }

            if ((e.KeyChar == ',') && (ExpectedValue.Text.Contains(',')))
            {
                isHandled = true;
            }

            return isHandled;
        }

        // filter to allow only letters in the textbox
        private bool OnlyLettersFiter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                return true;
            }
            return false;
        }

        // Create a new genre TextBox and add it to the GenresLayoutPanel
        private void CreateNewGenreTextBox(TextBox oldTextbox, string Text = "")
        {
            TextBox newTextBox = CopyTextBox(oldTextbox);
            newTextBox.Text = Text;
            GenresLayoutPanel.Controls.Add(newTextBox);
            newTextBox.Focus();
        }

        // Copy Constructor for a TextBox
        private TextBox CopyTextBox(TextBox original)
        {
            TextBox copy = new TextBox();

            copy.Size = original.Size;
            copy.Location = original.Location; // Обычно Location не копируем, тк будет добавлен в другой контейнер
            copy.Font = original.Font;
            copy.ForeColor = original.ForeColor;
            copy.BackColor = original.BackColor;
            copy.TextAlign = original.TextAlign;
            copy.Multiline = original.Multiline;
            copy.ScrollBars = original.ScrollBars;
            copy.ReadOnly = original.ReadOnly;
            copy.Enabled = original.Enabled;
            copy.Visible = original.Visible;
            copy.MaxLength = original.MaxLength;
            copy.WordWrap = original.WordWrap;
            copy.BorderStyle = original.BorderStyle;
            copy.Margin = original.Margin;
            copy.Padding = original.Padding;
            copy.KeyPress += GenreTextBox_KeyPress_1;
            return copy;
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
    }
}
