namespace FootballLeague
{
    partial class AddPlayer
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 27);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 27);
            textBox3.TabIndex = 2;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 67);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 120);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 176);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Team ID";
            // 
            // button1
            // 
            button1.Location = new Point(474, 249);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add Player";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(754, 12);
            button2.Name = "button2";
            button2.Size = new Size(34, 29);
            button2.TabIndex = 7;
            button2.Text = "<-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddPlayer";
            Text = "AddPlayer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}