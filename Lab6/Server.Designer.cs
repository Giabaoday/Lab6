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
            button7 = new Button();
            richTextBox1 = new RichTextBox();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
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
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(738, 58);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(380, 422);
            checkedListBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(738, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Khoá";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1024, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Mở khoá";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 498);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button7);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
        }

        #endregion
        private Button button7;
        private RichTextBox richTextBox1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
    }
}