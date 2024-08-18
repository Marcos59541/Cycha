namespace Temperatura_convertor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.blimpiar = new System.Windows.Forms.Button();
            this.bFC = new System.Windows.Forms.Button();
            this.bCF = new System.Windows.Forms.Button();
            this.Ctext = new System.Windows.Forms.TextBox();
            this.Ftext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // blimpiar
            // 
            this.blimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blimpiar.Location = new System.Drawing.Point(287, 285);
            this.blimpiar.Name = "blimpiar";
            this.blimpiar.Size = new System.Drawing.Size(186, 49);
            this.blimpiar.TabIndex = 0;
            this.blimpiar.Text = "Limpiar";
            this.blimpiar.UseVisualStyleBackColor = true;
            this.blimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bFC
            // 
            this.bFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFC.Location = new System.Drawing.Point(287, 85);
            this.bFC.Name = "bFC";
            this.bFC.Size = new System.Drawing.Size(186, 53);
            this.bFC.TabIndex = 1;
            this.bFC.Text = "C ---> F";
            this.bFC.UseVisualStyleBackColor = true;
            this.bFC.Click += new System.EventHandler(this.bFC_Click);
            // 
            // bCF
            // 
            this.bCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCF.Location = new System.Drawing.Point(287, 163);
            this.bCF.Name = "bCF";
            this.bCF.Size = new System.Drawing.Size(186, 52);
            this.bCF.TabIndex = 2;
            this.bCF.Text = "C <--- F";
            this.bCF.UseVisualStyleBackColor = true;
            this.bCF.Click += new System.EventHandler(this.bCF_Click);
            // 
            // Ctext
            // 
            this.Ctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ctext.Location = new System.Drawing.Point(578, 125);
            this.Ctext.Name = "Ctext";
            this.Ctext.Size = new System.Drawing.Size(122, 53);
            this.Ctext.TabIndex = 3;
            this.Ctext.TextChanged += new System.EventHandler(this.Ctext_TextChanged);
            // 
            // Ftext
            // 
            this.Ftext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ftext.Location = new System.Drawing.Point(63, 125);
            this.Ftext.Name = "Ftext";
            this.Ftext.Size = new System.Drawing.Size(122, 53);
            this.Ftext.TabIndex = 4;
            this.Ftext.TextChanged += new System.EventHandler(this.Fbutton_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ftext);
            this.Controls.Add(this.Ctext);
            this.Controls.Add(this.bCF);
            this.Controls.Add(this.bFC);
            this.Controls.Add(this.blimpiar);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button blimpiar;
        private System.Windows.Forms.Button bFC;
        private System.Windows.Forms.Button bCF;
        private System.Windows.Forms.TextBox Ctext;
        private System.Windows.Forms.TextBox Ftext;
    }
}

