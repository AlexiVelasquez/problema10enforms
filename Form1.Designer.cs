namespace problema10enforms
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
            Label txt1;
            lbl1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtnum1 = new TextBox();
            button1 = new Button();
            splitter1 = new Splitter();
            txt1 = new Label();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.BackColor = SystemColors.WindowFrame;
            txt1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(32, 41);
            txt1.Name = "txt1";
            txt1.Size = new Size(425, 42);
            txt1.TabIndex = 0;
            txt1.Text = "Ingrese cantidad consumida:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.InactiveCaption;
            lbl1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(303, 230);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(174, 32);
            lbl1.TabIndex = 7;
            lbl1.Text = "Total a pagar:....";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 109);
            label3.Name = "label3";
            label3.Size = new Size(598, 23);
            label3.TabIndex = 2;
            label3.Text = "Descuento del 10% al consumir menor que 100 soles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 153);
            label2.Name = "label2";
            label2.Size = new Size(598, 23);
            label2.TabIndex = 3;
            label2.Text = "Descuento del 20% al consumir mayor que 100 soles";
            // 
            // txtnum1
            // 
            txtnum1.Font = new Font("OCR A Extended", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtnum1.Location = new Point(489, 50);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(88, 33);
            txtnum1.TabIndex = 4;
            txtnum1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(79, 188);
            button1.Name = "button1";
            button1.Size = new Size(143, 62);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(26, 282);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(641, 282);
            Controls.Add(lbl1);
            Controls.Add(splitter1);
            Controls.Add(button1);
            Controls.Add(txtnum1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtnum1;
        private Button button1;
        private Splitter splitter1;
        private Label lbl1;
    }
}