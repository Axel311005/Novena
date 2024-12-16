using Microsoft.Data.SqlClient;
using Novena.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novena.IRepository.Repository
{
    public class AsistenciaRepository : IRepository<Asistencia>
    {
        private readonly string _connectionString;

        public AsistenciaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Asistencia asistencia)
        {
            string query = @"INSERT INTO Asistencia (id_kid, Day1, Day2, Day3, Day4, Day5, Day6, Day7, Day8, Day9)
                         VALUES (@idKid, @Day1, @Day2, @Day3, @Day4, @Day5, @Day6, @Day7, @Day8, @Day9)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idKid", asistencia.Id_Kid);
                    command.Parameters.AddWithValue("@Day1", asistencia.Day1);
                    command.Parameters.AddWithValue("@Day2", asistencia.Day2);
                    command.Parameters.AddWithValue("@Day3", asistencia.Day3);
                    command.Parameters.AddWithValue("@Day4", asistencia.Day4);
                    command.Parameters.AddWithValue("@Day5", asistencia.Day5);
                    command.Parameters.AddWithValue("@Day6", asistencia.Day6);
                    command.Parameters.AddWithValue("@Day7", asistencia.Day7);
                    command.Parameters.AddWithValue("@Day8", asistencia.Day8);
                    command.Parameters.AddWithValue("@Day9", asistencia.Day9);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error al insertar la asistencia: " + e.Message);
                    }
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Asistencia WHERE id_asistencia = @id_asistencia";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_asistencia", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró un registro en la tabla Asistencia con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al eliminar el registro de la tabla Asistencia: " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable bodegas = new DataTable();
            string query = "SELECT * FROM AsistenciaView";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(bodegas);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return bodegas;
        }

        public DataTable Edades10a13()
        {
            DataTable edades = new DataTable();
            string query = "Select k.primer_nombre + ' '+ k.segundo_nombre + ' '+ k.primer_apellido  + ' '+ k.segundo_apellido as Nombre_Completo, k.edad ,\r\na.Day1,a.Day2,a.Day3,a.Day4,a.Day5,a.Day6,a.Day7,a.Day8,a.Day9\r\nFROM Asistencia a\r\ninner join Kid k on k.id_kid = a.id_kid\r\nwhere edad in ('10','11','12','13')\r\norder by edad asc;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(edades);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return edades;
        }

        public DataTable Edades7a9()
        {
            DataTable edades = new DataTable();
            string query = "Select k.primer_nombre + ' '+ k.segundo_nombre + ' '+ k.primer_apellido  + ' '+ k.segundo_apellido as Nombre_Completo, k.edad ,\r\na.Day1,a.Day2,a.Day3,a.Day4,a.Day5,a.Day6,a.Day7,a.Day8,a.Day9\r\nFROM Asistencia a\r\ninner join Kid k on k.id_kid = a.id_kid\r\nwhere edad in ('7','8','9')\r\norder by edad asc;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(edades);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return edades;
        }

        public DataTable Edades4a6()
        {
            DataTable edades = new DataTable();
            string query = "Select k.primer_nombre + ' '+ k.segundo_nombre + ' '+ k.primer_apellido  + ' '+ k.segundo_apellido as Nombre_Completo, k.edad ,\r\na.Day1,a.Day2,a.Day3,a.Day4,a.Day5,a.Day6,a.Day7,a.Day8,a.Day9\r\nFROM Asistencia a\r\ninner join Kid k on k.id_kid = a.id_kid\r\nwhere edad in ('4','5','6')\r\norder by edad asc;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(edades);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return edades;
        }

        public DataTable Edades0a3()
        {
            DataTable edades = new DataTable();
            string query = "Select k.primer_nombre + ' '+ k.segundo_nombre + ' '+ k.primer_apellido  + ' '+ k.segundo_apellido as Nombre_Completo, k.edad ,\r\na.Day1,a.Day2,a.Day3,a.Day4,a.Day5,a.Day6,a.Day7,a.Day8,a.Day9\r\nFROM Asistencia a\r\ninner join Kid k on k.id_kid = a.id_kid\r\nwhere edad in ('1m','2m','3m','4m','5m','6m','7m','8m','9m','10m','11m','1','2','3')\r\norder by edad desc;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(edades);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return edades;

        }



        public void Update(Asistencia asistencia, int id)
        {
            string query = @"UPDATE Asistencia 
                     SET id_kid = @id_kid, 
                         Day1 = @Day1, Day2 = @Day2, Day3 = @Day3, 
                         Day4 = @Day4, Day5 = @Day5, Day6 = @Day6, 
                         Day7 = @Day7, Day8 = @Day8, Day9 = @Day9 
                     WHERE id_asistencia = @id_asistencia";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_kid", asistencia.Id_Kid);
                command.Parameters.AddWithValue("@Day1", asistencia.Day1);
                command.Parameters.AddWithValue("@Day2", asistencia.Day2);
                command.Parameters.AddWithValue("@Day3", asistencia.Day3);
                command.Parameters.AddWithValue("@Day4", asistencia.Day4);
                command.Parameters.AddWithValue("@Day5", asistencia.Day5);
                command.Parameters.AddWithValue("@Day6", asistencia.Day6);
                command.Parameters.AddWithValue("@Day7", asistencia.Day7);
                command.Parameters.AddWithValue("@Day8", asistencia.Day8);
                command.Parameters.AddWithValue("@Day9", asistencia.Day9);
                command.Parameters.AddWithValue("@id_asistencia", asistencia.Id_Asistencia);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el registro de Asistencia con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el registro de Asistencia: " + e.Message);
                }
            }
        }

        public DataTable BuscarPorNombreCompleto(string nombreCompleto)
        {
            string query = @"
                    SELECT id_asistencia, id_kid, Nombre_Completo, edad, 
                    Day1, Day2, Day3, Day4, Day5, Day6, Day7, Day8, Day9
                    FROM AsistenciaView
                    WHERE Nombre_Completo LIKE @nombreCompleto";

            DataTable resultado = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreCompleto", "%" + nombreCompleto + "%");

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(resultado);
                }
                catch (Exception e)
                {
                    throw new Exception("Error al realizar la búsqueda: " + e.Message);
                }
            }

            return resultado;
        }

    }
}
