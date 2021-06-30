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
            this.listBox_Ordenar = new System.Windows.Forms.ListBox();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.btn_MaxMin = new System.Windows.Forms.Button();
            this.listBox_MaxMin = new System.Windows.Forms.ListBox();
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
            this.listBox_Paises.Location = new System.Drawing.Point(171, 200);
            this.listBox_Paises.Name = "listBox_Paises";
            this.listBox_Paises.Size = new System.Drawing.Size(160, 147);
            this.listBox_Paises.TabIndex = 2;
            // 
            // listBox_Ordenar
            // 
            this.listBox_Ordenar.FormattingEnabled = true;
            this.listBox_Ordenar.Location = new System.Drawing.Point(369, 200);
            this.listBox_Ordenar.Name = "listBox_Ordenar";
            this.listBox_Ordenar.Size = new System.Drawing.Size(155, 147);
            this.listBox_Ordenar.TabIndex = 3;
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Location = new System.Drawing.Point(369, 61);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(95, 64);
            this.btn_Ordenar.TabIndex = 4;
            this.btn_Ordenar.Text = "Ordenar";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // btn_MaxMin
            // 
            this.btn_MaxMin.Location = new System.Drawing.Point(557, 61);
            this.btn_MaxMin.Name = "btn_MaxMin";
            this.btn_MaxMin.Size = new System.Drawing.Size(126, 64);
            this.btn_MaxMin.TabIndex = 5;
            this.btn_MaxMin.Text = "Maximo o MInimo";
            this.btn_MaxMin.UseVisualStyleBackColor = true;
            this.btn_MaxMin.Click += new System.EventHandler(this.btn_MaxMin_Click);
            // 
            // listBox_MaxMin
            // 
            this.listBox_MaxMin.FormattingEnabled = true;
            this.listBox_MaxMin.Location = new System.Drawing.Point(557, 200);
            this.listBox_MaxMin.Name = "listBox_MaxMin";
            this.listBox_MaxMin.Size = new System.Drawing.Size(128, 147);
            this.listBox_MaxMin.TabIndex = 6;
            // 
            // FrmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_MaxMin);
            this.Controls.Add(this.btn_MaxMin);
            this.Controls.Add(this.btn_Ordenar);
            this.Controls.Add(this.listBox_Ordenar);
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
        private System.Windows.Forms.ListBox listBox_Ordenar;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.Button btn_MaxMin;
        private System.Windows.Forms.ListBox listBox_MaxMin;
    }
}

