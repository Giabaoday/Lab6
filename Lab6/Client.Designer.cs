namespace Lab6
{
    partial class Client
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
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(40, 24);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(569, 290);
            checkedListBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(40, 362);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(637, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(637, 362);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(45, 422);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(731, 76);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}