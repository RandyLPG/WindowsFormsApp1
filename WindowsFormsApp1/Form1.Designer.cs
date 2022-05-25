namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SueldoBruto = new System.Windows.Forms.TextBox();
            this.Calculos = new System.Windows.Forms.Button();
            this.DGVdeducciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Bruto";
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.Location = new System.Drawing.Point(138, 24);
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.Size = new System.Drawing.Size(100, 22);
            this.SueldoBruto.TabIndex = 1;
            // 
            // Calculos
            // 
            this.Calculos.Location = new System.Drawing.Point(244, 16);
            this.Calculos.Name = "Calculos";
            this.Calculos.Size = new System.Drawing.Size(72, 39);
            this.Calculos.TabIndex = 2;
            this.Calculos.Text = "Calcular";
            this.Calculos.UseVisualStyleBackColor = true;
            this.Calculos.Click += new System.EventHandler(this.Calculos_Click);
            // 
            // DGVdeducciones
            // 
            this.DGVdeducciones.BackgroundColor = System.Drawing.Color.Salmon;
            this.DGVdeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdeducciones.Location = new System.Drawing.Point(12, 68);
            this.DGVdeducciones.Name = "DGVdeducciones";
            this.DGVdeducciones.RowHeadersWidth = 51;
            this.DGVdeducciones.RowTemplate.Height = 24;
            this.DGVdeducciones.Size = new System.Drawing.Size(776, 370);
            this.DGVdeducciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVdeducciones);
            this.Controls.Add(this.Calculos);
            this.Controls.Add(this.SueldoBruto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SueldoBruto;
        private System.Windows.Forms.Button Calculos;
        private System.Windows.Forms.DataGridView DGVdeducciones;
    }
}


