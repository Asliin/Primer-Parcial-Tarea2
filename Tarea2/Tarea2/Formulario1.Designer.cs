namespace Tarea2
{
    partial class Formulario1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrimerParcialTextBox = new System.Windows.Forms.TextBox();
            this.SegundoParcialTextBox = new System.Windows.Forms.TextBox();
            this.TercerParcialTextBox = new System.Windows.Forms.TextBox();
            this.CuartoParcialTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calificaciones Finales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A continuación, ingrese las calificaciones del estudiante por parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tercer parcial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cuarto parcial:";
            // 
            // PrimerParcialTextBox
            // 
            this.PrimerParcialTextBox.Location = new System.Drawing.Point(176, 166);
            this.PrimerParcialTextBox.Name = "PrimerParcialTextBox";
            this.PrimerParcialTextBox.Size = new System.Drawing.Size(197, 26);
            this.PrimerParcialTextBox.TabIndex = 6;
            // 
            // SegundoParcialTextBox
            // 
            this.SegundoParcialTextBox.Location = new System.Drawing.Point(176, 226);
            this.SegundoParcialTextBox.Name = "SegundoParcialTextBox";
            this.SegundoParcialTextBox.Size = new System.Drawing.Size(197, 26);
            this.SegundoParcialTextBox.TabIndex = 7;
            // 
            // TercerParcialTextBox
            // 
            this.TercerParcialTextBox.Location = new System.Drawing.Point(176, 286);
            this.TercerParcialTextBox.Name = "TercerParcialTextBox";
            this.TercerParcialTextBox.Size = new System.Drawing.Size(197, 26);
            this.TercerParcialTextBox.TabIndex = 8;
            // 
            // CuartoParcialTextBox
            // 
            this.CuartoParcialTextBox.Location = new System.Drawing.Point(176, 346);
            this.CuartoParcialTextBox.Name = "CuartoParcialTextBox";
            this.CuartoParcialTextBox.Size = new System.Drawing.Size(197, 26);
            this.CuartoParcialTextBox.TabIndex = 9;
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(468, 253);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(175, 96);
            this.CalcularButton.TabIndex = 10;
            this.CalcularButton.Text = "Calcular Promedio Final";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Formulario1
            // 
            this.AcceptButton = this.CalcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.CuartoParcialTextBox);
            this.Controls.Add(this.TercerParcialTextBox);
            this.Controls.Add(this.SegundoParcialTextBox);
            this.Controls.Add(this.PrimerParcialTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aslin Lesmani Cueva Martínez - 20181003242";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrimerParcialTextBox;
        private System.Windows.Forms.TextBox SegundoParcialTextBox;
        private System.Windows.Forms.TextBox TercerParcialTextBox;
        private System.Windows.Forms.TextBox CuartoParcialTextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}

