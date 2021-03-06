﻿namespace ProyectoGetHospi.Vista
{
    partial class ActualizarMed
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
            System.Windows.Forms.Label cedulaMedicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarMed));
            this.dgvMedA = new System.Windows.Forms.DataGridView();
            this.IdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbMedA = new System.Windows.Forms.GroupBox();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.grbMedA.SuspendLayout();
            this.SuspendLayout();
            // 
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaMedicoLabel.Location = new System.Drawing.Point(20, 61);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(129, 20);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Medico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(23, 151);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(84, 20);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dUILabel.Location = new System.Drawing.Point(23, 122);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(40, 20);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idMedicoLabel.Location = new System.Drawing.Point(20, 33);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(90, 20);
            idMedicoLabel.TabIndex = 6;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(23, 92);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(23, 180);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // dgvMedA
            // 
            this.dgvMedA.AllowUserToAddRows = false;
            this.dgvMedA.AllowUserToDeleteRows = false;
            this.dgvMedA.AutoGenerateColumns = false;
            this.dgvMedA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgvMedA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMedA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvMedA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedico});
            this.dgvMedA.DataSource = this.médicoBindingSource;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedA.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvMedA.EnableHeadersVisualStyles = false;
            this.dgvMedA.Location = new System.Drawing.Point(17, 55);
            this.dgvMedA.Name = "dgvMedA";
            this.dgvMedA.ReadOnly = true;
            this.dgvMedA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedA.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvMedA.Size = new System.Drawing.Size(390, 240);
            this.dgvMedA.TabIndex = 1;
            // 
            // IdMedico
            // 
            this.IdMedico.DataPropertyName = "IdMedico";
            this.IdMedico.HeaderText = "IdMedico";
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.ReadOnly = true;
            // 
            // grbMedA
            // 
            this.grbMedA.Controls.Add(cedulaMedicoLabel);
            this.grbMedA.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMedA.Controls.Add(direccionLabel);
            this.grbMedA.Controls.Add(this.direccionTextBox);
            this.grbMedA.Controls.Add(dUILabel);
            this.grbMedA.Controls.Add(this.dUITextBox);
            this.grbMedA.Controls.Add(idMedicoLabel);
            this.grbMedA.Controls.Add(this.idMedicoTextBox);
            this.grbMedA.Controls.Add(nombreLabel);
            this.grbMedA.Controls.Add(this.nombreTextBox);
            this.grbMedA.Controls.Add(telefonoLabel);
            this.grbMedA.Controls.Add(this.telefonoTextBox);
            this.grbMedA.Location = new System.Drawing.Point(423, 80);
            this.grbMedA.Name = "grbMedA";
            this.grbMedA.Size = new System.Drawing.Size(355, 215);
            this.grbMedA.TabIndex = 2;
            this.grbMedA.TabStop = false;
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(166, 62);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(164, 19);
            this.cedulaMedicoTextBox.TabIndex = 1;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(166, 152);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(164, 19);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dUITextBox
            // 
            this.dUITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "DUI", true));
            this.dUITextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dUITextBox.Location = new System.Drawing.Point(166, 123);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(164, 19);
            this.dUITextBox.TabIndex = 5;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "IdMedico", true));
            this.idMedicoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMedicoTextBox.Location = new System.Drawing.Point(166, 33);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(164, 19);
            this.idMedicoTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(166, 93);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(164, 19);
            this.nombreTextBox.TabIndex = 9;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(166, 181);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(164, 19);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // btnSeleccionMed
            // 
            this.btnSeleccionMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionMed.FlatAppearance.BorderSize = 0;
            this.btnSeleccionMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionMed.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionMed.Image")));
            this.btnSeleccionMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionMed.Location = new System.Drawing.Point(132, 301);
            this.btnSeleccionMed.Name = "btnSeleccionMed";
            this.btnSeleccionMed.Size = new System.Drawing.Size(115, 31);
            this.btnSeleccionMed.TabIndex = 3;
            this.btnSeleccionMed.Text = "Seleccionar";
            this.btnSeleccionMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionMed.UseVisualStyleBackColor = false;
            this.btnSeleccionMed.Click += new System.EventHandler(this.btnSeleccionMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardarMed.FlatAppearance.BorderSize = 0;
            this.btnGuardarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMed.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMed.Image")));
            this.btnGuardarMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMed.Location = new System.Drawing.Point(535, 301);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(103, 31);
            this.btnGuardarMed.TabIndex = 4;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMed.UseVisualStyleBackColor = false;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Actualizar Médico";
            // 
            // ActualizarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(790, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnSeleccionMed);
            this.Controls.Add(this.grbMedA);
            this.Controls.Add(this.dgvMedA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ActualizarMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.grbMedA.ResumeLayout(false);
            this.grbMedA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource médicoBindingSource;
        private System.Windows.Forms.DataGridView dgvMedA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grbMedA;
        private System.Windows.Forms.TextBox cedulaMedicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button btnSeleccionMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Label label1;
    }
}