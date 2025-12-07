namespace WinFormsApp1
{
    partial class MatchForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(479, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 84);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Team One ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Team Two ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 171);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 5;
            label3.Text = "Team One Goals";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 27);
            textBox3.TabIndex = 4;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 171);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 7;
            label4.Text = "Team Two Goals";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(553, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 27);
            textBox4.TabIndex = 6;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(199, 256);
            button1.Name = "button1";
            button1.Size = new Size(130, 41);
            button1.TabIndex = 8;
            button1.Text = "Save Results";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 256);
            button2.Name = "button2";
            button2.Size = new Size(142, 41);
            button2.TabIndex = 9;
            button2.Text = "Randomize Goals";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 435);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MatchForm";
            Text = "Match Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}
