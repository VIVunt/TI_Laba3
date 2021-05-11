namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pField = new System.Windows.Forms.TextBox();
            this.qField = new System.Windows.Forms.TextBox();
            this.dField = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.PlainTextField = new System.Windows.Forms.TextBox();
            this.TransmittedTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eField = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.w_n = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.w_nField = new System.Windows.Forms.TextBox();
            this.nField = new System.Windows.Forms.TextBox();
            this.CalcHashField = new System.Windows.Forms.TextBox();
            this.TranHashField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.DecipherHash = new System.Windows.Forms.Button();
            this.DecipheredHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pField
            // 
            this.pField.Location = new System.Drawing.Point(41, 44);
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(167, 20);
            this.pField.TabIndex = 0;
            this.pField.WordWrap = false;
            // 
            // qField
            // 
            this.qField.Location = new System.Drawing.Point(245, 44);
            this.qField.Name = "qField";
            this.qField.Size = new System.Drawing.Size(167, 20);
            this.qField.TabIndex = 2;
            this.qField.WordWrap = false;
            // 
            // dField
            // 
            this.dField.Location = new System.Drawing.Point(245, 87);
            this.dField.Name = "dField";
            this.dField.ReadOnly = true;
            this.dField.Size = new System.Drawing.Size(167, 20);
            this.dField.TabIndex = 6;
            this.dField.WordWrap = false;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(276, 523);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate hash";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(669, 64);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // PlainTextField
            // 
            this.PlainTextField.Location = new System.Drawing.Point(41, 160);
            this.PlainTextField.Multiline = true;
            this.PlainTextField.Name = "PlainTextField";
            this.PlainTextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainTextField.Size = new System.Drawing.Size(684, 123);
            this.PlainTextField.TabIndex = 11;
            this.PlainTextField.TabStop = false;
            // 
            // TransmittedTextField
            // 
            this.TransmittedTextField.Location = new System.Drawing.Point(41, 382);
            this.TransmittedTextField.Multiline = true;
            this.TransmittedTextField.Name = "TransmittedTextField";
            this.TransmittedTextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransmittedTextField.Size = new System.Drawing.Size(684, 123);
            this.TransmittedTextField.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plain text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transmitted text:";
            // 
            // eField
            // 
            this.eField.Location = new System.Drawing.Point(41, 87);
            this.eField.Name = "eField";
            this.eField.Size = new System.Drawing.Size(167, 20);
            this.eField.TabIndex = 15;
            this.eField.WordWrap = false;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(19, 47);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(16, 13);
            this.p.TabIndex = 16;
            this.p.Text = "p:";
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(223, 47);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(16, 13);
            this.q.TabIndex = 17;
            this.q.Text = "q:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(223, 90);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(16, 13);
            this.d.TabIndex = 19;
            this.d.Text = "d:";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(19, 90);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(16, 13);
            this.e.TabIndex = 18;
            this.e.Text = "e:";
            // 
            // w_n
            // 
            this.w_n.AutoSize = true;
            this.w_n.Location = new System.Drawing.Point(432, 90);
            this.w_n.Name = "w_n";
            this.w_n.Size = new System.Drawing.Size(30, 13);
            this.w_n.TabIndex = 23;
            this.w_n.Text = "w(n):";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(446, 47);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(16, 13);
            this.n.TabIndex = 22;
            this.n.Text = "n:";
            // 
            // w_nField
            // 
            this.w_nField.Location = new System.Drawing.Point(468, 87);
            this.w_nField.Name = "w_nField";
            this.w_nField.ReadOnly = true;
            this.w_nField.Size = new System.Drawing.Size(167, 20);
            this.w_nField.TabIndex = 21;
            this.w_nField.WordWrap = false;
            // 
            // nField
            // 
            this.nField.Location = new System.Drawing.Point(468, 44);
            this.nField.Name = "nField";
            this.nField.ReadOnly = true;
            this.nField.Size = new System.Drawing.Size(167, 20);
            this.nField.TabIndex = 20;
            this.nField.WordWrap = false;
            // 
            // CalcHashField
            // 
            this.CalcHashField.Location = new System.Drawing.Point(362, 523);
            this.CalcHashField.Name = "CalcHashField";
            this.CalcHashField.Size = new System.Drawing.Size(100, 20);
            this.CalcHashField.TabIndex = 24;
            // 
            // TranHashField
            // 
            this.TranHashField.Location = new System.Drawing.Point(139, 525);
            this.TranHashField.Name = "TranHashField";
            this.TranHashField.Size = new System.Drawing.Size(100, 20);
            this.TranHashField.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Transmitted hash:";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(50, 289);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 28;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // DecipherHash
            // 
            this.DecipherHash.Location = new System.Drawing.Point(483, 521);
            this.DecipherHash.Name = "DecipherHash";
            this.DecipherHash.Size = new System.Drawing.Size(75, 23);
            this.DecipherHash.TabIndex = 29;
            this.DecipherHash.Text = "Decipher";
            this.DecipherHash.UseVisualStyleBackColor = true;
            this.DecipherHash.Click += new System.EventHandler(this.DecipherHash_Click);
            // 
            // DecipheredHash
            // 
            this.DecipheredHash.Location = new System.Drawing.Point(575, 523);
            this.DecipheredHash.Name = "DecipheredHash";
            this.DecipheredHash.Size = new System.Drawing.Size(100, 20);
            this.DecipheredHash.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 566);
            this.Controls.Add(this.DecipheredHash);
            this.Controls.Add(this.DecipherHash);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TranHashField);
            this.Controls.Add(this.CalcHashField);
            this.Controls.Add(this.w_n);
            this.Controls.Add(this.n);
            this.Controls.Add(this.w_nField);
            this.Controls.Add(this.nField);
            this.Controls.Add(this.d);
            this.Controls.Add(this.e);
            this.Controls.Add(this.q);
            this.Controls.Add(this.p);
            this.Controls.Add(this.eField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransmittedTextField);
            this.Controls.Add(this.PlainTextField);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.dField);
            this.Controls.Add(this.qField);
            this.Controls.Add(this.pField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pField;
        private System.Windows.Forms.TextBox qField;
        private System.Windows.Forms.TextBox dField;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox PlainTextField;
        private System.Windows.Forms.TextBox TransmittedTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eField;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label w_n;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox w_nField;
        private System.Windows.Forms.TextBox nField;
        private System.Windows.Forms.TextBox CalcHashField;
        private System.Windows.Forms.TextBox TranHashField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button DecipherHash;
        private System.Windows.Forms.TextBox DecipheredHash;
    }
}

