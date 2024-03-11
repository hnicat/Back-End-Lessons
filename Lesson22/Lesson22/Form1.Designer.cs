namespace Lesson22
{
    partial class Form1
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
            BtnBrans = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // BtnBrans
            // 
            BtnBrans.Location = new Point(30, 114);
            BtnBrans.Name = "BtnBrans";
            BtnBrans.Size = new Size(150, 35);
            BtnBrans.TabIndex = 0;
            BtnBrans.Text = "Brands";
            BtnBrans.UseVisualStyleBackColor = true;
            BtnBrans.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "Brands";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 16);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "Phone";
            // 
            // button2
            // 
            button2.Location = new Point(226, 114);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 3;
            button2.Text = "Phone";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 16);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 7;
            label3.Text = "NoteBook";
            // 
            // button3
            // 
            button3.Location = new Point(463, 114);
            button3.Name = "button3";
            button3.Size = new Size(150, 35);
            button3.TabIndex = 6;
            button3.Text = "NoteBook";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 517);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnBrans);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBrans;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
        private Button button3;
    }
}