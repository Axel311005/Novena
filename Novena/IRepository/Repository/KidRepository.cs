using Microsoft.Data.SqlClient;
using Novena.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Novena.IRepository.Repository
{
    public class KidRepository : IRepository<Kid>
    {
        private readonly string _connectionString;

        public KidRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void Add(Kid kid)
        {
            string query = @"INSERT INTO Kid (primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, edad, sexo)
                         VALUES (@primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @edad, @sexo)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@primerNombre", kid.Primer_Nombre);
                    command.Parameters.AddWithValue("@segundoNombre", kid.Segundo_Nombre);
                    command.Parameters.AddWithValue("@primerApellido", kid.Primer_Apellido);
                    command.Parameters.AddWithValue("@segundoApellido", kid.Segundo_Apellido);
                    command.Parameters.AddWithValue("@edad", kid.Edad);
                    command.Parameters.AddWithValue("@sexo", kid.Sexo);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Error al insertar el niño: " + e.Message);
                    }
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Kid WHERE id_kid = @id_kid";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_kid", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró un registro en la tabla Kid con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al eliminar el registro de la tabla Kid: " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable bodegas = new DataTable();
            string query = "SELECT * FROM Kid";

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

        public void Update(Kid kid, int id)
        {
            string query = @"UPDATE Kid 
                     SET primer_nombre = @primer_nombre, 
                         segundo_nombre = @segundo_nombre, 
                         primer_apellido = @primer_apellido, 
                         segundo_apellido = @segundo_apellido, 
                         edad = @edad, 
                         sexo = @sexo 
                     WHERE id_kid = @id_kid";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@primer_nombre", kid.Primer_Nombre);
                command.Parameters.AddWithValue("@segundo_nombre", kid.Segundo_Nombre);
                command.Parameters.AddWithValue("@primer_apellido", kid.Primer_Apellido);
                command.Parameters.AddWithValue("@segundo_apellido", kid.Segundo_Apellido);
                command.Parameters.AddWithValue("@edad", kid.Edad);
                command.Parameters.AddWithValue("@sexo", kid.Sexo);
                command.Parameters.AddWithValue("@id_kid", kid.Id_Kid);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el registro de Kid con el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el registro de Kid: " + e.Message);
                }
            }
        }
    }
}
