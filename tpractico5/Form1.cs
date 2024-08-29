using System.Windows.Forms;

namespace tpractico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tsaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && Tsaldo.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void Bfoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string rutaImagen = openFileDialog.FileName;
                tfotos.Image = Image.FromFile(rutaImagen);

                Rfoto.Text = rutaImagen;
            }
        }

        private void FormatTextBox(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string text = textBox.Text;
                textBox.TextChanged -= Tapellido_TextChanged;
                textBox.TextChanged -= Tnombre_TextChanged;

                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;

                textBox.TextChanged += Tapellido_TextChanged;
                textBox.TextChanged += Tnombre_TextChanged;
            }
        }

        private void Tnombre_TextChanged(object sender, EventArgs e)
        {
            FormatTextBox(sender as TextBox);
        }

        private void Tapellido_TextChanged(object sender, EventArgs e)
        {
            FormatTextBox(sender as TextBox);
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            String name = Tnombre.Text.Trim();
            String surname = Tapellido.Text.Trim();
            String saldo = Tsaldo.Text.Trim();
            String path = Rfoto.Text.Trim();
           

            if (name == "" || surname == "" || saldo == "" || path == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!saldo.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo DNI.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!name.All(char.IsLetter) || !surname.All(char.IsLetter))
            {
                MessageBox.Show("Por favor, ingrese solo letras en los campos Nombre y Apellidos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!CBhombre.Checked && !CBmujer.Checked)
            {
                MessageBox.Show("Por favor, seleccione un genero.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String fecha = fechanac.Value.ToString("dd/MM/yyyy");
            Image img = null;
            try
            {
                img = Image.FromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CBhombre.Checked)
            {
                DialogResult ask = MessageBox.Show(
                   "¿Seguro que desea insertar un nuevo Cliente?",
                   "Confirmar Insercion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + name + " " + surname + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Add(name, surname, fecha, "Hombre", new DataGridViewButtonCell() { Value = "Eliminar" }, saldo, img , path);
                }

            }
            else
            {
                DialogResult ask = MessageBox.Show(
               "¿Seguro que desea insertar una nueva Clienta?",
               "Confirmar Insercion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("La clienta " + name + " " + surname + " ha sido insertado con exito.", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Add(name, surname, fecha, "Mujer", new DataGridViewButtonCell() { Value = "Eliminar" }, saldo, img, path);
                }
            }
            if (Int32.Parse(saldo) < 50)
            {
                int rowIndex = dataGridView1.Rows.Count - 1;

                
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta usuario?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                  
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sexo" && e.RowIndex >= 0)
            {
                string sexo = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (sexo == "Hombre")
                {
                    CBhombre.Checked = true;
                    CBmujer.Checked = false;
                }
                else
                {
                    CBmujer.Checked = true;
                    CBhombre.Checked = false;

                }
            }
            }
    }
}
