namespace CitasMedicas_ProgramaEscritorio
{
    partial class AllCitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCitas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsCitas1 = new CitasMedicas_ProgramaEscritorio.dsCitas();
            this.citasTableAdapter1 = new CitasMedicas_ProgramaEscritorio.dsCitasTableAdapters.citasTableAdapter();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorioCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCitas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCitaDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.horaCitaDataGridViewTextBoxColumn,
            this.consultorioCitaDataGridViewTextBoxColumn,
            this.hospitalCitaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.citasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(832, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(93, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem2.Text = "Salir";
            // 
            // dsCitas1
            // 
            this.dsCitas1.DataSetName = "dsCitas";
            this.dsCitas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasTableAdapter1
            // 
            this.citasTableAdapter1.ClearBeforeFill = true;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "citas";
            this.citasBindingSource.DataSource = this.dsCitas1;
            // 
            // idCitaDataGridViewTextBoxColumn
            // 
            this.idCitaDataGridViewTextBoxColumn.DataPropertyName = "idCita";
            this.idCitaDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.idCitaDataGridViewTextBoxColumn.Name = "idCitaDataGridViewTextBoxColumn";
            this.idCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCitaDataGridViewTextBoxColumn.Width = 50;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "idPaciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "NSS Paciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "fechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaCitaDataGridViewTextBoxColumn
            // 
            this.horaCitaDataGridViewTextBoxColumn.DataPropertyName = "horaCita";
            this.horaCitaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaCitaDataGridViewTextBoxColumn.Name = "horaCitaDataGridViewTextBoxColumn";
            this.horaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultorioCitaDataGridViewTextBoxColumn
            // 
            this.consultorioCitaDataGridViewTextBoxColumn.DataPropertyName = "consultorioCita";
            this.consultorioCitaDataGridViewTextBoxColumn.HeaderText = "Consultorio";
            this.consultorioCitaDataGridViewTextBoxColumn.Name = "consultorioCitaDataGridViewTextBoxColumn";
            this.consultorioCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hospitalCitaDataGridViewTextBoxColumn
            // 
            this.hospitalCitaDataGridViewTextBoxColumn.DataPropertyName = "hospitalCita";
            this.hospitalCitaDataGridViewTextBoxColumn.HeaderText = "Hospital";
            this.hospitalCitaDataGridViewTextBoxColumn.Name = "hospitalCitaDataGridViewTextBoxColumn";
            this.hospitalCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(856, 333);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllCitas";
            this.Text = "AllCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCitas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultorioCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private dsCitas dsCitas1;
        private dsCitasTableAdapters.citasTableAdapter citasTableAdapter1;
    }
}