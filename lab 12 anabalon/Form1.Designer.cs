namespace lab_12_anabalon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.grasa = new System.Windows.Forms.TextBox();
            this.carbohidrato = new System.Windows.Forms.TextBox();
            this.alimentos = new System.Windows.Forms.ListBox();
            this.listado = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar_seleccionado = new System.Windows.Forms.Button();
            this.proteinaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "proteina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "grasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "carbohidatro";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(86, 27);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 4;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // grasa
            // 
            this.grasa.Location = new System.Drawing.Point(86, 98);
            this.grasa.Name = "grasa";
            this.grasa.Size = new System.Drawing.Size(100, 20);
            this.grasa.TabIndex = 6;
            this.grasa.TextChanged += new System.EventHandler(this.grasa_TextChanged);
            // 
            // carbohidrato
            // 
            this.carbohidrato.Location = new System.Drawing.Point(86, 132);
            this.carbohidrato.Name = "carbohidrato";
            this.carbohidrato.Size = new System.Drawing.Size(100, 20);
            this.carbohidrato.TabIndex = 7;
            this.carbohidrato.TextChanged += new System.EventHandler(this.carbohidrato_TextChanged);
            // 
            // alimentos
            // 
            this.alimentos.FormattingEnabled = true;
            this.alimentos.Location = new System.Drawing.Point(205, 30);
            this.alimentos.Name = "alimentos";
            this.alimentos.Size = new System.Drawing.Size(123, 121);
            this.alimentos.TabIndex = 8;
            this.alimentos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listado
            // 
            this.listado.AutoSize = true;
            this.listado.Location = new System.Drawing.Point(246, 11);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(37, 13);
            this.listado.TabIndex = 9;
            this.listado.Text = "listado";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(86, 181);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 10;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar_seleccionado
            // 
            this.eliminar_seleccionado.AllowDrop = true;
            this.eliminar_seleccionado.Location = new System.Drawing.Point(205, 181);
            this.eliminar_seleccionado.Name = "eliminar_seleccionado";
            this.eliminar_seleccionado.Size = new System.Drawing.Size(123, 23);
            this.eliminar_seleccionado.TabIndex = 11;
            this.eliminar_seleccionado.Text = "eliminar seleccionado";
            this.eliminar_seleccionado.UseVisualStyleBackColor = true;
            // 
            // proteinaBox
            // 
            this.proteinaBox.Location = new System.Drawing.Point(86, 58);
            this.proteinaBox.Name = "proteinaBox";
            this.proteinaBox.Size = new System.Drawing.Size(100, 20);
            this.proteinaBox.TabIndex = 13;
            this.proteinaBox.Text = " ";
            this.proteinaBox.TextChanged += new System.EventHandler(this.proteinaBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 286);
            this.Controls.Add(this.proteinaBox);
            this.Controls.Add(this.eliminar_seleccionado);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.alimentos);
            this.Controls.Add(this.carbohidrato);
            this.Controls.Add(this.grasa);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox grasa;
        private System.Windows.Forms.TextBox carbohidrato;
        private System.Windows.Forms.ListBox alimentos;
        private System.Windows.Forms.Label listado;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar_seleccionado;
        private System.Windows.Forms.TextBox proteinaBox;
    }
}

