namespace UsingPrintHelper
{
    partial class RegistroAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.MatriculaTxt = new System.Windows.Forms.TextBox();
            this.GrupoTxt = new System.Windows.Forms.TextBox();
            this.GradoTxt = new System.Windows.Forms.TextBox();
            this.BoxRuby = new System.Windows.Forms.CheckBox();
            this.BoxPython = new System.Windows.Forms.CheckBox();
            this.BoxJava = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matricula";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(290, 75);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 5;
            this.NombreTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MatriculaTxt
            // 
            this.MatriculaTxt.Location = new System.Drawing.Point(290, 193);
            this.MatriculaTxt.Name = "MatriculaTxt";
            this.MatriculaTxt.Size = new System.Drawing.Size(100, 20);
            this.MatriculaTxt.TabIndex = 6;
            // 
            // GrupoTxt
            // 
            this.GrupoTxt.Location = new System.Drawing.Point(290, 151);
            this.GrupoTxt.Name = "GrupoTxt";
            this.GrupoTxt.Size = new System.Drawing.Size(100, 20);
            this.GrupoTxt.TabIndex = 7;
            // 
            // GradoTxt
            // 
            this.GradoTxt.Location = new System.Drawing.Point(290, 114);
            this.GradoTxt.Name = "GradoTxt";
            this.GradoTxt.Size = new System.Drawing.Size(100, 20);
            this.GradoTxt.TabIndex = 8;
            // 
            // BoxRuby
            // 
            this.BoxRuby.AutoSize = true;
            this.BoxRuby.Location = new System.Drawing.Point(217, 256);
            this.BoxRuby.Name = "BoxRuby";
            this.BoxRuby.Size = new System.Drawing.Size(51, 17);
            this.BoxRuby.TabIndex = 9;
            this.BoxRuby.Text = "Ruby";
            this.BoxRuby.UseVisualStyleBackColor = true;
            // 
            // BoxPython
            // 
            this.BoxPython.AutoSize = true;
            this.BoxPython.Location = new System.Drawing.Point(356, 256);
            this.BoxPython.Name = "BoxPython";
            this.BoxPython.Size = new System.Drawing.Size(59, 17);
            this.BoxPython.TabIndex = 10;
            this.BoxPython.Text = "Python";
            this.BoxPython.UseVisualStyleBackColor = true;
            // 
            // BoxJava
            // 
            this.BoxJava.AutoSize = true;
            this.BoxJava.Location = new System.Drawing.Point(509, 256);
            this.BoxJava.Name = "BoxJava";
            this.BoxJava.Size = new System.Drawing.Size(49, 17);
            this.BoxJava.TabIndex = 11;
            this.BoxJava.Text = "Java";
            this.BoxJava.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Talleres:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxJava);
            this.Controls.Add(this.BoxPython);
            this.Controls.Add(this.BoxRuby);
            this.Controls.Add(this.GradoTxt);
            this.Controls.Add(this.GrupoTxt);
            this.Controls.Add(this.MatriculaTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroAlumno";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MatriculaTxt;
        private System.Windows.Forms.TextBox GrupoTxt;
        private System.Windows.Forms.TextBox GradoTxt;
        private System.Windows.Forms.CheckBox BoxRuby;
        private System.Windows.Forms.CheckBox BoxPython;
        private System.Windows.Forms.CheckBox BoxJava;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox NombreTxt;
    }
}