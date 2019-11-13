using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.NET_Test.DBUtil
{
    public class Managetest
    {
        public string connectionString =
                @"Server=tcp:myeasjmeasurement.database.windows.net,1433;Initial Catalog=Measurement;Persist Security Info=False;User ID=Fred305c;Password=Password1051;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            ;

        public string connectionString2 =
            @"Server=tcp:ande651p-easj-newdbserver.database.windows.net,1433;Initial Catalog=ande651p-dissertation;Persist Security Info=False;User ID=asn230791;Password=No19Pass;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        private string GetAllString = "select id_num, fname from mytestTable";

        private string GetAllString2 = "select Id, Name from TestTable";
        //private static int GivenNo;

        //private string GetGuestFromIDString = "select * from DemoGuest where Guest_No=" + $"{GivenNo}";

        ////private static Guest ParameterGuest;
        //private string InsertGuestString =
        //    $"Insert into DemoGuest ([Name], [Address]) values (@Navn, @Adresse);";

        //private string deleteGuestString = $"Delete from DemoGuest where Guest_No = @GuestId;";

        //private string updateGuestString = $"update DemoGuest where Guest_No=@id";


        public string GetAllGuest()
        {
            //List<Guest> TheGuestlist = new List<Guest>();
            string retvalue = "";
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {

                SqlCommand command = new SqlCommand(GetAllString2, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

               
                while (reader.Read())
                {
                    retvalue = reader.GetInt32(0).ToString();
                    retvalue += $" {reader.GetString(1)}";
                    
                }
            }
            return retvalue ;
        }

        //public Guest GetGuestFromId(int guestNr)
        //{
        //    GivenNo = guestNr;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {

        //        SqlCommand command = new SqlCommand(GetGuestFromIDString, connection);
        //        command.Connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            int guestNum = reader.GetInt32(0);
        //            string guestnavn = reader.GetString(1);
        //            string guestAdr = reader.GetString(2);

        //            return new Guest(guestNum, guestnavn, guestAdr)
        //             ;
        //        }

        //    }
        //    return null;
        //}

        //public bool CreateGuest(Guest guest)
        //{

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {

        //        SqlCommand command = new SqlCommand(InsertGuestString, connection);
        //        command.Parameters.AddWithValue("@Navn", guest.Navn);
        //        command.Parameters.AddWithValue("@Adresse", guest.Adresse);

        //        command.Connection.Open();

        //        int noOfRows = command.ExecuteNonQuery();

        //        return noOfRows > 0;

        //    }

        //}

        //public bool UpdateGuest(Guest guest, int guestNr) //ufærdig
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {

        //        SqlCommand command = new SqlCommand(updateGuestString, connection);
        //        command.Connection.Open();
        //        int noOfRows = command.ExecuteNonQuery();

        //        return noOfRows > 0;
        //    }

        //}

        //public Guest DeleteGuest(int guestNr)
        //{
        //    Guest guest = GetGuestFromId(guestNr);

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {

        //        SqlCommand command = new SqlCommand(deleteGuestString, connection);
        //        command.Connection.Open();
        //        command.ExecuteReader();

        //    }
        //    return guest;
        //}

        public Managetest()
        {

        }
    }
}