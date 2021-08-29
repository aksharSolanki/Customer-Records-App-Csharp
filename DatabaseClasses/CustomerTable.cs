using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using CustomerClasses;

namespace DatabaseClasses
{
    public class CustomerTable
    {
        private const string HOST = "calvin.humber.ca";
        private const string SID = "grok";
        internal const string PASSWORD = "password";
        private const string USER_ID = "username";
       
        private static readonly string myConnectionString = string.Format("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
                                                            "(HOST={0})(PORT=1521))(CONNECT_DATA=(SID={1}))); " +
                                                            "PASSWORD={2}; USER ID={3}", HOST, SID, PASSWORD, USER_ID);
        
        // Oracle objects declared performs operations on the database
        private OracleConnection connection;
        private OracleCommand command;
        private OracleDataReader dataReader;

        // Default constructor to create table customer with customer information
        public CustomerTable()
        {
            try
            {
                connection = new OracleConnection(myConnectionString);
                command = new OracleCommand();
                command.Connection = connection;
                connection.Open();
            } catch(OracleException ex)
            {
                throw ex;
            }
        }

        // CreateTable method to create customer table using command properties
        public void CreateTable()
        {
            try
            {
                command.CommandText = "CREATE TABLE customer(firstname VARCHAR2(10)," +
                                    "lastname VARCHAR2(10), address VARCHAR2(20), epost CHAR(1), " +
                                    "events CHAR(1), infoalerts CHAR(1))";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('THOMAS', 'PIERSON', '69821 SOUTH AVENUE', 'T', 'F', 'F')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('MESHIA', 'CRUZ', '82 DIRT ROAD', 'F', 'T', 'T')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('TAMMY', 'GIANA', '9153 MAIN STREET', 'T', 'F', 'T')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('JAKE', 'LUCAS', '114 EAST SAVANNAH', 'F', 'T', 'F')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('MICHELL', 'DAUM', '9851231 LONG ROAD', 'F', 'F', 'T')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO customer VALUES('GREG', 'MONTIASA', '1008 GRAND AVENUE', 'T', 'T', 'F')";
                command.ExecuteNonQuery();
            } catch(OracleException ex)
            {
                throw ex;
            }
        }

        // DropTable method to drop the customer table in database and close the connection
        public void DropTable()
        {
            try
            {
                command.CommandText = "DROP TABLE customer";
                command.ExecuteNonQuery();
                connection.Close();
            } catch(OracleException ex)
            {
                throw ex;
            }
        }

        // GetCustomer method executes a query to retrieve formatted data from the Oracle database.
        // After retrieving the data in the dataReader object, the interest fields are evaluated and 
        // new Customer object is created and finally returned.
        // If no data is retrieved an exception is caught by catch block & thrown. 
        public Customer GetCustomer(string lastname)
        {
            Customer temp = null;
            List<string> interests = new List<string>();
            try
            {
                command.CommandText = "SELECT INITCAP(firstname), INITCAP(lastname), INITCAP(address), " +
                    "epost, events, infoalerts FROM customer WHERE lastname = '" + lastname.ToUpper() + "'";
                dataReader = command.ExecuteReader();

                if (!dataReader.HasRows)
                    throw new Exception();

                if (dataReader.Read())
                {
                    if (dataReader[3].ToString().Equals("T"))
                        interests.Add("ePost");

                    if (dataReader[4].ToString().Equals("T"))
                        interests.Add("Events");

                    if (dataReader[5].ToString().Equals("T"))
                        interests.Add("InfoAlerts");

                    temp = new Customer(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(),
                                        interests);
                }
            }
            catch (OracleException e)
            {
                throw e;
            }
            return temp;
        }

        // UpdateAddress method takes user's lastname and provided address to update the
        // old address. It also commits the changes made to database. 
        // It handles and throws OracleException if caused.
        public void UpdateAddress(string lastname, string newAddress)
        {
            try
            {
                command.CommandText = "UPDATE customer SET address = '" + newAddress.ToUpper() + "'" +
                                    "WHERE lastname like '" + lastname.ToUpper() + "'";
                command.ExecuteNonQuery();
                command.CommandText = "COMMIT";
                command.ExecuteNonQuery();
            } catch(OracleException ex)
            {
                throw ex;
            }
        }
    }
}
