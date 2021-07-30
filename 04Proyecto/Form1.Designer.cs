
namespace _04Proyecto
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
            this.buttonAcero = new System.Windows.Forms.Button();
            this.buttonBronce = new System.Windows.Forms.Button();
            this.buttonChip = new System.Windows.Forms.Button();
            this.buttonEscoba = new System.Windows.Forms.Button();
            this.buttonPapel = new System.Windows.Forms.Button();
            this.buttonGominola = new System.Windows.Forms.Button();
            this.buttonHigo = new System.Windows.Forms.Button();
            this.listBoxElementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultadoKLinflama = new System.Windows.Forms.Label();
            this.labelResultadoCantAlmacen = new System.Windows.Forms.Label();
            this.labelResultadoNPerecedero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcero
            // 
            this.buttonAcero.Location = new System.Drawing.Point(43, 61);
            this.buttonAcero.Name = "buttonAcero";
            this.buttonAcero.Size = new System.Drawing.Size(75, 23);
            this.buttonAcero.TabIndex = 0;
            this.buttonAcero.Text = "Acero";
            this.buttonAcero.UseVisualStyleBackColor = true;
            this.buttonAcero.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonBronce
            // 
            this.buttonBronce.Location = new System.Drawing.Point(156, 60);
            this.buttonBronce.Name = "buttonBronce";
            this.buttonBronce.Size = new System.Drawing.Size(75, 23);
            this.buttonBronce.TabIndex = 1;
            this.buttonBronce.Text = "Bronce";
            this.buttonBronce.UseVisualStyleBackColor = true;
            this.buttonBronce.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonChip
            // 
            this.buttonChip.Location = new System.Drawing.Point(43, 91);
            this.buttonChip.Name = "buttonChip";
            this.buttonChip.Size = new System.Drawing.Size(75, 23);
            this.buttonChip.TabIndex = 2;
            this.buttonChip.Text = "Chip";
            this.buttonChip.UseVisualStyleBackColor = true;
            this.buttonChip.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEscoba
            // 
            this.buttonEscoba.Location = new System.Drawing.Point(156, 90);
            this.buttonEscoba.Name = "buttonEscoba";
            this.buttonEscoba.Size = new System.Drawing.Size(75, 23);
            this.buttonEscoba.TabIndex = 3;
            this.buttonEscoba.Text = "Escoba";
            this.buttonEscoba.UseVisualStyleBackColor = true;
            this.buttonEscoba.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPapel
            // 
            this.buttonPapel.Location = new System.Drawing.Point(43, 121);
            this.buttonPapel.Name = "buttonPapel";
            this.buttonPapel.Size = new System.Drawing.Size(75, 23);
            this.buttonPapel.TabIndex = 4;
            this.buttonPapel.Text = "Papel";
            this.buttonPapel.UseVisualStyleBackColor = true;
            this.buttonPapel.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonGominola
            // 
            this.buttonGominola.Location = new System.Drawing.Point(156, 120);
            this.buttonGominola.Name = "buttonGominola";
            this.buttonGominola.Size = new System.Drawing.Size(75, 23);
            this.buttonGominola.TabIndex = 5;
            this.buttonGominola.Text = "Gominola";
            this.buttonGominola.UseVisualStyleBackColor = true;
            this.buttonGominola.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonHigo
            // 
            this.buttonHigo.Location = new System.Drawing.Point(43, 151);
            this.buttonHigo.Name = "buttonHigo";
            this.buttonHigo.Size = new System.Drawing.Size(75, 23);
            this.buttonHigo.TabIndex = 6;
            this.buttonHigo.Text = "Higo";
            this.buttonHigo.UseVisualStyleBackColor = true;
            this.buttonHigo.Click += new System.EventHandler(this.button_Click);
            // 
            // listBoxElementos
            // 
            this.listBoxElementos.FormattingEnabled = true;
            this.listBoxElementos.ItemHeight = 15;
            this.listBoxElementos.Location = new System.Drawing.Point(551, 40);
            this.listBoxElementos.Name = "listBoxElementos";
            this.listBoxElementos.Size = new System.Drawing.Size(232, 304);
            this.listBoxElementos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kilos Perecederos No Inflamables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad en Almacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Media No Perecedero";
            // 
            // labelResultadoKLinflama
            // 
            this.labelResultadoKLinflama.AutoSize = true;
            this.labelResultadoKLinflama.Location = new System.Drawing.Point(248, 318);
            this.labelResultadoKLinflama.Name = "labelResultadoKLinflama";
            this.labelResultadoKLinflama.Size = new System.Drawing.Size(13, 15);
            this.labelResultadoKLinflama.TabIndex = 11;
            this.labelResultadoKLinflama.Text = "0";
            // 
            // labelResultadoCantAlmacen
            // 
            this.labelResultadoCantAlmacen.AutoSize = true;
            this.labelResultadoCantAlmacen.Location = new System.Drawing.Point(248, 349);
            this.labelResultadoCantAlmacen.Name = "labelResultadoCantAlmacen";
            this.labelResultadoCantAlmacen.Size = new System.Drawing.Size(13, 15);
            this.labelResultadoCantAlmacen.TabIndex = 12;
            this.labelResultadoCantAlmacen.Text = "0";
            // 
            // labelResultadoNPerecedero
            // 
            this.labelResultadoNPerecedero.AutoSize = true;
            this.labelResultadoNPerecedero.Location = new System.Drawing.Point(248, 381);
            this.labelResultadoNPerecedero.Name = "labelResultadoNPerecedero";
            this.labelResultadoNPerecedero.Size = new System.Drawing.Size(13, 15);
            this.labelResultadoNPerecedero.TabIndex = 13;
            this.labelResultadoNPerecedero.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 505);
            this.Controls.Add(this.labelResultadoNPerecedero);
            this.Controls.Add(this.labelResultadoCantAlmacen);
            this.Controls.Add(this.labelResultadoKLinflama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxElementos);
            this.Controls.Add(this.buttonHigo);
            this.Controls.Add(this.buttonGominola);
            this.Controls.Add(this.buttonPapel);
            this.Controls.Add(this.buttonEscoba);
            this.Controls.Add(this.buttonChip);
            this.Controls.Add(this.buttonBronce);
            this.Controls.Add(this.buttonAcero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcero;
        private System.Windows.Forms.Button buttonBronce;
        private System.Windows.Forms.Button buttonChip;
        private System.Windows.Forms.Button buttonEscoba;
        private System.Windows.Forms.Button buttonPapel;
        private System.Windows.Forms.Button buttonGominola;
        private System.Windows.Forms.Button buttonHigo;
        private System.Windows.Forms.ListBox listBoxElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultadoKLinflama;
        private System.Windows.Forms.Label labelResultadoCantAlmacen;
        private System.Windows.Forms.Label labelResultadoNPerecedero;
    }
}

