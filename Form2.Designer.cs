namespace StarCounter
{
    partial class Form_settings
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
            label_settings_header = new Label();
            label_settings_stars = new Label();
            label_settings_deaths = new Label();
            label_settings_stars_show = new Label();
            label_settings_stars_amount = new Label();
            checkBox_settings_show_stars = new CheckBox();
            textBox_settings_stars_amount = new TextBox();
            label1 = new Label();
            checkBox_settings_show_deaths = new CheckBox();
            label2 = new Label();
            textBox_settings_amount_deaths = new TextBox();
            button_settings_apply = new Button();
            button_settings_ok = new Button();
            label3 = new Label();
            label_settings_layout = new Label();
            label4 = new Label();
            textBox_settings_fontsize = new TextBox();
            SuspendLayout();
            // 
            // label_settings_header
            // 
            label_settings_header.AutoSize = true;
            label_settings_header.Font = new Font("Super Mario 256", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_settings_header.Location = new Point(23, 13);
            label_settings_header.Name = "label_settings_header";
            label_settings_header.Size = new Size(139, 24);
            label_settings_header.TabIndex = 0;
            label_settings_header.Text = "Settings";
            // 
            // label_settings_stars
            // 
            label_settings_stars.AutoSize = true;
            label_settings_stars.Font = new Font("Super Mario 256", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_settings_stars.Location = new Point(23, 71);
            label_settings_stars.Name = "label_settings_stars";
            label_settings_stars.Size = new Size(79, 20);
            label_settings_stars.TabIndex = 1;
            label_settings_stars.Text = "Stars";
            // 
            // label_settings_deaths
            // 
            label_settings_deaths.AutoSize = true;
            label_settings_deaths.Font = new Font("Super Mario 256", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_settings_deaths.Location = new Point(17, 163);
            label_settings_deaths.Name = "label_settings_deaths";
            label_settings_deaths.Size = new Size(88, 20);
            label_settings_deaths.TabIndex = 2;
            label_settings_deaths.Text = "Deaths";
            // 
            // label_settings_stars_show
            // 
            label_settings_stars_show.AutoSize = true;
            label_settings_stars_show.Location = new Point(39, 103);
            label_settings_stars_show.Name = "label_settings_stars_show";
            label_settings_stars_show.Size = new Size(95, 13);
            label_settings_stars_show.TabIndex = 3;
            label_settings_stars_show.Text = "Show Stars";
            // 
            // label_settings_stars_amount
            // 
            label_settings_stars_amount.AutoSize = true;
            label_settings_stars_amount.Location = new Point(39, 125);
            label_settings_stars_amount.Name = "label_settings_stars_amount";
            label_settings_stars_amount.Size = new Size(115, 13);
            label_settings_stars_amount.TabIndex = 4;
            label_settings_stars_amount.Text = "Amount Stars";
            // 
            // checkBox_settings_show_stars
            // 
            checkBox_settings_show_stars.AutoSize = true;
            checkBox_settings_show_stars.Checked = true;
            checkBox_settings_show_stars.CheckState = CheckState.Checked;
            checkBox_settings_show_stars.Location = new Point(186, 102);
            checkBox_settings_show_stars.Name = "checkBox_settings_show_stars";
            checkBox_settings_show_stars.Size = new Size(15, 14);
            checkBox_settings_show_stars.TabIndex = 5;
            checkBox_settings_show_stars.UseVisualStyleBackColor = true;
            // 
            // textBox_settings_stars_amount
            // 
            textBox_settings_stars_amount.Font = new Font("Super Mario 256", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_settings_stars_amount.Location = new Point(186, 125);
            textBox_settings_stars_amount.MaxLength = 4;
            textBox_settings_stars_amount.Name = "textBox_settings_stars_amount";
            textBox_settings_stars_amount.Size = new Size(68, 19);
            textBox_settings_stars_amount.TabIndex = 6;
            textBox_settings_stars_amount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 199);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 7;
            label1.Text = "Show Deaths";
            // 
            // checkBox_settings_show_deaths
            // 
            checkBox_settings_show_deaths.AutoSize = true;
            checkBox_settings_show_deaths.Checked = true;
            checkBox_settings_show_deaths.CheckState = CheckState.Checked;
            checkBox_settings_show_deaths.Location = new Point(186, 199);
            checkBox_settings_show_deaths.Name = "checkBox_settings_show_deaths";
            checkBox_settings_show_deaths.Size = new Size(15, 14);
            checkBox_settings_show_deaths.TabIndex = 8;
            checkBox_settings_show_deaths.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 224);
            label2.Name = "label2";
            label2.Size = new Size(121, 13);
            label2.TabIndex = 9;
            label2.Text = "Amount Deaths";
            // 
            // textBox_settings_amount_deaths
            // 
            textBox_settings_amount_deaths.Location = new Point(186, 221);
            textBox_settings_amount_deaths.MaxLength = 4;
            textBox_settings_amount_deaths.Name = "textBox_settings_amount_deaths";
            textBox_settings_amount_deaths.Size = new Size(68, 19);
            textBox_settings_amount_deaths.TabIndex = 10;
            textBox_settings_amount_deaths.Text = "0";
            // 
            // button_settings_apply
            // 
            button_settings_apply.Location = new Point(122, 452);
            button_settings_apply.Name = "button_settings_apply";
            button_settings_apply.Size = new Size(132, 23);
            button_settings_apply.TabIndex = 11;
            button_settings_apply.Text = "Apply Settings";
            button_settings_apply.UseVisualStyleBackColor = true;
            button_settings_apply.Click += button_settings_apply_Click;
            // 
            // button_settings_ok
            // 
            button_settings_ok.Location = new Point(17, 452);
            button_settings_ok.Name = "button_settings_ok";
            button_settings_ok.Size = new Size(75, 23);
            button_settings_ok.TabIndex = 12;
            button_settings_ok.Text = "Ok";
            button_settings_ok.UseVisualStyleBackColor = true;
            button_settings_ok.Click += button_settings_ok_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Super Mario 256", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(17, 371);
            label3.MaximumSize = new Size(250, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 48);
            label3.TabIndex = 13;
            label3.Text = "Make sure to press \"Apply Settings\" when you are done!";
            // 
            // label_settings_layout
            // 
            label_settings_layout.AutoSize = true;
            label_settings_layout.Font = new Font("Super Mario 256", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_settings_layout.Location = new Point(23, 290);
            label_settings_layout.Name = "label_settings_layout";
            label_settings_layout.Size = new Size(90, 20);
            label_settings_layout.TabIndex = 14;
            label_settings_layout.Text = "Layout";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 324);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 15;
            label4.Text = "Fontsize";
            // 
            // textBox_settings_fontsize
            // 
            textBox_settings_fontsize.Location = new Point(186, 324);
            textBox_settings_fontsize.Name = "textBox_settings_fontsize";
            textBox_settings_fontsize.Size = new Size(68, 19);
            textBox_settings_fontsize.TabIndex = 16;
            textBox_settings_fontsize.Text = "128";
            // 
            // Form_settings
            // 
            AutoScaleDimensions = new SizeF(8F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 485);
            Controls.Add(textBox_settings_fontsize);
            Controls.Add(label4);
            Controls.Add(label_settings_layout);
            Controls.Add(label3);
            Controls.Add(button_settings_ok);
            Controls.Add(button_settings_apply);
            Controls.Add(textBox_settings_amount_deaths);
            Controls.Add(label2);
            Controls.Add(checkBox_settings_show_deaths);
            Controls.Add(label1);
            Controls.Add(textBox_settings_stars_amount);
            Controls.Add(checkBox_settings_show_stars);
            Controls.Add(label_settings_stars_amount);
            Controls.Add(label_settings_stars_show);
            Controls.Add(label_settings_deaths);
            Controls.Add(label_settings_stars);
            Controls.Add(label_settings_header);
            Font = new Font("Super Mario 256", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_settings_header;
        private Label label_settings_stars;
        private Label label_settings_deaths;
        private Label label_settings_stars_show;
        private Label label_settings_stars_amount;
        private CheckBox checkBox_settings_show_stars;
        private TextBox textBox_settings_stars_amount;
        private Label label1;
        private CheckBox checkBox_settings_show_deaths;
        private Label label2;
        private TextBox textBox_settings_amount_deaths;
        private Button button_settings_apply;
        private Button button_settings_ok;
        private Label label3;
        private Label label_settings_layout;
        private Label label4;
        private TextBox textBox_settings_fontsize;
    }
}