
namespace Gomez.AlejandroUlises._2A.TPFinal
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuariosPlanes = new System.Windows.Forms.Label();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.btnEliminarPlan = new System.Windows.Forms.Button();
            this.btnModificarPlan = new System.Windows.Forms.Button();
            this.dtgvPlanes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBiblioteca
            // 
            this.dtgvBiblioteca.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBiblioteca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBiblioteca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBiblioteca.Location = new System.Drawing.Point(178, 12);
            this.dtgvBiblioteca.Name = "dtgvBiblioteca";
            this.dtgvBiblioteca.RowTemplate.Height = 25;
            this.dtgvBiblioteca.Size = new System.Drawing.Size(745, 283);
            this.dtgvBiblioteca.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(12, 79);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(160, 51);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarUsuario.Location = new System.Drawing.Point(12, 136);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(160, 51);
            this.btnModificarUsuario.TabIndex = 2;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(12, 193);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(160, 51);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPlan.Location = new System.Drawing.Point(12, 359);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(160, 51);
            this.btnAgregarPlan.TabIndex = 4;
            this.btnAgregarPlan.Text = "Agregar";
            this.btnAgregarPlan.UseVisualStyleBackColor = true;
            this.btnAgregarPlan.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(680, 473);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lblUsuariosPlanes
            // 
            this.lblUsuariosPlanes.AutoSize = true;
            this.lblUsuariosPlanes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuariosPlanes.Location = new System.Drawing.Point(12, 12);
            this.lblUsuariosPlanes.Name = "lblUsuariosPlanes";
            this.lblUsuariosPlanes.Size = new System.Drawing.Size(160, 47);
            this.lblUsuariosPlanes.TabIndex = 6;
            this.lblUsuariosPlanes.Text = "Usuarios";
            // 
            // lblPlanes
            // 
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanes.Location = new System.Drawing.Point(12, 309);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(126, 47);
            this.lblPlanes.TabIndex = 7;
            this.lblPlanes.Text = "Planes";
            // 
            // btnEliminarPlan
            // 
            this.btnEliminarPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPlan.Location = new System.Drawing.Point(12, 473);
            this.btnEliminarPlan.Name = "btnEliminarPlan";
            this.btnEliminarPlan.Size = new System.Drawing.Size(160, 51);
            this.btnEliminarPlan.TabIndex = 8;
            this.btnEliminarPlan.Text = "Eliminar";
            this.btnEliminarPlan.UseVisualStyleBackColor = true;
            this.btnEliminarPlan.Click += new System.EventHandler(this.btnEliminarPlan_Click);
            // 
            // btnModificarPlan
            // 
            this.btnModificarPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarPlan.Location = new System.Drawing.Point(12, 416);
            this.btnModificarPlan.Name = "btnModificarPlan";
            this.btnModificarPlan.Size = new System.Drawing.Size(160, 51);
            this.btnModificarPlan.TabIndex = 9;
            this.btnModificarPlan.Text = "Modificar";
            this.btnModificarPlan.UseVisualStyleBackColor = true;
            this.btnModificarPlan.Click += new System.EventHandler(this.btnModificarPlan_Click);
            // 
            // dtgvPlanes
            // 
            this.dtgvPlanes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPlanes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvPlanes.Location = new System.Drawing.Point(178, 309);
            this.dtgvPlanes.Name = "dtgvPlanes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvPlanes.RowTemplate.Height = 25;
            this.dtgvPlanes.Size = new System.Drawing.Size(445, 215);
            this.dtgvPlanes.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 532);
            this.Controls.Add(this.dtgvPlanes);
            this.Controls.Add(this.btnModificarPlan);
            this.Controls.Add(this.btnEliminarPlan);
            this.Controls.Add(this.lblPlanes);
            this.Controls.Add(this.lblUsuariosPlanes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarPlan);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dtgvBiblioteca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomez.AlejandroUlises.2A";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBiblioteca;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnAgregarPlan;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuariosPlanes;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.Button btnEliminarPlan;
        private System.Windows.Forms.Button btnModificarPlan;
        private System.Windows.Forms.DataGridView dtgvPlanes;
    }
}

