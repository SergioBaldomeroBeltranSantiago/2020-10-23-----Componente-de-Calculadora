﻿namespace LeCalculadoraPrueba
{
    partial class Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.calculadora1 = new Calculadora.Calculadora();
            this.SuspendLayout();
            // 
            // calculadora1
            // 
            this.calculadora1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calculadora1.BackgroundImage")));
            this.calculadora1.Location = new System.Drawing.Point(12, 12);
            this.calculadora1.Name = "calculadora1";
            this.calculadora1.Size = new System.Drawing.Size(349, 305);
            this.calculadora1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 448);
            this.Controls.Add(this.calculadora1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Calculadora.Calculadora calculadora1;
    }
}

