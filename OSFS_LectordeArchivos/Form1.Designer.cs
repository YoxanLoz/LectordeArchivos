﻿namespace OSFS_LectordeArchivos
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
            this.BtnLeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imprimir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(175, 200);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(75, 23);
            this.BtnLeer.TabIndex = 0;
            this.BtnLeer.Text = "Leer";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LECTOR DE ARCHIVOS";
            // 
            // imprimir
            // 
            this.imprimir.AutoSize = true;
            this.imprimir.Location = new System.Drawing.Point(60, 89);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(60, 13);
            this.imprimir.TabIndex = 2;
            this.imprimir.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imprimir;
    }
}

