﻿
namespace CapaVistaPolizas
{
    partial class frmTipoPoliza
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
            this.btntTpoPoliza = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPoliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgPoliza = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPoliza)).BeginInit();
            this.SuspendLayout();
            // 
            // btntTpoPoliza
            // 
            this.btntTpoPoliza.BackColor = System.Drawing.Color.Transparent;
            this.btntTpoPoliza.Image = global::CapaVistaPolizas.Properties.Resources.agregar1;
            this.btntTpoPoliza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntTpoPoliza.Location = new System.Drawing.Point(37, 148);
            this.btntTpoPoliza.Name = "btntTpoPoliza";
            this.btntTpoPoliza.Size = new System.Drawing.Size(73, 74);
            this.btntTpoPoliza.TabIndex = 19;
            this.btntTpoPoliza.Text = "Ingresar";
            this.btntTpoPoliza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btntTpoPoliza.UseVisualStyleBackColor = false;
            this.btntTpoPoliza.Click += new System.EventHandler(this.btntTpoPoliza_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(135, 83);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(176, 20);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripción:";
            // 
            // txtIdPoliza
            // 
            this.txtIdPoliza.Location = new System.Drawing.Point(135, 39);
            this.txtIdPoliza.Name = "txtIdPoliza";
            this.txtIdPoliza.Size = new System.Drawing.Size(176, 20);
            this.txtIdPoliza.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Tipo Póliza:";
            // 
            // dvgPoliza
            // 
            this.dvgPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPoliza.Location = new System.Drawing.Point(330, 26);
            this.dvgPoliza.Name = "dvgPoliza";
            this.dvgPoliza.Size = new System.Drawing.Size(564, 186);
            this.dvgPoliza.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Image = global::CapaVistaPolizas.Properties.Resources.consulta;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(135, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reporte";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::CapaVistaPolizas.Properties.Resources.buscar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(227, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 74);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ayuda";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTipoPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaPolizas.Properties.Resources._3df38d07_8b18_4ed4_a423_5c4f23c7f07a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvgPoliza);
            this.Controls.Add(this.btntTpoPoliza);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdPoliza);
            this.Controls.Add(this.label1);
            this.Name = "frmTipoPoliza";
            this.Text = "TipoPoliza";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPoliza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntTpoPoliza;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgPoliza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}