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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchForm));
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
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Honeydew;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(231, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 20);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(231, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(201, 22);
            label1.TabIndex = 2;
            label1.Text = "Enter ID for First Team:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(3, 200);
            label2.Name = "label2";
            label2.Size = new Size(222, 22);
            label2.TabIndex = 3;
            label2.Text = "Enter ID for Second Team:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(489, 122);
            label3.Name = "label3";
            label3.Size = new Size(153, 22);
            label3.TabIndex = 5;
            label3.Text = "First Team Goals:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Honeydew;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(650, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 20);
            textBox3.TabIndex = 4;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(476, 201);
            label4.Name = "label4";
            label4.Size = new Size(174, 22);
            label4.TabIndex = 7;
            label4.Text = "Second Team Goals:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Honeydew;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(650, 202);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 20);
            textBox4.TabIndex = 6;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOliveGreen;
            button1.Location = new Point(134, 285);
            button1.Name = "button1";
            button1.Size = new Size(158, 53);
            button1.TabIndex = 8;
            button1.Text = "Save Results";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkOliveGreen;
            button2.Location = new Point(500, 285);
            button2.Name = "button2";
            button2.Size = new Size(142, 53);
            button2.TabIndex = 9;
            button2.Text = "Randomize Goals";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkKhaki;
            button3.Location = new Point(12, 394);
            button3.Name = "button3";
            button3.Size = new Size(78, 29);
            button3.TabIndex = 10;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(287, 25);
            label5.Name = "label5";
            label5.Size = new Size(204, 50);
            label5.TabIndex = 11;
            label5.Text = "New Match";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Viner Hand ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(220, 380);
            label6.Name = "label6";
            label6.Size = new Size(327, 24);
            label6.TabIndex = 12;
            label6.Text = "With our congratulations for the winner team";
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 435);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
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
            FormClosed += MatchForm_FormClosed;
            Load += MatchForm_Load;
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
        private Button button3;
        private Label label5;
        private Label label6;
    }
}
