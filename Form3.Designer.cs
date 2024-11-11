namespace StarCounter
{
    partial class Form_about
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_about));
            About = new Label();
            pictureBox_about_logo = new PictureBox();
            pictureBox_about_kofi = new PictureBox();
            textBox_about_credits = new TextBox();
            button_about_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_about_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_about_kofi).BeginInit();
            SuspendLayout();
            // 
            // About
            // 
            About.AutoSize = true;
            About.Font = new Font("Super Mario 256", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            About.Location = new Point(12, 19);
            About.MaximumSize = new Size(220, 0);
            About.Name = "About";
            About.Size = new Size(211, 44);
            About.TabIndex = 0;
            About.Text = "SM64 Star- and Deathcounter";
            // 
            // pictureBox_about_logo
            // 
            pictureBox_about_logo.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_about_logo.Image = (Image)resources.GetObject("pictureBox_about_logo.Image");
            pictureBox_about_logo.Location = new Point(12, 78);
            pictureBox_about_logo.Name = "pictureBox_about_logo";
            pictureBox_about_logo.Size = new Size(88, 90);
            pictureBox_about_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_about_logo.TabIndex = 2;
            pictureBox_about_logo.TabStop = false;
            pictureBox_about_logo.Click += pictureBox_logo_Click;
            // 
            // pictureBox_about_kofi
            // 
            pictureBox_about_kofi.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_about_kofi.Image = (Image)resources.GetObject("pictureBox_about_kofi.Image");
            pictureBox_about_kofi.Location = new Point(12, 222);
            pictureBox_about_kofi.Name = "pictureBox_about_kofi";
            pictureBox_about_kofi.Size = new Size(88, 90);
            pictureBox_about_kofi.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_about_kofi.TabIndex = 3;
            pictureBox_about_kofi.TabStop = false;
            pictureBox_about_kofi.Click += pictureBox_kofi_Click;
            // 
            // textBox_about_credits
            // 
            textBox_about_credits.BorderStyle = BorderStyle.FixedSingle;
            textBox_about_credits.Location = new Point(106, 78);
            textBox_about_credits.Multiline = true;
            textBox_about_credits.Name = "textBox_about_credits";
            textBox_about_credits.ReadOnly = true;
            textBox_about_credits.Size = new Size(253, 234);
            textBox_about_credits.TabIndex = 4;
            textBox_about_credits.Text = "Version: 1.0\r\n\r\nInspiration: FramePerfection\r\n\r\nDesign and Idea: MarvJungs\r\n\r\nHelp: ZenonX, aglab2 and LiveSplit\r\n\r\nFor More Information, please click on the Logo";
            // 
            // button_about_close
            // 
            button_about_close.Location = new Point(148, 355);
            button_about_close.Name = "button_about_close";
            button_about_close.Size = new Size(75, 23);
            button_about_close.TabIndex = 5;
            button_about_close.Text = "Close";
            button_about_close.UseVisualStyleBackColor = true;
            button_about_close.Click += button_about_close_Click;
            // 
            // Form_about
            // 
            AutoScaleDimensions = new SizeF(8F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 390);
            Controls.Add(button_about_close);
            Controls.Add(textBox_about_credits);
            Controls.Add(pictureBox_about_kofi);
            Controls.Add(pictureBox_about_logo);
            Controls.Add(About);
            Font = new Font("Super Mario 256", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_about";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox_about_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_about_kofi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label About;
        private PictureBox pictureBox_about_logo;
        private PictureBox pictureBox_about_kofi;
        private TextBox textBox_about_credits;
        private Button button_about_close;
    }
}