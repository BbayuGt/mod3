namespace Modul3_103022400085
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
            satuanAwal = new ComboBox();
            label1 = new Label();
            nilaiAwal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nilaiAkhir = new TextBox();
            convertBtn = new Button();
            label4 = new Label();
            satuanAkhir = new ComboBox();
            SuspendLayout();
            // 
            // satuanAwal
            // 
            satuanAwal.DisplayMember = "a";
            satuanAwal.FormattingEnabled = true;
            satuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAwal.Location = new Point(114, 201);
            satuanAwal.Name = "satuanAwal";
            satuanAwal.Size = new Size(121, 23);
            satuanAwal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 183);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // nilaiAwal
            // 
            nilaiAwal.Location = new Point(296, 201);
            nilaiAwal.Name = "nilaiAwal";
            nilaiAwal.Size = new Size(236, 23);
            nilaiAwal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 183);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Nilai Awal";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 237);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Nilai Akhir";
            // 
            // nilaiAkhir
            // 
            nilaiAkhir.Location = new Point(296, 255);
            nilaiAkhir.Name = "nilaiAkhir";
            nilaiAkhir.Size = new Size(236, 23);
            nilaiAkhir.TabIndex = 4;
            // 
            // convertBtn
            // 
            convertBtn.Location = new Point(559, 201);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(75, 23);
            convertBtn.TabIndex = 6;
            convertBtn.Text = "Convert";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 237);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Satuan Akhir";
            // 
            // satuanAkhir
            // 
            satuanAkhir.DisplayMember = "a";
            satuanAkhir.FormattingEnabled = true;
            satuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            satuanAkhir.Location = new Point(114, 255);
            satuanAkhir.Name = "satuanAkhir";
            satuanAkhir.Size = new Size(121, 23);
            satuanAkhir.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(satuanAkhir);
            Controls.Add(convertBtn);
            Controls.Add(label3);
            Controls.Add(nilaiAkhir);
            Controls.Add(label2);
            Controls.Add(nilaiAwal);
            Controls.Add(label1);
            Controls.Add(satuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satuanAwal;
        private Label label1;
        private TextBox nilaiAwal;
        private Label label2;
        private Label label3;
        private TextBox nilaiAkhir;
        private Button convertBtn;
        private Label label4;
        private ComboBox satuanAkhir;
    }
}
