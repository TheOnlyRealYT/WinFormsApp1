namespace FootballLeague
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(105, 343);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 0;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 270);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 1;
            button2.Text = "Guest Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 147);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 2;
            label1.Text = "Enter Your ID :";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(58, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 20);
            textBox2.TabIndex = 5;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 232);
            label2.Name = "label2";
            label2.Size = new Size(140, 17);
            label2.TabIndex = 4;
            label2.Text = "Enter Your Password :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_12_10_at_4_30_09_PM;
            pictureBox1.Location = new Point(377, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(58, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 20);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OliveDrab;
            label3.Location = new Point(113, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 60);
            label3.TabIndex = 7;
            label3.Text = "LogIn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(105, 86);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 8;
            label4.Text = "To your account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}