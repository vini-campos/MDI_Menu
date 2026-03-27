namespace Menu_Calculos
{
    partial class frmRadio
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.rb_pot = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_multi = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_soma = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.rb_pot);
            this.grb1.Controls.Add(this.rb_div);
            this.grb1.Controls.Add(this.rb_multi);
            this.grb1.Controls.Add(this.rb_sub);
            this.grb1.Controls.Add(this.rb_soma);
            this.grb1.Location = new System.Drawing.Point(18, 23);
            this.grb1.Margin = new System.Windows.Forms.Padding(2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(2);
            this.grb1.Size = new System.Drawing.Size(113, 166);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Operações";
            // 
            // rb_pot
            // 
            this.rb_pot.AutoSize = true;
            this.rb_pot.Location = new System.Drawing.Point(11, 135);
            this.rb_pot.Margin = new System.Windows.Forms.Padding(2);
            this.rb_pot.Name = "rb_pot";
            this.rb_pot.Size = new System.Drawing.Size(85, 17);
            this.rb_pot.TabIndex = 4;
            this.rb_pot.TabStop = true;
            this.rb_pot.Text = "Potenciação";
            this.rb_pot.UseVisualStyleBackColor = true;
            this.rb_pot.CheckedChanged += new System.EventHandler(this.rb_pot_CheckedChanged);
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(11, 109);
            this.rb_div.Margin = new System.Windows.Forms.Padding(2);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(60, 17);
            this.rb_div.TabIndex = 3;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "Divisão";
            this.rb_div.UseVisualStyleBackColor = true;
            this.rb_div.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rb_multi
            // 
            this.rb_multi.AutoSize = true;
            this.rb_multi.Location = new System.Drawing.Point(11, 83);
            this.rb_multi.Margin = new System.Windows.Forms.Padding(2);
            this.rb_multi.Name = "rb_multi";
            this.rb_multi.Size = new System.Drawing.Size(85, 17);
            this.rb_multi.TabIndex = 2;
            this.rb_multi.TabStop = true;
            this.rb_multi.Text = "Multipicação";
            this.rb_multi.UseVisualStyleBackColor = true;
            this.rb_multi.CheckedChanged += new System.EventHandler(this.rb_multi_CheckedChanged);
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(11, 55);
            this.rb_sub.Margin = new System.Windows.Forms.Padding(2);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(74, 17);
            this.rb_sub.TabIndex = 1;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "Subtração";
            this.rb_sub.UseVisualStyleBackColor = true;
            this.rb_sub.CheckedChanged += new System.EventHandler(this.rb_sub_CheckedChanged);
            // 
            // rb_soma
            // 
            this.rb_soma.AutoSize = true;
            this.rb_soma.Location = new System.Drawing.Point(11, 29);
            this.rb_soma.Margin = new System.Windows.Forms.Padding(2);
            this.rb_soma.Name = "rb_soma";
            this.rb_soma.Size = new System.Drawing.Size(58, 17);
            this.rb_soma.TabIndex = 0;
            this.rb_soma.TabStop = true;
            this.rb_soma.Text = "Adição";
            this.rb_soma.UseVisualStyleBackColor = true;
            this.rb_soma.CheckedChanged += new System.EventHandler(this.rb_soma_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(192, 80);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "?";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(225, 33);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(93, 16);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(225, 63);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(93, 18);
            this.txt2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(220, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "________________";
            // 
            // lblres
            // 
            this.lblres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblres.Location = new System.Drawing.Point(221, 106);
            this.lblres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(97, 19);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "?";
            this.lblres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(240, 158);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(63, 22);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(173, 158);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(63, 22);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grb1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(405, 253);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_multi;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_soma;
        private System.Windows.Forms.RadioButton rb_pot;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}