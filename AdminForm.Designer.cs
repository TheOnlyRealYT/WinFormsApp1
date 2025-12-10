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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            read = new Button();
            Insert = new Button();
            search = new Button();
            open = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
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
            splitContainer1.Panel1.BackColor = Color.MistyRose;
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(read);
            splitContainer1.Panel1.Controls.Add(Insert);
            splitContainer1.Panel1.Controls.Add(search);
            splitContainer1.Panel1.Controls.Add(open);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(921, 521);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 0;
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
            read.Location = new Point(3, 290);
            read.Name = "read";
            read.Size = new Size(253, 95);
            read.TabIndex = 3;
            read.Text = "Show all teams";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // Insert
            // 
            Insert.Location = new Point(0, 197);
            Insert.Name = "Insert";
            Insert.Size = new Size(256, 99);
            Insert.TabIndex = 2;
            Insert.Text = "Add New Team";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // search
            // 
            search.Location = new Point(0, 99);
            search.Name = "search";
            search.Size = new Size(256, 105);
            search.TabIndex = 1;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // open
            // 
            open.Location = new Point(0, 3);
            open.Name = "open";
            open.Size = new Size(256, 100);
            open.TabIndex = 0;
            open.Text = "open";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 376);
            button1.Name = "button1";
            button1.Size = new Size(256, 44);
            button1.TabIndex = 6;
            button1.Text = "Add Player";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(0, 419);
            button2.Name = "button2";
            button2.Size = new Size(256, 43);
            button2.TabIndex = 7;
            button2.Text = "Go to Match";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(0, 459);
            button3.Name = "button3";
            button3.Size = new Size(256, 59);
            button3.TabIndex = 8;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(72, 187);
            label2.Name = "label2";
            label2.Size = new Size(462, 81);
            label2.TabIndex = 0;
            label2.Text = "Welcome Admin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 521);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
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
        private Button open;
        private Button search;
        private Button Insert;
        private Button read;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
    }
}
