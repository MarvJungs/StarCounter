namespace StarCounter
{
    partial class Starcounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starcounter));
            pictureBox_star = new PictureBox();
            label_x_star = new Label();
            label_amountStars = new Label();
            timer_update = new System.Windows.Forms.Timer(components);
            pictureBox_death = new PictureBox();
            label_x_death = new Label();
            label_amountDeaths = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_death).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_star
            // 
            pictureBox_star.ErrorImage = null;
            pictureBox_star.Image = (Image)resources.GetObject("pictureBox_star.Image");
            pictureBox_star.InitialImage = null;
            pictureBox_star.Location = new Point(12, 86);
            pictureBox_star.Name = "pictureBox_star";
            pictureBox_star.Size = new Size(256, 256);
            pictureBox_star.TabIndex = 0;
            pictureBox_star.TabStop = false;
            // 
            // label_x_star
            // 
            label_x_star.Font = new Font("Segoe UI", 128F);
            label_x_star.Location = new Point(300, 86);
            label_x_star.Name = "label_x_star";
            label_x_star.Size = new Size(128, 256);
            label_x_star.TabIndex = 1;
            label_x_star.Text = "x";
            label_x_star.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_amountStars
            // 
            label_amountStars.Font = new Font("Segoe UI", 128F);
            label_amountStars.Location = new Point(453, 86);
            label_amountStars.Name = "label_amountStars";
            label_amountStars.Size = new Size(379, 256);
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
            pictureBox_death.Location = new Point(12, 395);
            pictureBox_death.Name = "pictureBox_death";
            pictureBox_death.Size = new Size(256, 256);
            pictureBox_death.TabIndex = 3;
            pictureBox_death.TabStop = false;
            // 
            // label_x_death
            // 
            label_x_death.Font = new Font("Segoe UI", 128F);
            label_x_death.Location = new Point(300, 395);
            label_x_death.Name = "label_x_death";
            label_x_death.Size = new Size(128, 256);
            label_x_death.TabIndex = 4;
            label_x_death.Text = "x";
            label_x_death.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_amountDeaths
            // 
            label_amountDeaths.Font = new Font("Segoe UI", 128F);
            label_amountDeaths.Location = new Point(443, 395);
            label_amountDeaths.Name = "label_amountDeaths";
            label_amountDeaths.Size = new Size(379, 256);
            label_amountDeaths.TabIndex = 5;
            label_amountDeaths.Text = "0";
            label_amountDeaths.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Starcounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 723);
            Controls.Add(label_amountDeaths);
            Controls.Add(label_x_death);
            Controls.Add(pictureBox_death);
            Controls.Add(label_amountStars);
            Controls.Add(label_x_star);
            Controls.Add(pictureBox_star);
            Name = "Starcounter";
            Text = "Starcounter";
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_death).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_star;
        private Label label_x_star;
        private Label label_amountStars;
        private System.Windows.Forms.Timer timer_update;
        private PictureBox pictureBox_death;
        private Label label_x_death;
        private Label label_amountDeaths;
    }
}
