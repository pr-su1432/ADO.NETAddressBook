﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETAddressBook
{
    public class BookAnalyser
    {
        public static string DBPath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;";
        
        public void getDataFromAddressBook()
        {
            SqlConnection connect = new SqlConnection(DBPath);
            ADO.NETAddressBook.Book value = new ADO.NETAddressBook.Book();
            using (connect)
            {
                connect.Open();
                string query = "Select * from AddressBook";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader data = command.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        value.ID = data.GetInt32(0);
                        value.FIRSTNAME= data.GetString(1);
                        value.LASTNAME = data.GetString(2);
                        value.ADDRESS = data.GetString(3);
                        value.CITY = data.GetString(4);
                        value.STATE = data.GetString(5);
                        value.ZIP = data.GetString(6);
                        value.PHONENO = data.GetString(7);
                        value.EMAIL = data.GetString(8);
                        
                        Console.WriteLine(value.ID + "\n " + value.FIRSTNAME + " \n" +  value.LASTNAME + "\n " + value.ADDRESS + "\n " + value.CITY + "\n " + value.STATE + "\n " + value.ZIP + " \n" + value.PHONENO + "\n " + value.EMAIL);
                    }
                }
                else
                {
                    Console.WriteLine("Records not found in Database.");
                }
                data.Close();
                connect.Close();
            }
        }
    }
}
