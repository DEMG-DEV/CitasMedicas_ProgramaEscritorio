namespace CitasMedicas_ProgramaEscritorio
{
    partial class BajaCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaCita));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsCitas1 = new CitasMedicas_ProgramaEscritorio.dsCitas();
            this.citasTableAdapter1 = new CitasMedicas_ProgramaEscritorio.dsCitasTableAdapters.citasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorioCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clCitasBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCitas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 164);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Folio Cita";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clCitasBindingSource, "IdCita", true));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.textBox1.Location = new System.Drawing.Point(13, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 34;
            // 
            // clCitasBindingSource
            // 
            this.clCitasBindingSource.DataSource = typeof(CitasMedicas_ProgramaEscritorio.clCitas);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clCitasBindingSource, "FechaCita", true));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.textBox5.Location = new System.Drawing.Point(13, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(160, 22);
            this.textBox5.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 12);
            this.label15.TabIndex = 33;
            this.label15.Text = "DD/MM/YYYY";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.button2.Image = global::CitasMedicas_ProgramaEscritorio.Properties.Resources.edit_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(480, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de la Cita";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.button1.Image = global::CitasMedicas_ProgramaEscritorio.Properties.Resources.export_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(594, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cancelar Cita";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clCitasBindingSource, "HoraCita", true));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.textBox6.Location = new System.Drawing.Point(193, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 22);
            this.textBox6.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hospital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hora de la Cita";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clCitasBindingSource, "HospitalCita", true));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.textBox8.Location = new System.Drawing.Point(548, 49);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(160, 22);
            this.textBox8.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clCitasBindingSource, "ConsultorioCita", true));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.textBox7.Location = new System.Drawing.Point(373, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(160, 22);
            this.textBox7.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Consultorio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 4;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(735, 242);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "citas";
            this.citasBindingSource.DataSource = this.dsCitas1;
            // 
            // BajaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BajaCita";
            this.Text = "BajaCita";
            this.Load += new System.EventHandler(this.BajaCita_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clCitasBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCitas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clCitasBindingSource;
        private dsCitas dsCitas1;
        private dsCitasTableAdapters.citasTableAdapter citasTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultorioCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalCitaDataGridViewTextBoxColumn;
    }
}