namespace PracticaWinForms
{
    partial class Formulario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ListaTornillos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTornillos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(53, 80);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(102, 15);
            this.lblFechaCreacion.TabIndex = 1;
            this.lblFechaCreacion.Text = "Fecha de creación";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(53, 111);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(55, 15);
            this.lblLongitud.TabIndex = 2;
            this.lblLongitud.Text = "Longitud";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(47, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Añadir";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(128, 140);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modificar";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(209, 140);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Eliminar";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListaTornillos
            // 
            this.ListaTornillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaTornillos.Location = new System.Drawing.Point(44, 193);
            this.ListaTornillos.Name = "ListaTornillos";
            this.ListaTornillos.RowTemplate.Height = 25;
            this.ListaTornillos.Size = new System.Drawing.Size(834, 278);
            this.ListaTornillos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(239, 80);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaCreacion.TabIndex = 8;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(239, 111);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 23);
            this.txtLongitud.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(53, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 15);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(239, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 11;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(690, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 483);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.ListaTornillos);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Formulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.ListaTornillos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblFechaCreacion;
        private Label lblLongitud;
        private Button AddButton;
        private Button ModifyButton;
        private Button DeleteButton;
        private DataGridView ListaTornillos;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtLongitud;
        private Label ID;
        private TextBox txtID;
        private Button CancelButton;
    }
}