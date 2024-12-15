using Microsoft.Data.SqlClient;
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
    public partial class frmAsistencias : Form
    {

        AsistenciaRepository asistencia;
        public int idAsist;
        public int idKid;
        public frmAsistencias()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            asistencia = new AsistenciaRepository(connectionString);
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            try
            {

                var asist = asistencia.GetAll();
                dgvAsistencia.DataSource = asist;


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

        private void btnAddAsist_Click(object sender, EventArgs e)
        {
            try
            {
                Asistencia asit = new Asistencia
                {
                    Id_Kid = idKid,
                    Day1 = chbDay1.Checked,
                    Day2 = chbDay2.Checked,
                    Day3 = chbDay3.Checked,
                    Day4 = chbDay4.Checked,
                    Day5 = chbDay5.Checked,
                    Day6 = chbDay6.Checked,
                    Day7 = chbDay7.Checked,
                    Day8 = chbDay8.Checked,
                    Day9 = chbDay9.Checked,
                };
                asistencia.Add(asit);
                MessageBox.Show("Asistencia Agregada correctamente");
                Refresh();
                LimpiarText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar asistencia " + ex.Message);
            }
        }

        private void btnUpdateAsist_Click(object sender, EventArgs e)
        {
            if (dgvAsistencia.SelectedRows.Count > 0)
            {
                try
                {
                    var update = new Asistencia
                    {
                        Id_Asistencia = idAsist,
                        Id_Kid = idKid,
                        Day1 = chbDay1.Checked,
                        Day2 = chbDay2.Checked,
                        Day3 = chbDay3.Checked,
                        Day4 = chbDay4.Checked,
                        Day5 = chbDay5.Checked,
                        Day6 = chbDay6.Checked,
                        Day7 = chbDay7.Checked,
                        Day8 = chbDay8.Checked,
                        Day9 = chbDay9.Checked,
                    };

                    asistencia.Update(update, 0);
                    MessageBox.Show("Asistencia Actualizada correctamente");
                    Refresh();
                    LimpiarText();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al actualizar la asistencia " + ex.Message);
                }
            }
        }

        private void LimpiarText()
        {
            txtNombreCompleto.Clear();
            chbDay1.Checked = false;
            chbDay2.Checked = false;
            chbDay3.Checked = false;
            chbDay4.Checked = false;
            chbDay5.Checked = false;
            chbDay6.Checked = false;
            chbDay7.Checked = false;
            chbDay8.Checked = false;
            chbDay9.Checked = false;
        }

        private void btnDeleteAsist_Click(object sender, EventArgs e)
        {
            if (dgvAsistencia.Rows.Count > 0)
            {
                var result =
                 MessageBox.Show($"¿Está seguro de que desea eliminar la asistencia de '{txtNombreCompleto.Text}'?",
                 "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        asistencia.Delete(idAsist);
                        MessageBox.Show("¡Asistencia eliminada exitosamente!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        LimpiarText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar asistencia: {ex.Message}",
                                                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una asistencia para eliminar.",
                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAsistencia.Rows[e.RowIndex];

                AsistenciaView asist = new AsistenciaView
                {
                    Nombre_Completo = row.Cells["Nombre_Completo"].Value?.ToString(),
                    edad = Convert.ToInt32(row.Cells["edad"].Value?.ToString()),
                    Day1 = Convert.ToBoolean(row.Cells["Day1"].Value),
                    Day2 = Convert.ToBoolean(row.Cells["Day2"].Value),
                    Day3 = Convert.ToBoolean(row.Cells["Day3"].Value),
                    Day4 = Convert.ToBoolean(row.Cells["Day4"].Value),
                    Day5 = Convert.ToBoolean(row.Cells["Day5"].Value),
                    Day6 = Convert.ToBoolean(row.Cells["Day6"].Value),
                    Day7 = Convert.ToBoolean(row.Cells["Day7"].Value),
                    Day8 = Convert.ToBoolean(row.Cells["Day8"].Value),
                    Day9 = Convert.ToBoolean(row.Cells["Day9"].Value),
                    id_kid = Convert.ToInt32(row.Cells["id_kid"].Value?.ToString()),
                };

                idAsist = Convert.ToInt32(row.Cells["id_asistencia"].Value?.ToString());
                chbDay1.Checked = asist.Day1;
                chbDay2.Checked = asist.Day2;
                chbDay3.Checked = asist.Day3;
                chbDay4.Checked = asist.Day4;
                chbDay5.Checked = asist.Day5;
                chbDay6.Checked = asist.Day6;
                chbDay7.Checked = asist.Day7;
                chbDay8.Checked = asist.Day8;
                chbDay9.Checked = asist.Day9;
                txtNombreCompleto.Text = asist.Nombre_Completo;
                idKid = Convert.ToInt32(row.Cells["id_kid"].Value?.ToString());

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtBuscador.Text.Trim();

            if (!string.IsNullOrEmpty(nombreCompleto))
            {
                DataTable resultados = asistencia.BuscarPorNombreCompleto(nombreCompleto);
                dgvAsistencia.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("Por favor, introduce un nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
