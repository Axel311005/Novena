using Microsoft.Data.SqlClient;
using Novena.IRepository;
using Novena.IRepository.Repository;
using Novena.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novena
{
    public partial class frmAdd : Form
    {

        KidRepository kid;
        public int idKid;
        public frmAdd()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            kid = new KidRepository(connectionString);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            try
            {
                var kids = kid.GetAll();
                dgvKids.DataSource = kids;
                dgvKids.Columns["id_kid"].Visible = false;

                List<string> sexos = new List<string>
                {
                    "Masculino", "Femenino"
                };
                cboSexo.DataSource = sexos;

                List<string> edades = new List<string>
                {
                    "1m","2m","3m","4m","5m","6m","7m","8m","9m","10m","11m","1","2","3","4","5","6","7","8","9","10","11","12","13"
                };

                txtEdad.DataSource = edades;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddKid_Click(object sender, EventArgs e)
        {
            try
            {
                Kid k = new Kid
                {
                    Primer_Nombre = txtPrimerNombre.Text,
                    Segundo_Nombre = txtSegundoNombre.Text,
                    Primer_Apellido = txtPrimerApellido.Text,
                    Segundo_Apellido = txtSegundoApellido.Text,
                    Edad = txtEdad.Text,
                    Sexo = cboSexo.Text,
                };

                kid.Add(k);
                MessageBox.Show("Niño Agregado correctamente");
                LimpiarText();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar " + ex.Message);

            }
        }

        private void btnUpdateKid_Click(object sender, EventArgs e)
        {
            if (dgvKids.SelectedRows.Count > 0)
            {
                try
                {
                    
                    var update = new Kid
                    {
                        Id_Kid = idKid,
                        Primer_Nombre = txtPrimerNombre.Text,
                        Segundo_Nombre = txtSegundoNombre.Text,
                        Primer_Apellido = txtPrimerApellido.Text,
                        Segundo_Apellido = txtSegundoApellido.Text,
                        Edad = txtEdad.Text,
                        Sexo = cboSexo.Text,
                    };
                    kid.Update(update, 0);
                    MessageBox.Show("Niño Actualizado correctamente");
                    Refresh();
                    LimpiarText();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar " + ex.Message);
                }
            }
        }

        private void LimpiarText()
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();

        }

        private void btnDeleteKid_Click(object sender, EventArgs e)
        {
            if (dgvKids.Rows.Count > 0)
            {
                var result =
                     MessageBox.Show($"¿Está seguro de que desea eliminar el niño '{txtPrimerNombre.Text}'?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        kid.Delete(idKid);
                        MessageBox.Show("¡Niño eliminado exitosamente!", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        LimpiarText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar niño: {ex.Message}",
                                                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un niño para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKids_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvKids.Rows[e.RowIndex];

            //    Kid k = new Kid
            //    {
            //        Primer_Nombre = row.Cells["Primer_Nombre"]?.Value?.ToString(),
            //        Segundo_Nombre = row.Cells["Segundo_Nombre"]?.Value?.ToString(),
            //        Primer_Apellido = row.Cells["Primer_Apellido"]?.Value?.ToString(),
            //        Segundo_Apellido = row.Cells["Segundo_Apellido"]?.Value?.ToString(),
            //        Edad = Convert.ToInt32(row.Cells["Edad"]?.Value?.ToString()),
            //        Sexo = row.Cells["Sexo"]?.Value?.ToString(),
            //    };
            //    idKid = Convert.ToInt32(row.Cells["Id_Kid"].Value);
            //    txtPrimerNombre.Text = k.Primer_Nombre;
            //    txtSegundoNombre.Text= k.Segundo_Nombre;
            //    txtPrimerApellido.Text = k.Primer_Apellido;
            //    txtSegundoApellido.Text = k.Segundo_Apellido;
            //    txtEdad.Text = k.Edad.ToString();
            //    cboSexo.Text = k.Sexo;

            //}

            // Verifica que no se esté haciendo click en la fila vacía (nueva fila) o fuera del índice válido
            if (e.RowIndex < 0 || dgvKids.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow row = dgvKids.Rows[e.RowIndex];

            // Verifica si las celdas contienen valores antes de intentar asignarlas
            if (row.Cells["Primer_Nombre"].Value == null || row.Cells["Id_kid"].Value == null)
                return;

            Kid k = new Kid
            {
                Primer_Nombre = row.Cells["Primer_Nombre"].Value?.ToString(),
                Segundo_Nombre = row.Cells["Segundo_Nombre"].Value?.ToString(),
                Primer_Apellido = row.Cells["Primer_Apellido"]?.Value?.ToString(),
                Segundo_Apellido = row.Cells["Segundo_Apellido"]?.Value?.ToString(),
                Edad = row.Cells["Edad"]?.Value?.ToString(),
                Sexo = row.Cells["Sexo"]?.Value?.ToString()
            };

            idKid = Convert.ToInt32(row.Cells["Id_kid"].Value);
            txtPrimerNombre.Text = k.Primer_Nombre;
            txtSegundoNombre.Text = k.Segundo_Nombre;
            txtPrimerApellido.Text = k.Primer_Apellido;
            txtSegundoApellido.Text = k.Segundo_Apellido;
            txtEdad.Text = k.Edad.ToString();
            cboSexo.Text = k.Sexo;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscador.Text.Trim();

            DataTable resultado = kid.BuscarPorNombre(nombreBuscado);

            dgvKids.DataSource = resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ' &&
                !"áéíóúÁÉÍÓÚüÜñÑ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ' &&
                !"áéíóúÁÉÍÓÚüÜñÑ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ' &&
                !"áéíóúÁÉÍÓÚüÜñÑ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ' &&
                !"áéíóúÁÉÍÓÚüÜñÑ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ' &&
                !"áéíóúÁÉÍÓÚüÜñÑ".Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
