using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    public class dbclass
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private readonly SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public int CustomerID, MoviesID,RentalID;
        public dbclass()
        {
            string ConnString = @"Data Source=LAPTOP-37GT9VB1\SQLEXPRESS01;Initial Catalog=video_rental;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }


        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillRental_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public string CustomerInsert(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Phone) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data is Successfully done";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }



        public string CustomerUpdate(string FName, string LName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Customer set FirstName = @FirstName,LastName = @LastName,Address = @Address, Phone = @Mobile where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string CustomerDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Customer where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string MoviesInsert(string rating, string title, string year, string rental_cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(rating,title,year, rental_cost,copies,Plot,genre) Values(@rating,@title,@year,@rental_cost,@copies,@plot,@genre)";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@title", title);
                Cmd.Parameters.AddWithValue("@year", year);
                Cmd.Parameters.AddWithValue("@rental_cost", rental_cost);
                Cmd.Parameters.AddWithValue("@copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@genre", genre);
                Cmd.Parameters.AddWithValue("@MoviesID", MoviesID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Data is Successfully done";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }


        }
        public string MoviesUpdate(string rating, string title, string year, string rental_cost, string copies, string plot, string genre)
        {
            {
                try
                {
                    Cmd.Parameters.Clear();
                    Cmd.Connection = Obj_Conn;
                    QueryString = "update Movies set rating = @rating,title = @title,year = @year, rental_cost = @rental_cost,copies = @copies,Plot = @plot,genre = @genre where MovieID =@MovieID";
                    Cmd.Parameters.AddWithValue("@rating", rating);
                    Cmd.Parameters.AddWithValue("@title", title);
                    Cmd.Parameters.AddWithValue("@year", year);
                    Cmd.Parameters.AddWithValue("@rental_cost", rental_cost);
                    Cmd.Parameters.AddWithValue("@copies", copies);
                    Cmd.Parameters.AddWithValue("@Plot", plot);
                    Cmd.Parameters.AddWithValue("@genre", genre);
                    Cmd.Parameters.AddWithValue("@MovieID", MoviesID);
                    Cmd.CommandText = QueryString;
                    //connection opened
                    Obj_Conn.Open();
                    // Executed query
                    Cmd.ExecuteNonQuery();
                    return "movies Data Updated Successfully";
                }
                catch (Exception ex)
                {
                    // show error Message
                    return ex.Message;
                }
                finally
                {
                    // close connection
                    if (Obj_Conn != null)
                    {
                        Obj_Conn.Close();
                    }
                }
            }
        }  
        public string MoviesDelete()
        {
           try
               {
                 Cmd.Parameters.Clear();
                 Cmd.Connection = Obj_Conn;
                 QueryString = "Delete from Movies where MovieID =@MovieID";
                 Cmd.Parameters.AddWithValue("@MovieID", MoviesID);
                 Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies Data Deleted Successfully";
              }
                catch (Exception ex)
                {
                // show error Message
                return ex.Message;
                }
                finally
                {
                // close connection
                if (Obj_Conn != null)
                 {
                   Obj_Conn.Close();
                 }
           }
        }

        public string IssueMovie(DateTime Issue_date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into RentedMovies(MovieIDFK,CustIDFK,DateRented,DateReturned) values(@MoviesID,@CustID,@Issue_date,Null)";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.Parameters.AddWithValue("@MoviesID", MoviesID);
                Cmd.Parameters.AddWithValue("@Issue_date", Issue_date);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string MovieReturn(DateTime Return_date)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "updat RentedMovies set DateReturned=@Return_date whereRMID=@RMID";
                Cmd.Parameters.AddWithValue("@DateReturned", Return_date);
                Cmd.Parameters.AddWithValue("@RMID", RentalID);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movies issued to customer";
            }
            catch (Exception ex)
            {
                // code to show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public DataTable AllMovies()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From AllMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        //code to add the view and to display the data of rented out movies which does not had the return date of the movie
        public DataTable RentedOut_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedOut";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillPOPULARCUST()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From POPULARCUST";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }


        public DataTable FillPOPULARMOVIE()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From POPULARMOVIE";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
    }
}
    








