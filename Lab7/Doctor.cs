using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;

namespace Lab7
{
    public class Doctor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public int VisitCost { get; set; }
        public int Experience { get; set; }

        static SqlConnection connection;

        public Doctor()
        {
            var connString = ConfigurationManager
                .ConnectionStrings["DALDoctorsConnection"]
                .ConnectionString;
            //создание объекта
            connection = new SqlConnection(connString);
        }

        static Doctor()
        {
            var connString = ConfigurationManager
                .ConnectionStrings["DALDoctorsConnection"]
                .ConnectionString;
            //создание объекта
            connection = new SqlConnection(connString);
        }

        public override string ToString()
        {
            return String.Format("FirstName: {0}, LastName: {1}, Cvalification: {2}, VisitCost: {3}, Experience: {4}",
                FirstName, LastName, Specialization, VisitCost, Experience);
        }

        public static IEnumerable<Doctor> GetAllDoctors()
        {
            var commandString = "SELECT ID, FirstName, LastName, Specialization, VisitCost, Experience FROM Doctors";
            SqlCommand getAllCommand = new SqlCommand(commandString, connection);
            connection.Open();
            var reader = getAllCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var firstName = reader.GetString(1);
                    var lastName = reader.GetString(2);
                    var specialization = reader.GetString(3);
                    var visitCost = reader.GetInt32(4);
                    var experiance = reader.GetInt32(5);

                    var doctor = new Doctor
                    {
                        ID = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Specialization = specialization,
                        VisitCost = visitCost,
                        Experience = experiance
                    };
                    yield return doctor;
                }
            };
            connection.Close();
        }

        public void Insert()
        {
            var commandString = "INSERT INTO Doctors (ID, FirstName, LastName, Specialization, VisitCost, Experience)" +
                "VALUES (@ID, @FirstName, @LastName, @Specialization, @VisitCost, @Experience)";
            SqlCommand insertCommand = new SqlCommand(commandString, connection);

            insertCommand.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("ID", ID),
                    new SqlParameter("FirstName", FirstName),
                    new SqlParameter("LastName", LastName),
                    new SqlParameter("Specialization", Specialization),
                    new SqlParameter("VisitCost", VisitCost),
                    new SqlParameter("Experience", Experience),
                });
            connection.Open();
            insertCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static Doctor GetDoctor(string lastName)
        {
            foreach (var doctor in GetAllDoctors())
            {
                if (doctor.LastName == lastName)
                    return doctor;
            }
            return null;
        }

        public void Update()
        {
            var commandString = "UPDATE Doctors SET " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "Specialization= @Specialization, " +
                "VisitCost = @VisitCost, " +
                "Experience = @Experience " +
                "WHERE (ID = @ID)";
            SqlCommand updateCommand = new SqlCommand(commandString, connection);

            updateCommand.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("FirstName", FirstName),
                    new SqlParameter("LastName", LastName),
                    new SqlParameter("Specialization", Specialization),
                    new SqlParameter("VisitCost", VisitCost),
                    new SqlParameter("Experience", Experience),
                    new SqlParameter("ID", ID),
                });
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(int id)
        {
            var commandString = "DELETE FROM Doctors WHERE (ID = @ID)";
            SqlCommand deleteCommand = new SqlCommand(commandString, connection);

            deleteCommand.Parameters.AddWithValue("ID", id);
            connection.Open();
            deleteCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
