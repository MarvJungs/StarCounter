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
            pictureBox_star = new PictureBox();
            label_x = new Label();
            label_amountStars = new Label();
            timer_update = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_star
            // 
            pictureBox_star.ErrorImage = null;
            pictureBox_star.Image = Properties.Resources.Star2;
            pictureBox_star.InitialImage = null;
            pictureBox_star.Location = new Point(12, 86);
            pictureBox_star.Name = "pictureBox_star";
            pictureBox_star.Size = new Size(256, 256);
            pictureBox_star.TabIndex = 0;
            pictureBox_star.TabStop = false;
            // 
            // label_x
            // 
            label_x.Font = new Font("Segoe UI", 128F);
            label_x.Location = new Point(300, 86);
            label_x.Name = "label_x";
            label_x.Size = new Size(128, 256);
            label_x.TabIndex = 1;
            label_x.Text = "x";
            label_x.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_amountStars
            // 
            label_amountStars.Font = new Font("Segoe UI", 128F);
            label_amountStars.Location = new Point(453, 86);
            label_amountStars.Name = "label_amountStars";
            label_amountStars.Size = new Size(379, 256);
            label_amountStars.TabIndex = 2;
            label_amountStars.Text = "0";
            label_amountStars.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer_update
            // 
            timer_update.Tick += timer_update_Tick;
            // 
            // Starcounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(label_amountStars);
            Controls.Add(label_x);
            Controls.Add(pictureBox_star);
            Name = "Starcounter";
            Text = "Starcounter";
            ((System.ComponentModel.ISupportInitialize)pictureBox_star).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_star;
        private Label label_x;
        private Label label_amountStars;
        private System.Windows.Forms.Timer timer_update;
    }
}
