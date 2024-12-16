using Microsoft.Identity.Client;
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
    public partial class Estadisticas : Form
    {
        AsistenciaRepository asistencia;
        ExportarExcel excel = new ExportarExcel();

        public Estadisticas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            asistencia = new AsistenciaRepository(connectionString);
        }

        public void Refresh()
        {
            dgv10a13.DataSource = asistencia.Edades10a13();
            dgv7a9.DataSource = asistencia.Edades7a9();
            dgv4a6.DataSource= asistencia.Edades4a6();
            dgv0a3.DataSource = asistencia.Edades0a3();
        }

        private void btnExportar10a13_Click(object sender, EventArgs e)
        {
            excel.ExportarAExcelConEPPlus(dgv10a13);
        }

        private void btnExportar7a9_Click(object sender, EventArgs e)
        {
            excel.ExportarAExcelConEPPlus(dgv7a9);

        }

        private void btnExportar4a6_Click(object sender, EventArgs e)
        {
            excel.ExportarAExcelConEPPlus(dgv4a6);
        }

        private void btnExportar0a3_Click(object sender, EventArgs e)
        {
            excel.ExportarAExcelConEPPlus(dgv0a3);

        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
