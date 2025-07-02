using Ml_dex_industrial_intership;
using System.Xml.Linq;

namespace ml_window_application
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PredictButton = new Button();
            AnimeNameLabel = new Label();
            AnimeIdLabel = new Label();
            AnimeGenreLabel = new Label();
            AnimeTypeLabel = new Label();
            AnimeEpisodesLabel = new Label();
            AnimeMembersLabel = new Label();
            panel1 = new Panel();
            GenresLayoutPanel = new FlowLayoutPanel();
            GenreTextBox = new TextBox();
            TypeComboBox = new ComboBox();
            EpisodeTextBox = new TextBox();
            NameTexBox = new TextBox();
            IdTextBox = new TextBox();
            MembersTextBox = new TextBox();
            panel2 = new Panel();
            PredictedValue = new Label();
            ExpectedValue = new TextBox();
            RatingLabel = new Label();
            PredictedRatingLabel = new Label();
            AnimeRatingLabel = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            GenresLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PredictButton
            // 
            PredictButton.BackColor = SystemColors.ControlLight;
            PredictButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PredictButton.Location = new Point(679, 88);
            PredictButton.Name = "PredictButton";
            PredictButton.Size = new Size(174, 43);
            PredictButton.TabIndex = 0;
            PredictButton.Text = "Предсказать";
            PredictButton.UseVisualStyleBackColor = false;
            PredictButton.Click += PredictButton_Click;
            // 
            // AnimeNameLabel
            // 
            AnimeNameLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeNameLabel.Location = new Point(13, 51);
            AnimeNameLabel.Name = "AnimeNameLabel";
            AnimeNameLabel.Size = new Size(239, 30);
            AnimeNameLabel.TabIndex = 1;
            AnimeNameLabel.Text = "Имя:";
            // 
            // AnimeIdLabel
            // 
            AnimeIdLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeIdLabel.Location = new Point(13, 13);
            AnimeIdLabel.Name = "AnimeIdLabel";
            AnimeIdLabel.Size = new Size(239, 30);
            AnimeIdLabel.TabIndex = 2;
            AnimeIdLabel.Text = "ID (не обязательно):";
            // 
            // AnimeGenreLabel
            // 
            AnimeGenreLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeGenreLabel.Location = new Point(13, 91);
            AnimeGenreLabel.Name = "AnimeGenreLabel";
            AnimeGenreLabel.Size = new Size(239, 30);
            AnimeGenreLabel.TabIndex = 3;
            AnimeGenreLabel.Text = "Жанр(ы):";
            // 
            // AnimeTypeLabel
            // 
            AnimeTypeLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeTypeLabel.Location = new Point(13, 153);
            AnimeTypeLabel.Name = "AnimeTypeLabel";
            AnimeTypeLabel.Size = new Size(239, 30);
            AnimeTypeLabel.TabIndex = 4;
            AnimeTypeLabel.Text = "Тип:";
            // 
            // AnimeEpisodesLabel
            // 
            AnimeEpisodesLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeEpisodesLabel.Location = new Point(13, 191);
            AnimeEpisodesLabel.Name = "AnimeEpisodesLabel";
            AnimeEpisodesLabel.Size = new Size(239, 30);
            AnimeEpisodesLabel.TabIndex = 5;
            AnimeEpisodesLabel.Text = "Эпизоды:";
            // 
            // AnimeMembersLabel
            // 
            AnimeMembersLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeMembersLabel.Location = new Point(13, 229);
            AnimeMembersLabel.Name = "AnimeMembersLabel";
            AnimeMembersLabel.Size = new Size(239, 30);
            AnimeMembersLabel.TabIndex = 6;
            AnimeMembersLabel.Text = "Просмотры:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(GenresLayoutPanel);
            panel1.Controls.Add(TypeComboBox);
            panel1.Controls.Add(EpisodeTextBox);
            panel1.Controls.Add(NameTexBox);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(AnimeIdLabel);
            panel1.Controls.Add(AnimeMembersLabel);
            panel1.Controls.Add(AnimeNameLabel);
            panel1.Controls.Add(AnimeEpisodesLabel);
            panel1.Controls.Add(AnimeGenreLabel);
            panel1.Controls.Add(AnimeTypeLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 303);
            panel1.TabIndex = 7;
            // 
            // GenresLayoutPanel
            // 
            GenresLayoutPanel.AutoScroll = true;
            GenresLayoutPanel.BackColor = SystemColors.Window;
            GenresLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            GenresLayoutPanel.Controls.Add(GenreTextBox);
            GenresLayoutPanel.Location = new Point(110, 89);
            GenresLayoutPanel.Name = "GenresLayoutPanel";
            GenresLayoutPanel.Padding = new Padding(0, 2, 0, 0);
            GenresLayoutPanel.Size = new Size(352, 58);
            GenresLayoutPanel.TabIndex = 12;
            GenresLayoutPanel.WrapContents = false;
            GenresLayoutPanel.Click += GenresLayoutPanel_Click;
            // 
            // GenreTextBox
            // 
            GenreTextBox.BackColor = SystemColors.Window;
            GenreTextBox.BorderStyle = BorderStyle.None;
            GenreTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenreTextBox.Location = new Point(3, 5);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(138, 22);
            GenreTextBox.TabIndex = 0;
            GenreTextBox.KeyPress += GenreTextBox_KeyPress_1;
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.Font = new Font("Segoe UI", 14.25F);
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Movie", "OVA", "TV" });
            TypeComboBox.Location = new Point(258, 153);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(204, 33);
            TypeComboBox.TabIndex = 10;
            // 
            // EpisodeTextBox
            // 
            EpisodeTextBox.Font = new Font("Segoe UI", 14.25F);
            EpisodeTextBox.Location = new Point(258, 191);
            EpisodeTextBox.Name = "EpisodeTextBox";
            EpisodeTextBox.Size = new Size(204, 33);
            EpisodeTextBox.TabIndex = 11;
            EpisodeTextBox.KeyPress += EpisodeTextBox_KeyPress;
            // 
            // NameTexBox
            // 
            NameTexBox.Font = new Font("Segoe UI", 14.25F);
            NameTexBox.Location = new Point(258, 51);
            NameTexBox.Name = "NameTexBox";
            NameTexBox.Size = new Size(204, 33);
            NameTexBox.TabIndex = 8;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 14.25F);
            IdTextBox.Location = new Point(258, 13);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(204, 33);
            IdTextBox.TabIndex = 7;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // MembersTextBox
            // 
            MembersTextBox.Font = new Font("Segoe UI", 14.25F);
            MembersTextBox.Location = new Point(270, 241);
            MembersTextBox.Name = "MembersTextBox";
            MembersTextBox.Size = new Size(204, 33);
            MembersTextBox.TabIndex = 8;
            MembersTextBox.KeyPress += MembersTextBox_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(PredictedValue);
            panel2.Controls.Add(ExpectedValue);
            panel2.Controls.Add(RatingLabel);
            panel2.Controls.Add(PredictedRatingLabel);
            panel2.Controls.Add(PredictButton);
            panel2.Controls.Add(AnimeRatingLabel);
            panel2.Location = new Point(12, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 143);
            panel2.TabIndex = 9;
            // 
            // PredictedValue
            // 
            PredictedValue.BackColor = SystemColors.ButtonHighlight;
            PredictedValue.BorderStyle = BorderStyle.FixedSingle;
            PredictedValue.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PredictedValue.Location = new Point(332, 88);
            PredictedValue.Name = "PredictedValue";
            PredictedValue.Size = new Size(130, 30);
            PredictedValue.TabIndex = 15;
            PredictedValue.Text = "0,00";
            // 
            // ExpectedValue
            // 
            ExpectedValue.Font = new Font("Cascadia Code", 14.25F);
            ExpectedValue.Location = new Point(332, 50);
            ExpectedValue.Name = "ExpectedValue";
            ExpectedValue.Size = new Size(130, 30);
            ExpectedValue.TabIndex = 14;
            ExpectedValue.KeyPress += ExpectedValue_KeyPress;
            // 
            // RatingLabel
            // 
            RatingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RatingLabel.Location = new Point(405, 0);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(93, 30);
            RatingLabel.TabIndex = 12;
            RatingLabel.Text = "Рейтинг";
            RatingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PredictedRatingLabel
            // 
            PredictedRatingLabel.Font = new Font("Segoe UI", 14.25F);
            PredictedRatingLabel.Location = new Point(13, 88);
            PredictedRatingLabel.Name = "PredictedRatingLabel";
            PredictedRatingLabel.Size = new Size(239, 30);
            PredictedRatingLabel.TabIndex = 13;
            PredictedRatingLabel.Text = "Предсказанный:";
            // 
            // AnimeRatingLabel
            // 
            AnimeRatingLabel.Font = new Font("Segoe UI", 14.25F);
            AnimeRatingLabel.Location = new Point(13, 50);
            AnimeRatingLabel.Name = "AnimeRatingLabel";
            AnimeRatingLabel.Size = new Size(313, 30);
            AnimeRatingLabel.TabIndex = 12;
            AnimeRatingLabel.Text = "Ожидаемый (не обязательно):";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 14F);
            richTextBox1.Location = new Point(510, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(368, 303);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Для более точный предсказаний настоятельно рекомендуется использование латинского алфавита и английского перевода жанров. Перечисляемые жанры разделяются клавишей ввода (\"Enter\")";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 485);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(MembersTextBox);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Предсказание рейтинга аниме";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            GenresLayoutPanel.ResumeLayout(false);
            GenresLayoutPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PredictButton;
        private Label AnimeNameLabel;
        private Label AnimeIdLabel;
        private Label AnimeGenreLabel;
        private Label AnimeTypeLabel;
        private Label AnimeEpisodesLabel;
        private Label AnimeMembersLabel;
        private Panel panel1;
        private TextBox EpisodeTextBox;
        private TextBox NameTexBox;
        private TextBox IdTextBox;
        private TextBox MembersTextBox;
        private Panel panel2;
        private Label RatingLabel;
        private TextBox ExpectedValue;
        private Label PredictedRatingLabel;
        private Label AnimeRatingLabel;
        private Label PredictedValue;
        private ComboBox TypeComboBox;
        private RichTextBox richTextBox1;
        private FlowLayoutPanel GenresLayoutPanel;
        private TextBox GenreTextBox;

        #region Event Handlers

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

        private bool CheckRequiredFields()
        {
            // Check if the required fields are filled
            if (string.IsNullOrWhiteSpace(NameTexBox.Text) || string.IsNullOrWhiteSpace(TypeComboBox.Text) ||
                string.IsNullOrWhiteSpace(EpisodeTextBox.Text) || string.IsNullOrWhiteSpace(MembersTextBox.Text) ||
                GenresLayoutPanel.Controls.OfType<Label>().Count() == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private float PredictRating(
            string name,
            string genres,
            string type,
            float episodes,
            float members
            )
        {
            //Load sample data
            var sampleData = new MLAnimeRatingPredictor.ModelInput()
            {
                Name = name,
                Genre = genres,
                Type = type,
                Episodes = episodes,
                Members = members,
            };

            //Load model and predict output
            var result = MLAnimeRatingPredictor.Predict(sampleData);
            return result.Score;
        }
        #endregion
    }
}
