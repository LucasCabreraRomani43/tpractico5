namespace tpractico5
{
    partial class Form1
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
            panel1 = new Panel();
            Bfoto = new Button();
            Bguardar = new Button();
            Rfoto = new TextBox();
            CBmujer = new RadioButton();
            CBhombre = new RadioButton();
            fechanac = new DateTimePicker();
            Tsaldo = new TextBox();
            Tapellido = new TextBox();
            Tnombre = new TextBox();
            Lsaldo = new Label();
            Lsexo = new Label();
            Lfecha = new Label();
            Lapellido = new Label();
            Lnombre = new Label();
            tfotos = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            sexo = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewButtonColumn();
            saldo = new DataGridViewTextBoxColumn();
            img = new DataGridViewImageColumn();
            path = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tfotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.imagen2;
            panel1.Controls.Add(Bfoto);
            panel1.Controls.Add(Bguardar);
            panel1.Controls.Add(Rfoto);
            panel1.Controls.Add(CBmujer);
            panel1.Controls.Add(CBhombre);
            panel1.Controls.Add(fechanac);
            panel1.Controls.Add(Tsaldo);
            panel1.Controls.Add(Tapellido);
            panel1.Controls.Add(Tnombre);
            panel1.Controls.Add(Lsaldo);
            panel1.Controls.Add(Lsexo);
            panel1.Controls.Add(Lfecha);
            panel1.Controls.Add(Lapellido);
            panel1.Controls.Add(Lnombre);
            panel1.Location = new Point(100, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 452);
            panel1.TabIndex = 0;
            // 
            // Bfoto
            // 
            Bfoto.Location = new Point(31, 323);
            Bfoto.Name = "Bfoto";
            Bfoto.Size = new Size(83, 41);
            Bfoto.TabIndex = 13;
            Bfoto.Text = "Foto";
            Bfoto.UseVisualStyleBackColor = true;
            Bfoto.Click += Bfoto_Click;
            // 
            // Bguardar
            // 
            Bguardar.ImageAlign = ContentAlignment.MiddleRight;
            Bguardar.Location = new Point(176, 388);
            Bguardar.Name = "Bguardar";
            Bguardar.Size = new Size(120, 47);
            Bguardar.TabIndex = 12;
            Bguardar.Text = "Guardar";
            Bguardar.UseVisualStyleBackColor = true;
            Bguardar.Click += Bguardar_Click;
            // 
            // Rfoto
            // 
            Rfoto.Location = new Point(126, 323);
            Rfoto.Name = "Rfoto";
            Rfoto.Size = new Size(194, 41);
            Rfoto.TabIndex = 11;
            // 
            // CBmujer
            // 
            CBmujer.AutoSize = true;
            CBmujer.BackColor = SystemColors.ActiveCaptionText;
            CBmujer.ForeColor = SystemColors.ControlLightLight;
            CBmujer.Location = new Point(269, 196);
            CBmujer.Name = "CBmujer";
            CBmujer.Size = new Size(88, 37);
            CBmujer.TabIndex = 10;
            CBmujer.TabStop = true;
            CBmujer.Text = "Mujer";
            CBmujer.UseVisualStyleBackColor = false;
            // 
            // CBhombre
            // 
            CBhombre.AutoSize = true;
            CBhombre.BackColor = SystemColors.ActiveCaptionText;
            CBhombre.ForeColor = SystemColors.ControlLightLight;
            CBhombre.Location = new Point(126, 196);
            CBhombre.Name = "CBhombre";
            CBhombre.Size = new Size(107, 37);
            CBhombre.TabIndex = 9;
            CBhombre.TabStop = true;
            CBhombre.Text = "Hombre";
            CBhombre.UseVisualStyleBackColor = false;
            // 
            // fechanac
            // 
            fechanac.Location = new Point(241, 135);
            fechanac.Name = "fechanac";
            fechanac.Size = new Size(135, 41);
            fechanac.TabIndex = 8;
            // 
            // Tsaldo
            // 
            Tsaldo.Location = new Point(126, 249);
            Tsaldo.Name = "Tsaldo";
            Tsaldo.Size = new Size(194, 41);
            Tsaldo.TabIndex = 7;
            Tsaldo.KeyPress += Tsaldo_KeyPress;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(126, 61);
            Tapellido.Name = "Tapellido";
            Tapellido.Size = new Size(194, 41);
            Tapellido.TabIndex = 6;
            Tapellido.TextChanged += Tapellido_TextChanged;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(126, 11);
            Tnombre.Name = "Tnombre";
            Tnombre.Size = new Size(194, 41);
            Tnombre.TabIndex = 5;
            Tnombre.TextChanged += Tnombre_TextChanged;
            Tnombre.KeyPress += Tnombre_KeyPress;
            // 
            // Lsaldo
            // 
            Lsaldo.AutoSize = true;
            Lsaldo.BackColor = SystemColors.ActiveCaptionText;
            Lsaldo.ForeColor = SystemColors.ControlLight;
            Lsaldo.Location = new Point(16, 257);
            Lsaldo.Name = "Lsaldo";
            Lsaldo.Size = new Size(78, 33);
            Lsaldo.TabIndex = 4;
            Lsaldo.Text = "Saldo:";
            // 
            // Lsexo
            // 
            Lsexo.AutoSize = true;
            Lsexo.BackColor = SystemColors.ActiveCaptionText;
            Lsexo.ForeColor = SystemColors.ControlLight;
            Lsexo.Location = new Point(16, 200);
            Lsexo.Name = "Lsexo";
            Lsexo.Size = new Size(70, 33);
            Lsexo.TabIndex = 3;
            Lsexo.Text = "Sexo:";
            // 
            // Lfecha
            // 
            Lfecha.AutoSize = true;
            Lfecha.BackColor = SystemColors.ActiveCaptionText;
            Lfecha.ForeColor = SystemColors.ControlLight;
            Lfecha.Location = new Point(16, 143);
            Lfecha.Name = "Lfecha";
            Lfecha.Size = new Size(210, 33);
            Lfecha.TabIndex = 2;
            Lfecha.Text = "Fecha de Nacimiento:";
            // 
            // Lapellido
            // 
            Lapellido.AutoSize = true;
            Lapellido.BackColor = SystemColors.ActiveCaptionText;
            Lapellido.ForeColor = SystemColors.ControlLight;
            Lapellido.Location = new Point(16, 69);
            Lapellido.Name = "Lapellido";
            Lapellido.Size = new Size(98, 33);
            Lapellido.TabIndex = 1;
            Lapellido.Text = "Apellido:";
            // 
            // Lnombre
            // 
            Lnombre.AutoSize = true;
            Lnombre.BackColor = SystemColors.ActiveCaptionText;
            Lnombre.ForeColor = SystemColors.ControlLight;
            Lnombre.Location = new Point(16, 19);
            Lnombre.Name = "Lnombre";
            Lnombre.Size = new Size(92, 33);
            Lnombre.TabIndex = 0;
            Lnombre.Text = "Nombre:";
            // 
            // tfotos
            // 
            tfotos.Image = Properties.Resources.avatar;
            tfotos.Location = new Point(640, 20);
            tfotos.Name = "tfotos";
            tfotos.Size = new Size(253, 267);
            tfotos.TabIndex = 1;
            tfotos.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, surname, fecha, sexo, eliminar, saldo, img, path });
            dataGridView1.Location = new Point(12, 512);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 173);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.HeaderText = "nombre";
            name.Name = "name";
            // 
            // surname
            // 
            surname.HeaderText = "Apellido";
            surname.Name = "surname";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // sexo
            // 
            sexo.HeaderText = "sexo";
            sexo.Name = "sexo";
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "eliminar";
            eliminar.Resizable = DataGridViewTriState.True;
            eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // saldo
            // 
            saldo.HeaderText = "Saldo";
            saldo.Name = "saldo";
            // 
            // img
            // 
            img.HeaderText = "imagen";
            img.Name = "img";
            img.Resizable = DataGridViewTriState.True;
            img.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // path
            // 
            path.HeaderText = "ruta";
            path.Name = "path";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagen;
            ClientSize = new Size(1028, 685);
            Controls.Add(dataGridView1);
            Controls.Add(tfotos);
            Controls.Add(panel1);
            Font = new Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Formulario con grid";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tfotos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Lapellido;
        private Label Lnombre;
        private Label Lsaldo;
        private Label Lsexo;
        private Label Lfecha;
        private TextBox Tsaldo;
        private TextBox Tapellido;
        private TextBox Tnombre;
        private DateTimePicker fechanac;
        private RadioButton CBmujer;
        private RadioButton CBhombre;
        private Button Bguardar;
        private TextBox Rfoto;
        private PictureBox tfotos;
        private Button Bfoto;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn sexo;
        private DataGridViewButtonColumn eliminar;
        private DataGridViewTextBoxColumn saldo;
        private DataGridViewImageColumn img;
        private DataGridViewTextBoxColumn path;
    }
}
