namespace downloader2._0
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnDOWN = new System.Windows.Forms.Button();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Url";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(18, 37);
            this.txtIn.MaxLength = 3276700;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(377, 20);
            this.txtIn.TabIndex = 1;
            // 
            // btnDOWN
            // 
            this.btnDOWN.Location = new System.Drawing.Point(18, 112);
            this.btnDOWN.Name = "btnDOWN";
            this.btnDOWN.Size = new System.Drawing.Size(124, 32);
            this.btnDOWN.TabIndex = 2;
            this.btnDOWN.Text = "Descargar y Apagar";
            this.btnDOWN.UseVisualStyleBackColor = true;
            this.btnDOWN.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(361, 78);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "0%";
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(18, 72);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(316, 23);
            this.progreso.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Programar apagado";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(18, 196);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(108, 20);
            this.txtTime.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutos";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(18, 230);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(82, 28);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.btnDOWN);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnDOWN;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}

