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
       databaseClass Obj_Data = new databaseClass();
        public VideoRental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
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
            global::VideoRental.DGV_Rental.DataSource = null;
            try
            {
                global::VideoRental.DGV_Rental.DataSource = Obj_Data.FillRental_Data();
                global::VideoRental.DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
 