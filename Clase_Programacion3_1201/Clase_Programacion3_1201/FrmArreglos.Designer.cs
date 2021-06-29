namespace Clase_Programacion3_1201
{
    partial class FrmArreglos
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
            this.listBox_Arreglo = new System.Windows.Forms.ListBox();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.listBox_Paises = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_Arreglo
            // 
            this.listBox_Arreglo.FormattingEnabled = true;
            this.listBox_Arreglo.Location = new System.Drawing.Point(36, 200);
            this.listBox_Arreglo.Name = "listBox_Arreglo";
            this.listBox_Arreglo.Size = new System.Drawing.Size(106, 147);
            this.listBox_Arreglo.TabIndex = 0;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ejecutar.Location = new System.Drawing.Point(112, 61);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(116, 64);
            this.btn_Ejecutar.TabIndex = 1;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // listBox_Paises
            // 
            this.listBox_Paises.FormattingEnabled = true;
            this.listBox_Paises.Location = new System.Drawing.Point(158, 200);
            this.listBox_Paises.Name = "listBox_Paises";
            this.listBox_Paises.Size = new System.Drawing.Size(160, 147);
            this.listBox_Paises.TabIndex = 2;
            // 
            // FrmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Paises);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.listBox_Arreglo);
            this.Name = "FrmArreglos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Arreglo;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.ListBox listBox_Paises;
    }
}

