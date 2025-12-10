namespace AdminNewInterface
{
    partial class AdminForm
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
            Button search;
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            read = new Button();
            Insert = new Button();
            label2 = new Label();
            label3 = new Label();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightGreen;
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(read);
            splitContainer1.Panel1.Controls.Add(Insert);
            splitContainer1.Panel1.Controls.Add(search);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Honeydew;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(921, 521);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Olive;
            button3.Location = new Point(12, 414);
            button3.Name = "button3";
            button3.Size = new Size(233, 64);
            button3.TabIndex = 8;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Olive;
            button2.Location = new Point(12, 344);
            button2.Name = "button2";
            button2.Size = new Size(233, 64);
            button2.TabIndex = 7;
            button2.Text = "Go to Match";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Olive;
            button1.Location = new Point(12, 274);
            button1.Name = "button1";
            button1.Size = new Size(233, 64);
            button1.TabIndex = 6;
            button1.Text = "Add Player";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // read
            // 
            read.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            read.ForeColor = Color.Olive;
            read.Location = new Point(12, 204);
            read.Name = "read";
            read.Size = new Size(233, 64);
            read.TabIndex = 3;
            read.Text = "Show all teams";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // Insert
            // 
            Insert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Insert.ForeColor = Color.Olive;
            Insert.Location = new Point(12, 129);
            Insert.Name = "Insert";
            Insert.Size = new Size(233, 64);
            Insert.TabIndex = 2;
            Insert.Text = "Add New Team";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // search
            // 
            search.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.ForeColor = Color.Olive;
            search.Location = new Point(12, 59);
            search.Name = "search";
            search.Size = new Size(233, 64);
            search.TabIndex = 1;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(72, 187);
            label2.Name = "label2";
            label2.Size = new Size(462, 81);
            label2.TabIndex = 0;
            label2.Text = "Welcome Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(39, 20);
            label3.Name = "label3";
            label3.Size = new Size(162, 22);
            label3.TabIndex = 9;
            label3.Text = "Select Your Choice";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 521);
            Controls.Add(splitContainer1);
            Name = "AdminForm";
            Text = "Form1";
            FormClosed += AdminForm_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button search;
        private Button Insert;
        private Button read;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}
