namespace UsingPrintHelper
{
    partial class IMpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMpresion));
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.gradolbl = new System.Windows.Forms.Label();
            this.grupolbl = new System.Windows.Forms.Label();
            this.matriculalbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblpython = new System.Windows.Forms.Label();
            this.lbljava = new System.Windows.Forms.Label();
            this.lblruby = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Location = new System.Drawing.Point(358, 66);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(35, 13);
            this.Nombrelbl.TabIndex = 0;
            this.Nombrelbl.Text = "label1";
            this.Nombrelbl.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // gradolbl
            // 
            this.gradolbl.AutoSize = true;
            this.gradolbl.Location = new System.Drawing.Point(358, 113);
            this.gradolbl.Name = "gradolbl";
            this.gradolbl.Size = new System.Drawing.Size(35, 13);
            this.gradolbl.TabIndex = 1;
            this.gradolbl.Text = "label2";
            // 
            // grupolbl
            // 
            this.grupolbl.AutoSize = true;
            this.grupolbl.Location = new System.Drawing.Point(358, 163);
            this.grupolbl.Name = "grupolbl";
            this.grupolbl.Size = new System.Drawing.Size(35, 13);
            this.grupolbl.TabIndex = 2;
            this.grupolbl.Text = "label3";
            // 
            // matriculalbl
            // 
            this.matriculalbl.AutoSize = true;
            this.matriculalbl.Location = new System.Drawing.Point(358, 214);
            this.matriculalbl.Name = "matriculalbl";
            this.matriculalbl.Size = new System.Drawing.Size(35, 13);
            this.matriculalbl.TabIndex = 3;
            this.matriculalbl.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblpython
            // 
            this.lblpython.AutoSize = true;
            this.lblpython.Location = new System.Drawing.Point(253, 262);
            this.lblpython.Name = "lblpython";
            this.lblpython.Size = new System.Drawing.Size(0, 13);
            this.lblpython.TabIndex = 5;
            // 
            // lbljava
            // 
            this.lbljava.AutoSize = true;
            this.lbljava.Location = new System.Drawing.Point(358, 262);
            this.lbljava.Name = "lbljava";
            this.lbljava.Size = new System.Drawing.Size(0, 13);
            this.lbljava.TabIndex = 6;
            // 
            // lblruby
            // 
            this.lblruby.AutoSize = true;
            this.lblruby.Location = new System.Drawing.Point(443, 262);
            this.lblruby.Name = "lblruby";
            this.lblruby.Size = new System.Drawing.Size(0, 13);
            this.lblruby.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // IMpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblruby);
            this.Controls.Add(this.lbljava);
            this.Controls.Add(this.lblpython);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.matriculalbl);
            this.Controls.Add(this.grupolbl);
            this.Controls.Add(this.gradolbl);
            this.Controls.Add(this.Nombrelbl);
            this.Name = "IMpresion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.IMpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Nombrelbl;
        public System.Windows.Forms.Label gradolbl;
        public System.Windows.Forms.Label grupolbl;
        public System.Windows.Forms.Label matriculalbl;
        public System.Windows.Forms.Label lblpython;
        public System.Windows.Forms.Label lblruby;
        public System.Windows.Forms.Label lbljava;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}