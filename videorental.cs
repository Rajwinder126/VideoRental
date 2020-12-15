using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class VideoRental : Form
    {
        dbclass Obj_Data = new dbclass();
        public VideoRental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
            Popular_Movie_Load();
            Popular_Customer_Load();
        }
        public void Customer_Load()
        {
            DGV_Customer.DataSource = null;
            try
            {
                DGV_Customer.DataSource = Obj_Data.FillCustomer_Data();
                DGV_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Movies_Load()
        {
            DGV_Movie.DataSource = null;
            try
            {
                DGV_Movie.DataSource = Obj_Data.FillMovies_Data();
                DGV_Movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Rental_Load()
        {
            DGV_Rental.DataSource = null;
            try
            {
                DGV_Rental.DataSource = Obj_Data.FillRental_Data();
                DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_customer_details_Click(object sender, EventArgs e)
        {
            if (First_Name_Text.Text != "" && Last_Name_Text.Text != "" && Address_Text.Text != "" && Phone_Text.Text != "")
            {
                string message = Obj_Data.CustomerInsert(First_Name_Text.Text, Last_Name_Text.Text, Phone_Text.Text, Address_Text.Text);
                MessageBox.Show(message);
                First_Name_Text.Text = "";
                Last_Name_Text.Text = "";
                Phone_Text.Text = "";
                Address_Text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the details properly and press Add button");
            }
        }



        private void DGV_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.CustomerID = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells[0].Value);
                First_Name_Text.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                Last_Name_Text.Text = DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                Phone_Text.Text = DGV_Customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                Address_Text.Text = DGV_Customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                custname_text.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing wrong", ex.Message);
            }
        }

        private void update_customer_details_Click(object sender, EventArgs e)
        {
            if (First_Name_Text.Text != "" && Last_Name_Text.Text != "" && Address_Text.Text != "" && Phone_Text.Text != "")
            {
                string message = Obj_Data.CustomerUpdate(First_Name_Text.Text, Last_Name_Text.Text, Phone_Text.Text, Address_Text.Text);
                MessageBox.Show(message);
                First_Name_Text.Text = "";
                Last_Name_Text.Text = "";
                Phone_Text.Text = "";
                Address_Text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press update button");
            }
        }

        private void Delete_customer_details_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.CustomerDelete();
            MessageBox.Show(message);
            First_Name_Text.Text = "";
            Last_Name_Text.Text = "";
            Phone_Text.Text = "";
            Address_Text.Text = "";
            Customer_Load();
        }

        private void Add_moive_details_Click(object sender, EventArgs e)
        {
            {
                if (Rating_text.Text != "" && Title_text.Text != "" && Year_text.Text != "" && Rental_cost_text.Text != "" && copies_text.Text != "" && Plot_text.Text != "" && genre_text.Text != "")
                {
                    string message = Obj_Data.MoviesInsert(Rating_text.Text, Title_text.Text, Year_text.Text, Rental_cost_text.Text, copies_text.Text, Plot_text.Text, genre_text.Text);
                    MessageBox.Show(message);
                    Rating_text.Text = "";
                    Title_text.Text = "";
                    Year_text.Text = "";
                    Rental_cost_text.Text = "";
                    copies_text.Text = "";
                    Plot_text.Text = "";
                    genre_text.Text = "";

                    Movies_Load();
                }
                else
                {
                    MessageBox.Show("Please fill all the details properly and press Add button");
                }

            }
        }



        private void DGV_C_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Movie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.MoviesID = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells[0].Value);
                Rating_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[1].Value.ToString();
                Title_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[2].Value.ToString();
                Year_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[3].Value.ToString();
                Rental_cost_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[4].Value.ToString();
                copies_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[5].Value.ToString();
                 Plot_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[6].Value.ToString();
                genre_text.Text = DGV_Movie.Rows[e.RowIndex].Cells[7].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing wrong", ex.Message);
            }
        }

        private void Update_moive_details_Click(object sender, EventArgs e)
        {
            if (Rating_text.Text != "" && Title_text.Text != "" && Year_text.Text != "" && Rental_cost_text.Text != "" && copies_text.Text != "" && Plot_text.Text != "" && genre_text.Text != "")
            {
                string message = Obj_Data.MoviesUpdate(Rating_text.Text, Title_text.Text, Year_text.Text, Rental_cost_text.Text, copies_text.Text, Plot_text.Text, genre_text.Text);
                MessageBox.Show(message);
                Rating_text.Text = "";
                Title_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                copies_text.Text = "";
                Plot_text.Text = "";
                genre_text.Text = "";
                Movies_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }

        }


        public void Delete_movie_details_Click(object sender, EventArgs e)
        {

            string message = Obj_Data.MoviesDelete();
            MessageBox.Show(message);
            Rating_text.Text = "";
            Title_text.Text = "";
            Year_text.Text = "";
            Rental_cost_text.Text = "";
            copies_text.Text = "";
            Plot_text.Text = "";
            genre_text.Text = "";

            Movies_Load();
        }

        private void issue_rental_details_Click(object sender, EventArgs e)
        {
            if (moviename_text.Text != "" && custname_text.Text != "")
            {
                string message = Obj_Data.IssueMovie(Convert.ToDateTime(date_rented_text.Text));
                MessageBox.Show(message);
                Rating_text.Text = "";
                Title_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                copies_text.Text = "";
                Plot_text.Text = "";
                genre_text.Text = "";
                moviename_text.Text = "";
                First_Name_Text.Text = "";
                Last_Name_Text.Text = "";
                Phone_Text.Text = "";
                Address_Text.Text = "";
                custname_text.Text = "";

                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }
        }

        private void return_rental_details_Click(object sender, EventArgs e)
        {
            if (Title_text.Text != "" && custname_text.Text != "")
            {
                string message = Obj_Data.MovieReturn(Convert.ToDateTime(date_returned_text));
                MessageBox.Show(message);
                Rating_text.Text = "";
                Title_text.Text = "";
                Year_text.Text = "";
                Rental_cost_text.Text = "";
                copies_text.Text = "";
                Plot_text.Text = "";
                genre_text.Text = "";
                moviename_text.Text = "";
                First_Name_Text.Text = "";
                Last_Name_Text.Text = "";
                Phone_Text.Text = "";
                Address_Text.Text = "";
                custname_text.Text = "";
                Rental_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }
        }

        private void button_allrented_Click(object sender, EventArgs e)
        {
            Rental_Load();
        }

        private void button_rentalout_Click(object sender, EventArgs e)
        {
            DGV_Rental.DataSource = null;
            try
            {
                DGV_Rental.DataSource = Obj_Data.RentedOut_Data();
                DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public void Popular_Customer_Load()
        {
            DGV_popularCust.DataSource = null;
            try
            {
                DGV_popularCust.DataSource = Obj_Data.FillPOPULARCUST();
                DGV_popularCust.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Popular_Movie_Load()
        {
            DGV_popularMovie.DataSource = null;
            try
            {
                DGV_popularMovie.DataSource = Obj_Data.FillPOPULARMOVIE();
                DGV_popularMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}












