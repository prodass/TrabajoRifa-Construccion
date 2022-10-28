namespace Construccion
{
    partial class FormRifa
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
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxRifa = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tboxNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxRifa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(110, 19);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 0;
            this.tboxNombre.TextChanged += new System.EventHandler(this.tboxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // gboxRifa
            // 
            this.gboxRifa.Controls.Add(this.btnGuardar);
            this.gboxRifa.Controls.Add(this.tboxNumero);
            this.gboxRifa.Controls.Add(this.label3);
            this.gboxRifa.Controls.Add(this.tboxApellido);
            this.gboxRifa.Controls.Add(this.tboxNombre);
            this.gboxRifa.Controls.Add(this.label2);
            this.gboxRifa.Controls.Add(this.label1);
            this.gboxRifa.Location = new System.Drawing.Point(57, 22);
            this.gboxRifa.Name = "gboxRifa";
            this.gboxRifa.Size = new System.Drawing.Size(258, 132);
            this.gboxRifa.TabIndex = 3;
            this.gboxRifa.TabStop = false;
            this.gboxRifa.Text = "Datos Rifa";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(84, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tboxNumero
            // 
            this.tboxNumero.Location = new System.Drawing.Point(110, 74);
            this.tboxNumero.Name = "tboxNumero";
            this.tboxNumero.Size = new System.Drawing.Size(100, 20);
            this.tboxNumero.TabIndex = 5;
            this.tboxNumero.TextChanged += new System.EventHandler(this.tboxNumero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero (*):";
            // 
            // tboxApellido
            // 
            this.tboxApellido.Location = new System.Drawing.Point(110, 48);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(100, 20);
            this.tboxApellido.TabIndex = 3;
            this.tboxApellido.TextChanged += new System.EventHandler(this.tboxApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(*) Ingrese un numero de hasta 3 cifras.";
            // 
            // FormRifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gboxRifa);
            this.Name = "FormRifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rifa";
            this.gboxRifa.ResumeLayout(false);
            this.gboxRifa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxRifa;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.TextBox tboxNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
    }
}

