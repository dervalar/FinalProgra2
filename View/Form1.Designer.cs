namespace ProyectoFinal
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
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CrearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarInstBtn = new System.Windows.Forms.Button();
            this.TxtInst = new System.Windows.Forms.TextBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente";
            // 
            // TxtDni
            // 
            this.TxtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDni.Location = new System.Drawing.Point(165, 26);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(373, 34);
            this.TxtDni.TabIndex = 1;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Location = new System.Drawing.Point(544, 26);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(151, 36);
            this.BuscarBtn.TabIndex = 2;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CrearBtn
            // 
            this.CrearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearBtn.Location = new System.Drawing.Point(701, 26);
            this.CrearBtn.Name = "CrearBtn";
            this.CrearBtn.Size = new System.Drawing.Size(87, 36);
            this.CrearBtn.TabIndex = 3;
            this.CrearBtn.Text = "Crear";
            this.CrearBtn.UseVisualStyleBackColor = true;
            this.CrearBtn.Click += new System.EventHandler(this.CrearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Instrumento por código";
            // 
            // BuscarInstBtn
            // 
            this.BuscarInstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarInstBtn.Location = new System.Drawing.Point(531, 202);
            this.BuscarInstBtn.Name = "BuscarInstBtn";
            this.BuscarInstBtn.Size = new System.Drawing.Size(151, 39);
            this.BuscarInstBtn.TabIndex = 5;
            this.BuscarInstBtn.Text = "Buscar";
            this.BuscarInstBtn.UseVisualStyleBackColor = true;
            // 
            // TxtInst
            // 
            this.TxtInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInst.Location = new System.Drawing.Point(377, 204);
            this.TxtInst.Name = "TxtInst";
            this.TxtInst.Size = new System.Drawing.Size(148, 34);
            this.TxtInst.TabIndex = 6;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Location = new System.Drawing.Point(688, 204);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(109, 39);
            this.AgregarBtn.TabIndex = 7;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 16);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Nombre del cliente";
            this.lblName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(17, 97);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(91, 16);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "Dni del cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "emaildecliente@gmail.com";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(17, 129);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(90, 16);
            this.lblSocio.TabIndex = 12;
            this.lblSocio.Text = "Tipo de socio";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(553, 394);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(244, 55);
            this.BtnConfirmar.TabIndex = 13;
            this.BtnConfirmar.Text = "Confirmar Alquiler";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.TxtInst);
            this.Controls.Add(this.BuscarInstBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alquiler Instrumentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CrearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarInstBtn;
        private System.Windows.Forms.TextBox TxtInst;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Button BtnConfirmar;
    }
}

