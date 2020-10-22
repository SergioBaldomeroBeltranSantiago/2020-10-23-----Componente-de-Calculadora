namespace LeCalculadora
{
    partial class CalculadoraComponente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LimpiarTodo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Digito7 = new System.Windows.Forms.Button();
            this.Digito8 = new System.Windows.Forms.Button();
            this.Digito9 = new System.Windows.Forms.Button();
            this.Digito4 = new System.Windows.Forms.Button();
            this.Digito5 = new System.Windows.Forms.Button();
            this.Digito6 = new System.Windows.Forms.Button();
            this.Digito1 = new System.Windows.Forms.Button();
            this.Digito2 = new System.Windows.Forms.Button();
            this.Digito3 = new System.Windows.Forms.Button();
            this.Digito0 = new System.Windows.Forms.Button();
            this.PuntoDecimal = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Button();
            this.LimpiarUltimo = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LimpiarTodo
            // 
            this.LimpiarTodo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarTodo.Location = new System.Drawing.Point(3, 29);
            this.LimpiarTodo.Name = "LimpiarTodo";
            this.LimpiarTodo.Size = new System.Drawing.Size(75, 23);
            this.LimpiarTodo.TabIndex = 0;
            this.LimpiarTodo.Text = "AC";
            this.LimpiarTodo.UseVisualStyleBackColor = true;
            this.LimpiarTodo.Click += new System.EventHandler(this.LimpiarTodo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Suma
            // 
            this.Suma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(3, 116);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 52);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(3, 87);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 3;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.Location = new System.Drawing.Point(3, 58);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(75, 23);
            this.Multiplicacion.TabIndex = 4;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // Division
            // 
            this.Division.Cursor = System.Windows.Forms.Cursors.Default;
            this.Division.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(165, 29);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 5;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Digito7
            // 
            this.Digito7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito7.Location = new System.Drawing.Point(84, 58);
            this.Digito7.Name = "Digito7";
            this.Digito7.Size = new System.Drawing.Size(75, 23);
            this.Digito7.TabIndex = 6;
            this.Digito7.Text = "7";
            this.Digito7.UseVisualStyleBackColor = true;
            this.Digito7.Click += new System.EventHandler(this.Digito7_Click);
            // 
            // Digito8
            // 
            this.Digito8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito8.Location = new System.Drawing.Point(165, 58);
            this.Digito8.Name = "Digito8";
            this.Digito8.Size = new System.Drawing.Size(75, 23);
            this.Digito8.TabIndex = 7;
            this.Digito8.Text = "8";
            this.Digito8.UseVisualStyleBackColor = true;
            this.Digito8.Click += new System.EventHandler(this.Digito8_Click);
            // 
            // Digito9
            // 
            this.Digito9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito9.Location = new System.Drawing.Point(246, 58);
            this.Digito9.Name = "Digito9";
            this.Digito9.Size = new System.Drawing.Size(75, 23);
            this.Digito9.TabIndex = 8;
            this.Digito9.Text = "9";
            this.Digito9.UseVisualStyleBackColor = true;
            this.Digito9.Click += new System.EventHandler(this.Digito9_Click);
            // 
            // Digito4
            // 
            this.Digito4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito4.Location = new System.Drawing.Point(84, 87);
            this.Digito4.Name = "Digito4";
            this.Digito4.Size = new System.Drawing.Size(75, 23);
            this.Digito4.TabIndex = 9;
            this.Digito4.Text = "4";
            this.Digito4.UseVisualStyleBackColor = true;
            this.Digito4.Click += new System.EventHandler(this.Digito4_Click);
            // 
            // Digito5
            // 
            this.Digito5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito5.Location = new System.Drawing.Point(165, 87);
            this.Digito5.Name = "Digito5";
            this.Digito5.Size = new System.Drawing.Size(75, 23);
            this.Digito5.TabIndex = 10;
            this.Digito5.Text = "5";
            this.Digito5.UseVisualStyleBackColor = true;
            this.Digito5.Click += new System.EventHandler(this.Digito5_Click);
            // 
            // Digito6
            // 
            this.Digito6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito6.Location = new System.Drawing.Point(246, 87);
            this.Digito6.Name = "Digito6";
            this.Digito6.Size = new System.Drawing.Size(75, 23);
            this.Digito6.TabIndex = 11;
            this.Digito6.Text = "6";
            this.Digito6.UseVisualStyleBackColor = true;
            this.Digito6.Click += new System.EventHandler(this.Digito6_Click);
            // 
            // Digito1
            // 
            this.Digito1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito1.Location = new System.Drawing.Point(84, 116);
            this.Digito1.Name = "Digito1";
            this.Digito1.Size = new System.Drawing.Size(75, 23);
            this.Digito1.TabIndex = 12;
            this.Digito1.Text = "1";
            this.Digito1.UseVisualStyleBackColor = true;
            this.Digito1.Click += new System.EventHandler(this.Digito1_Click);
            // 
            // Digito2
            // 
            this.Digito2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito2.Location = new System.Drawing.Point(165, 116);
            this.Digito2.Name = "Digito2";
            this.Digito2.Size = new System.Drawing.Size(75, 23);
            this.Digito2.TabIndex = 13;
            this.Digito2.Text = "2";
            this.Digito2.UseVisualStyleBackColor = true;
            this.Digito2.Click += new System.EventHandler(this.Digito2_Click);
            // 
            // Digito3
            // 
            this.Digito3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito3.Location = new System.Drawing.Point(246, 116);
            this.Digito3.Name = "Digito3";
            this.Digito3.Size = new System.Drawing.Size(75, 23);
            this.Digito3.TabIndex = 14;
            this.Digito3.Text = "3";
            this.Digito3.UseVisualStyleBackColor = true;
            this.Digito3.Click += new System.EventHandler(this.Digito3_Click);
            // 
            // Digito0
            // 
            this.Digito0.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digito0.Location = new System.Drawing.Point(84, 145);
            this.Digito0.Name = "Digito0";
            this.Digito0.Size = new System.Drawing.Size(75, 23);
            this.Digito0.TabIndex = 15;
            this.Digito0.Text = "0";
            this.Digito0.UseVisualStyleBackColor = true;
            this.Digito0.Click += new System.EventHandler(this.Digito0_Click);
            // 
            // PuntoDecimal
            // 
            this.PuntoDecimal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntoDecimal.Location = new System.Drawing.Point(165, 145);
            this.PuntoDecimal.Name = "PuntoDecimal";
            this.PuntoDecimal.Size = new System.Drawing.Size(75, 23);
            this.PuntoDecimal.TabIndex = 16;
            this.PuntoDecimal.Text = ".";
            this.PuntoDecimal.UseVisualStyleBackColor = true;
            this.PuntoDecimal.Click += new System.EventHandler(this.PuntoDecimal_Click);
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(246, 145);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(75, 23);
            this.Resultado.TabIndex = 17;
            this.Resultado.Text = "=";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // LimpiarUltimo
            // 
            this.LimpiarUltimo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarUltimo.Location = new System.Drawing.Point(84, 29);
            this.LimpiarUltimo.Name = "LimpiarUltimo";
            this.LimpiarUltimo.Size = new System.Drawing.Size(75, 23);
            this.LimpiarUltimo.TabIndex = 18;
            this.LimpiarUltimo.Text = "C";
            this.LimpiarUltimo.UseVisualStyleBackColor = true;
            this.LimpiarUltimo.Click += new System.EventHandler(this.LimpiarUltimo_Click);
            // 
            // Modulo
            // 
            this.Modulo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modulo.Location = new System.Drawing.Point(246, 29);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(75, 23);
            this.Modulo.TabIndex = 19;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // CalculadoraComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.LimpiarUltimo);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.PuntoDecimal);
            this.Controls.Add(this.Digito0);
            this.Controls.Add(this.Digito3);
            this.Controls.Add(this.Digito2);
            this.Controls.Add(this.Digito1);
            this.Controls.Add(this.Digito6);
            this.Controls.Add(this.Digito5);
            this.Controls.Add(this.Digito4);
            this.Controls.Add(this.Digito9);
            this.Controls.Add(this.Digito8);
            this.Controls.Add(this.Digito7);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LimpiarTodo);
            this.Name = "CalculadoraComponente";
            this.Size = new System.Drawing.Size(330, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarTodo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Digito7;
        private System.Windows.Forms.Button Digito8;
        private System.Windows.Forms.Button Digito9;
        private System.Windows.Forms.Button Digito4;
        private System.Windows.Forms.Button Digito5;
        private System.Windows.Forms.Button Digito6;
        private System.Windows.Forms.Button Digito1;
        private System.Windows.Forms.Button Digito2;
        private System.Windows.Forms.Button Digito3;
        private System.Windows.Forms.Button Digito0;
        private System.Windows.Forms.Button PuntoDecimal;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.Button LimpiarUltimo;
        private System.Windows.Forms.Button Modulo;
    }
}
