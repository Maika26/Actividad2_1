
namespace Actividad2_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBoxCurso = new System.Windows.Forms.ComboBox();
            this.GridAlumnos = new System.Windows.Forms.DataGridView();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxCurso
            // 
            this.CBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCurso.FormattingEnabled = true;
            this.CBoxCurso.Location = new System.Drawing.Point(69, 168);
            this.CBoxCurso.Name = "CBoxCurso";
            this.CBoxCurso.Size = new System.Drawing.Size(216, 24);
            this.CBoxCurso.TabIndex = 0;
            this.CBoxCurso.SelectedIndexChanged += new System.EventHandler(this.CBoxCurso_SelectedIndexChanged);
            // 
            // GridAlumnos
            // 
            this.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlumnos.Location = new System.Drawing.Point(442, 133);
            this.GridAlumnos.Name = "GridAlumnos";
            this.GridAlumnos.RowHeadersWidth = 51;
            this.GridAlumnos.RowTemplate.Height = 24;
            this.GridAlumnos.Size = new System.Drawing.Size(341, 403);
            this.GridAlumnos.TabIndex = 1;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(69, 411);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.ReadOnly = true;
            this.txtProfesor.Size = new System.Drawing.Size(216, 22);
            this.txtProfesor.TabIndex = 2;
            this.txtProfesor.TextChanged += new System.EventHandler(this.CBoxCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alumnos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.GridAlumnos);
            this.Controls.Add(this.CBoxCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxCurso;
        private System.Windows.Forms.DataGridView GridAlumnos;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

