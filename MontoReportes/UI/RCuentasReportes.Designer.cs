namespace MontoReportes.UI
{
    partial class RCuentasReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DepcripciontextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipocomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CuentadataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.NuevaCuentasbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuentadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(114, 44);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // DepcripciontextBox
            // 
            this.DepcripciontextBox.Location = new System.Drawing.Point(114, 95);
            this.DepcripciontextBox.Name = "DepcripciontextBox";
            this.DepcripciontextBox.Size = new System.Drawing.Size(243, 22);
            this.DepcripciontextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.DecimalPlaces = 2;
            this.MontonumericUpDown.Location = new System.Drawing.Point(114, 147);
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.MontonumericUpDown.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuevaCuentasbutton);
            this.groupBox1.Controls.Add(this.Addbutton);
            this.groupBox1.Controls.Add(this.TipocomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CuentadataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo De Cuenta";
            // 
            // TipocomboBox
            // 
            this.TipocomboBox.DropDownStyle = this.TipocomboBox.DropDownStyle;
            this.TipocomboBox.FormattingEnabled = true;
            this.TipocomboBox.Location = new System.Drawing.Point(102, 31);
            this.TipocomboBox.Name = "TipocomboBox";
            this.TipocomboBox.Size = new System.Drawing.Size(104, 24);
            this.TipocomboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "TipoDecuenta";
            // 
            // CuentadataGridView
            // 
            this.CuentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuentadataGridView.Location = new System.Drawing.Point(3, 71);
            this.CuentadataGridView.Name = "CuentadataGridView";
            this.CuentadataGridView.RowTemplate.Height = 24;
            this.CuentadataGridView.Size = new System.Drawing.Size(348, 137);
            this.CuentadataGridView.TabIndex = 0;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::MontoReportes.Properties.Resources.delete;
            this.Eliminarbutton.Location = new System.Drawing.Point(264, 492);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 61);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::MontoReportes.Properties.Resources.save;
            this.Guardarbutton.Location = new System.Drawing.Point(143, 492);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 61);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::MontoReportes.Properties.Resources.document_new;
            this.Nuevobutton.Location = new System.Drawing.Point(22, 492);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 61);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::MontoReportes.Properties.Resources.search;
            this.Buscarbutton.Location = new System.Drawing.Point(242, 25);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 58);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Image = global::MontoReportes.Properties.Resources.icons8_plus_math_48;
            this.Addbutton.Location = new System.Drawing.Point(282, 22);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 33);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // NuevaCuentasbutton
            // 
            this.NuevaCuentasbutton.Location = new System.Drawing.Point(212, 22);
            this.NuevaCuentasbutton.Name = "NuevaCuentasbutton";
            this.NuevaCuentasbutton.Size = new System.Drawing.Size(64, 32);
            this.NuevaCuentasbutton.TabIndex = 4;
            this.NuevaCuentasbutton.Text = "Nueva ";
            this.NuevaCuentasbutton.UseVisualStyleBackColor = true;
            this.NuevaCuentasbutton.Click += new System.EventHandler(this.NuevaCuentasbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(114, 200);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.FechadateTimePicker.TabIndex = 12;
            // 
            // RCuentasReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 565);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepcripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "RCuentasReportes";
            this.Text = "RCuentasReportes";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CuentadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepcripciontextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TipocomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CuentadataGridView;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button NuevaCuentasbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label5;
    }
}