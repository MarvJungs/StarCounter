namespace StarCounter
{
    partial class Form_starcounter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_starcounter));
            pictureBox_star = new PictureBox();
            label_x_star = new Label();
            label_amountStars = new Label();
            timer_update = new System.Windows.Forms.Timer(components);
            pictureBox_death = new PictureBox();
            label_x_death = new Label();
            label_amountDeaths = new Label();
            button_decrease_stars = new Button();
            button_increase_stars = new Button();
            button_reset_stars = new Button();
            button_decrease_deaths = new Button();
            button_reset_deaths = new Button();
            button_increase_deaths = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_death).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_star
            // 
            pictureBox_star.ErrorImage = null;
            pictureBox_star.Image = (Image)resources.GetObject("pictureBox_star.Image");
            pictureBox_star.InitialImage = null;
            pictureBox_star.Location = new Point(12, 83);
            pictureBox_star.Name = "pictureBox_star";
            pictureBox_star.Size = new Size(255, 255);
            pictureBox_star.TabIndex = 0;
            pictureBox_star.TabStop = false;
            // 
            // label_x_star
            // 
            label_x_star.Font = new Font("Super Mario 256", 128.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_x_star.Location = new Point(316, 162);
            label_x_star.Name = "label_x_star";
            label_x_star.Size = new Size(133, 176);
            label_x_star.TabIndex = 1;
            label_x_star.Text = "x";
            label_x_star.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_amountStars
            // 
            label_amountStars.Font = new Font("Super Mario 256", 128.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_amountStars.Location = new Point(520, 136);
            label_amountStars.Name = "label_amountStars";
            label_amountStars.Size = new Size(597, 222);
            label_amountStars.TabIndex = 2;
            label_amountStars.Text = "0";
            label_amountStars.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer_update
            // 
            timer_update.Tick += timer_update_Tick;
            // 
            // pictureBox_death
            // 
            pictureBox_death.Image = (Image)resources.GetObject("pictureBox_death.Image");
            pictureBox_death.Location = new Point(12, 373);
            pictureBox_death.Name = "pictureBox_death";
            pictureBox_death.Size = new Size(255, 256);
            pictureBox_death.TabIndex = 3;
            pictureBox_death.TabStop = false;
            // 
            // label_x_death
            // 
            label_x_death.Font = new Font("Super Mario 256", 128.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_x_death.Location = new Point(316, 418);
            label_x_death.Name = "label_x_death";
            label_x_death.Size = new Size(133, 177);
            label_x_death.TabIndex = 4;
            label_x_death.Text = "x";
            label_x_death.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_amountDeaths
            // 
            label_amountDeaths.Font = new Font("Super Mario 256", 128.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_amountDeaths.Location = new Point(520, 392);
            label_amountDeaths.Margin = new Padding(0, 0, 3, 0);
            label_amountDeaths.Name = "label_amountDeaths";
            label_amountDeaths.Size = new Size(597, 222);
            label_amountDeaths.TabIndex = 5;
            label_amountDeaths.Text = "0";
            label_amountDeaths.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_decrease_stars
            // 
            button_decrease_stars.BackColor = Color.Transparent;
            button_decrease_stars.BackgroundImage = (Image)resources.GetObject("button_decrease_stars.BackgroundImage");
            button_decrease_stars.BackgroundImageLayout = ImageLayout.Stretch;
            button_decrease_stars.ForeColor = SystemColors.ControlLight;
            button_decrease_stars.Location = new Point(12, 38);
            button_decrease_stars.Name = "button_decrease_stars";
            button_decrease_stars.Size = new Size(60, 28);
            button_decrease_stars.TabIndex = 6;
            button_decrease_stars.UseVisualStyleBackColor = false;
            button_decrease_stars.Click += button_decrease_stars_Click;
            // 
            // button_increase_stars
            // 
            button_increase_stars.BackgroundImage = (Image)resources.GetObject("button_increase_stars.BackgroundImage");
            button_increase_stars.BackgroundImageLayout = ImageLayout.Stretch;
            button_increase_stars.ImageAlign = ContentAlignment.TopLeft;
            button_increase_stars.Location = new Point(227, 38);
            button_increase_stars.Name = "button_increase_stars";
            button_increase_stars.Size = new Size(40, 28);
            button_increase_stars.TabIndex = 7;
            button_increase_stars.UseVisualStyleBackColor = true;
            button_increase_stars.Click += button_increase_stars_Click;
            // 
            // button_reset_stars
            // 
            button_reset_stars.BackColor = SystemColors.ControlLight;
            button_reset_stars.ForeColor = SystemColors.ActiveCaptionText;
            button_reset_stars.Location = new Point(111, 38);
            button_reset_stars.Name = "button_reset_stars";
            button_reset_stars.Size = new Size(75, 28);
            button_reset_stars.TabIndex = 8;
            button_reset_stars.Text = "Reset";
            button_reset_stars.UseVisualStyleBackColor = false;
            button_reset_stars.Click += button_reset_stars_Click;
            // 
            // button_decrease_deaths
            // 
            button_decrease_deaths.BackColor = Color.Transparent;
            button_decrease_deaths.BackgroundImage = (Image)resources.GetObject("button_decrease_deaths.BackgroundImage");
            button_decrease_deaths.BackgroundImageLayout = ImageLayout.Stretch;
            button_decrease_deaths.Location = new Point(12, 649);
            button_decrease_deaths.Name = "button_decrease_deaths";
            button_decrease_deaths.Size = new Size(60, 28);
            button_decrease_deaths.TabIndex = 9;
            button_decrease_deaths.UseVisualStyleBackColor = false;
            button_decrease_deaths.Click += button_decrease_deaths_Click;
            // 
            // button_reset_deaths
            // 
            button_reset_deaths.BackColor = SystemColors.ControlLight;
            button_reset_deaths.ForeColor = SystemColors.ActiveCaptionText;
            button_reset_deaths.Location = new Point(111, 649);
            button_reset_deaths.Name = "button_reset_deaths";
            button_reset_deaths.Size = new Size(75, 28);
            button_reset_deaths.TabIndex = 10;
            button_reset_deaths.Text = "Reset";
            button_reset_deaths.UseVisualStyleBackColor = false;
            button_reset_deaths.Click += button_reset_deaths_Click;
            // 
            // button_increase_deaths
            // 
            button_increase_deaths.BackgroundImage = (Image)resources.GetObject("button_increase_deaths.BackgroundImage");
            button_increase_deaths.BackgroundImageLayout = ImageLayout.Stretch;
            button_increase_deaths.ImageAlign = ContentAlignment.TopLeft;
            button_increase_deaths.Location = new Point(227, 649);
            button_increase_deaths.Name = "button_increase_deaths";
            button_increase_deaths.Size = new Size(40, 28);
            button_increase_deaths.TabIndex = 11;
            button_increase_deaths.UseVisualStyleBackColor = true;
            button_increase_deaths.Click += button_increase_deaths_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1139, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // Form_starcounter
            // 
            AutoScaleDimensions = new SizeF(8F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1139, 689);
            Controls.Add(button_increase_deaths);
            Controls.Add(button_reset_deaths);
            Controls.Add(button_decrease_deaths);
            Controls.Add(button_reset_stars);
            Controls.Add(button_increase_stars);
            Controls.Add(button_decrease_stars);
            Controls.Add(label_amountDeaths);
            Controls.Add(label_x_death);
            Controls.Add(pictureBox_death);
            Controls.Add(label_amountStars);
            Controls.Add(label_x_star);
            Controls.Add(pictureBox_star);
            Controls.Add(menuStrip1);
            Font = new Font("Super Mario 256", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form_starcounter";
            Text = "SM64 Stars- and Deathscounter";
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_death).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_star;
        private Label label_x_star;
        private System.Windows.Forms.Timer timer_update;
        private PictureBox pictureBox_death;
        private Label label_x_death;
        private Button button_decrease_stars;
        private Button button_increase_stars;
        private Button button_reset_stars;
        private Button button_decrease_deaths;
        private Button button_reset_deaths;
        private Button button_increase_deaths;
        public Label label_amountStars;
        public Label label_amountDeaths;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
