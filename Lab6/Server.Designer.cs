namespace Lab6
{
    partial class Server
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 39);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Quầy A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 39);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Quầy B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 39);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 0;
            label3.Text = "Quầy C";
            // 
            // button1
            // 
            button1.Location = new Point(44, 71);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Khoá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 121);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Mở khoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 71);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "Khoá";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(304, 121);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "Mở khoá";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(571, 80);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 1;
            button5.Text = "Khoá";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(571, 130);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 1;
            button6.Text = "Mở khoá";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(304, 199);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 2;
            button7.Text = "Listen";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(44, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(621, 225);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 498);
            Controls.Add(richTextBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RichTextBox richTextBox1;
    }
}