namespace analizor
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cuvcheie = new System.Windows.Forms.TextBox();
            this.punctuatie = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.TextBox();
            this.constante_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.variabile_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 442);
            this.textBox1.TabIndex = 0;
            // 
            // cuvcheie
            // 
            this.cuvcheie.Location = new System.Drawing.Point(472, 33);
            this.cuvcheie.Multiline = true;
            this.cuvcheie.Name = "cuvcheie";
            this.cuvcheie.Size = new System.Drawing.Size(448, 75);
            this.cuvcheie.TabIndex = 1;
            // 
            // punctuatie
            // 
            this.punctuatie.Location = new System.Drawing.Point(472, 130);
            this.punctuatie.Multiline = true;
            this.punctuatie.Name = "punctuatie";
            this.punctuatie.Size = new System.Drawing.Size(448, 68);
            this.punctuatie.TabIndex = 2;
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(472, 220);
            this.op.Multiline = true;
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(448, 68);
            this.op.TabIndex = 3;
            // 
            // constante_text
            // 
            this.constante_text.Location = new System.Drawing.Point(472, 310);
            this.constante_text.Multiline = true;
            this.constante_text.Name = "constante_text";
            this.constante_text.Size = new System.Drawing.Size(448, 62);
            this.constante_text.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Recunoastere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuvinte cheie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Semne de punctuatie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operatori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Constante:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(454, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "Incarca cod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // variabile_text
            // 
            this.variabile_text.Location = new System.Drawing.Point(472, 394);
            this.variabile_text.Multiline = true;
            this.variabile_text.Name = "variabile_text";
            this.variabile_text.Size = new System.Drawing.Size(448, 57);
            this.variabile_text.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Variabile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.variabile_text);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.constante_text);
            this.Controls.Add(this.op);
            this.Controls.Add(this.punctuatie);
            this.Controls.Add(this.cuvcheie);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cuvcheie;
        private System.Windows.Forms.TextBox punctuatie;
        private System.Windows.Forms.TextBox op;
        private System.Windows.Forms.TextBox constante_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox variabile_text;
        private System.Windows.Forms.Label label5;
    }
}

