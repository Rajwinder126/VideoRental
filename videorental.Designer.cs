namespace VideoRental
{
    partial class VideoRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.video_rental = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_Movie = new System.Windows.Forms.DataGridView();
            this.Rent_tab = new System.Windows.Forms.TabPage();
            this.DGV_Rental = new System.Windows.Forms.DataGridView();
            this.Moive_penal = new System.Windows.Forms.PictureBox();
            this.customer_penal = new System.Windows.Forms.PictureBox();
            this.Customer_details = new System.Windows.Forms.TextBox();
            this.Add_customer_details = new System.Windows.Forms.Button();
            this.Delete_customer_details = new System.Windows.Forms.Button();
            this.update_customer_details = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Year_label = new System.Windows.Forms.Label();
            this.Rental_cost_label = new System.Windows.Forms.Label();
            this.Copies_label = new System.Windows.Forms.Label();
            this.Polt_label = new System.Windows.Forms.Label();
            this.Genre_label = new System.Windows.Forms.Label();
            this.Rating_label = new System.Windows.Forms.Label();
            this.Title_label = new System.Windows.Forms.Label();
            this.Rental_penal = new System.Windows.Forms.PictureBox();
            this.Moviename_label = new System.Windows.Forms.Label();
            this.Custname_label = new System.Windows.Forms.Label();
            this.Date_rented_label = new System.Windows.Forms.Label();
            this.Date_returned_label = new System.Windows.Forms.Label();
            this.movie_details = new System.Windows.Forms.TextBox();
            this.Rental_details = new System.Windows.Forms.TextBox();
            this.First_name_label = new System.Windows.Forms.Label();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.issue_rental_details = new System.Windows.Forms.Button();
            this.return_rental_details = new System.Windows.Forms.Button();
            this.Add_moive_details = new System.Windows.Forms.Button();
            this.Delete_movie_details = new System.Windows.Forms.Button();
            this.Update_moive_details = new System.Windows.Forms.Button();
            this.First_Name_Text = new System.Windows.Forms.TextBox();
            this.Last_Name_Text = new System.Windows.Forms.TextBox();
            this.Address_Text = new System.Windows.Forms.TextBox();
            this.Phone_Text = new System.Windows.Forms.TextBox();
            this.moviename_text = new System.Windows.Forms.TextBox();
            this.custname_text = new System.Windows.Forms.TextBox();
            this.Rating_text = new System.Windows.Forms.TextBox();
            this.Title_text = new System.Windows.Forms.TextBox();
            this.Year_text = new System.Windows.Forms.TextBox();
            this.Rental_cost_text = new System.Windows.Forms.TextBox();
            this.copies_text = new System.Windows.Forms.TextBox();
            this.polt_text = new System.Windows.Forms.TextBox();
            this.genre_text = new System.Windows.Forms.TextBox();
            this.date_returned_text = new System.Windows.Forms.DateTimePicker();
            this.date_rented_text = new System.Windows.Forms.DateTimePicker();
            this.allrented = new System.Windows.Forms.Button();
            this.popmovie = new System.Windows.Forms.Button();
            this.popcust = new System.Windows.Forms.Button();
            this.most_popular_movie = new System.Windows.Forms.TabPage();
            this.most_popular_costumer = new System.Windows.Forms.TabPage();
            this.video_rental.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).BeginInit();
            this.Rent_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moive_penal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_penal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rental_penal)).BeginInit();
            this.SuspendLayout();
            // 
            // video_rental
            // 
            this.video_rental.Controls.Add(this.tabPage1);
            this.video_rental.Controls.Add(this.tabPage2);
            this.video_rental.Controls.Add(this.Rent_tab);
            this.video_rental.Controls.Add(this.most_popular_movie);
            this.video_rental.Controls.Add(this.most_popular_costumer);
            this.video_rental.Location = new System.Drawing.Point(13, 40);
            this.video_rental.Name = "video_rental";
            this.video_rental.SelectedIndex = 0;
            this.video_rental.Size = new System.Drawing.Size(509, 279);
            this.video_rental.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Brown;
            this.tabPage1.Controls.Add(this.DGV_Customer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "customer";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(6, 6);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(489, 241);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            this.DGV_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Maroon;
            this.tabPage2.Controls.Add(this.DGV_Movie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie";
            // 
            // DGV_Movie
            // 
            this.DGV_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movie.Location = new System.Drawing.Point(6, 6);
            this.DGV_Movie.Name = "DGV_Movie";
            this.DGV_Movie.Size = new System.Drawing.Size(489, 241);
            this.DGV_Movie.TabIndex = 0;
            // 
            // Rent_tab
            // 
            this.Rent_tab.BackColor = System.Drawing.Color.Maroon;
            this.Rent_tab.Controls.Add(this.DGV_Rental);
            this.Rent_tab.Location = new System.Drawing.Point(4, 22);
            this.Rent_tab.Name = "Rent_tab";
            this.Rent_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Rent_tab.Size = new System.Drawing.Size(501, 253);
            this.Rent_tab.TabIndex = 2;
            this.Rent_tab.Text = "Rental";
            // 
            // DGV_Rental
            // 
            this.DGV_Rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rental.Location = new System.Drawing.Point(6, 6);
            this.DGV_Rental.Name = "DGV_Rental";
            this.DGV_Rental.Size = new System.Drawing.Size(481, 241);
            this.DGV_Rental.TabIndex = 0;
            // 
            // Moive_penal
            // 
            this.Moive_penal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Moive_penal.Location = new System.Drawing.Point(536, 62);
            this.Moive_penal.Name = "Moive_penal";
            this.Moive_penal.Size = new System.Drawing.Size(317, 311);
            this.Moive_penal.TabIndex = 1;
            this.Moive_penal.TabStop = false;
            // 
            // customer_penal
            // 
            this.customer_penal.BackColor = System.Drawing.Color.DarkGray;
            this.customer_penal.Location = new System.Drawing.Point(23, 346);
            this.customer_penal.Name = "customer_penal";
            this.customer_penal.Size = new System.Drawing.Size(402, 321);
            this.customer_penal.TabIndex = 2;
            this.customer_penal.TabStop = false;
            // 
            // Customer_details
            // 
            this.Customer_details.BackColor = System.Drawing.Color.Gold;
            this.Customer_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_details.Location = new System.Drawing.Point(160, 366);
            this.Customer_details.Name = "Customer_details";
            this.Customer_details.Size = new System.Drawing.Size(143, 24);
            this.Customer_details.TabIndex = 3;
            this.Customer_details.Text = "Customer Details";
            // 
            // Add_customer_details
            // 
            this.Add_customer_details.Location = new System.Drawing.Point(33, 629);
            this.Add_customer_details.Name = "Add_customer_details";
            this.Add_customer_details.Size = new System.Drawing.Size(75, 23);
            this.Add_customer_details.TabIndex = 8;
            this.Add_customer_details.Text = "Add";
            this.Add_customer_details.UseVisualStyleBackColor = true;
            this.Add_customer_details.Click += new System.EventHandler(this.Add_customer_details_Click);
            // 
            // Delete_customer_details
            // 
            this.Delete_customer_details.Location = new System.Drawing.Point(330, 629);
            this.Delete_customer_details.Name = "Delete_customer_details";
            this.Delete_customer_details.Size = new System.Drawing.Size(75, 23);
            this.Delete_customer_details.TabIndex = 9;
            this.Delete_customer_details.Text = "Delete";
            this.Delete_customer_details.UseVisualStyleBackColor = true;
            this.Delete_customer_details.Click += new System.EventHandler(this.Delete_customer_details_Click);
            // 
            // update_customer_details
            // 
            this.update_customer_details.Location = new System.Drawing.Point(177, 629);
            this.update_customer_details.Name = "update_customer_details";
            this.update_customer_details.Size = new System.Drawing.Size(75, 23);
            this.update_customer_details.TabIndex = 10;
            this.update_customer_details.Text = "Update";
            this.update_customer_details.UseVisualStyleBackColor = true;
            this.update_customer_details.Click += new System.EventHandler(this.update_customer_details_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 13;
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.BackColor = System.Drawing.Color.DarkGray;
            this.Year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_label.Location = new System.Drawing.Point(574, 166);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(32, 15);
            this.Year_label.TabIndex = 14;
            this.Year_label.Text = "Year";
            // 
            // Rental_cost_label
            // 
            this.Rental_cost_label.AutoSize = true;
            this.Rental_cost_label.BackColor = System.Drawing.Color.DarkGray;
            this.Rental_cost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_cost_label.Location = new System.Drawing.Point(574, 195);
            this.Rental_cost_label.Name = "Rental_cost_label";
            this.Rental_cost_label.Size = new System.Drawing.Size(72, 15);
            this.Rental_cost_label.TabIndex = 15;
            this.Rental_cost_label.Text = "Rental_cost";
            // 
            // Copies_label
            // 
            this.Copies_label.AutoSize = true;
            this.Copies_label.BackColor = System.Drawing.Color.DarkGray;
            this.Copies_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copies_label.Location = new System.Drawing.Point(574, 224);
            this.Copies_label.Name = "Copies_label";
            this.Copies_label.Size = new System.Drawing.Size(45, 15);
            this.Copies_label.TabIndex = 16;
            this.Copies_label.Text = "Copies";
            // 
            // Polt_label
            // 
            this.Polt_label.AutoSize = true;
            this.Polt_label.BackColor = System.Drawing.Color.DarkGray;
            this.Polt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polt_label.Location = new System.Drawing.Point(574, 253);
            this.Polt_label.Name = "Polt_label";
            this.Polt_label.Size = new System.Drawing.Size(28, 15);
            this.Polt_label.TabIndex = 17;
            this.Polt_label.Text = "Polt";
            // 
            // Genre_label
            // 
            this.Genre_label.AutoSize = true;
            this.Genre_label.BackColor = System.Drawing.Color.DarkGray;
            this.Genre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_label.Location = new System.Drawing.Point(574, 285);
            this.Genre_label.Name = "Genre_label";
            this.Genre_label.Size = new System.Drawing.Size(41, 15);
            this.Genre_label.TabIndex = 18;
            this.Genre_label.Text = "Genre";
            // 
            // Rating_label
            // 
            this.Rating_label.AutoSize = true;
            this.Rating_label.BackColor = System.Drawing.Color.DarkGray;
            this.Rating_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating_label.Location = new System.Drawing.Point(574, 101);
            this.Rating_label.Name = "Rating_label";
            this.Rating_label.Size = new System.Drawing.Size(43, 15);
            this.Rating_label.TabIndex = 19;
            this.Rating_label.Text = "Rating";
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.DarkGray;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.Location = new System.Drawing.Point(574, 133);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(30, 15);
            this.Title_label.TabIndex = 20;
            this.Title_label.Text = "Title";
            // 
            // Rental_penal
            // 
            this.Rental_penal.BackColor = System.Drawing.Color.DarkGray;
            this.Rental_penal.Location = new System.Drawing.Point(480, 388);
            this.Rental_penal.Name = "Rental_penal";
            this.Rental_penal.Size = new System.Drawing.Size(377, 279);
            this.Rental_penal.TabIndex = 21;
            this.Rental_penal.TabStop = false;
            // 
            // Moviename_label
            // 
            this.Moviename_label.AutoSize = true;
            this.Moviename_label.BackColor = System.Drawing.Color.DarkGray;
            this.Moviename_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moviename_label.Location = new System.Drawing.Point(488, 446);
            this.Moviename_label.Name = "Moviename_label";
            this.Moviename_label.Size = new System.Drawing.Size(72, 15);
            this.Moviename_label.TabIndex = 23;
            this.Moviename_label.Text = "Moviename";
            // 
            // Custname_label
            // 
            this.Custname_label.AutoSize = true;
            this.Custname_label.BackColor = System.Drawing.Color.DarkGray;
            this.Custname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custname_label.Location = new System.Drawing.Point(488, 493);
            this.Custname_label.Name = "Custname_label";
            this.Custname_label.Size = new System.Drawing.Size(97, 15);
            this.Custname_label.TabIndex = 24;
            this.Custname_label.Text = "Customer Name";
            // 
            // Date_rented_label
            // 
            this.Date_rented_label.AutoSize = true;
            this.Date_rented_label.BackColor = System.Drawing.Color.DarkGray;
            this.Date_rented_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_rented_label.Location = new System.Drawing.Point(488, 539);
            this.Date_rented_label.Name = "Date_rented_label";
            this.Date_rented_label.Size = new System.Drawing.Size(76, 15);
            this.Date_rented_label.TabIndex = 25;
            this.Date_rented_label.Text = "Date Rented";
            // 
            // Date_returned_label
            // 
            this.Date_returned_label.AutoSize = true;
            this.Date_returned_label.BackColor = System.Drawing.Color.DarkGray;
            this.Date_returned_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_returned_label.Location = new System.Drawing.Point(488, 585);
            this.Date_returned_label.Name = "Date_returned_label";
            this.Date_returned_label.Size = new System.Drawing.Size(87, 15);
            this.Date_returned_label.TabIndex = 26;
            this.Date_returned_label.Text = "Date Returned";
            // 
            // movie_details
            // 
            this.movie_details.BackColor = System.Drawing.Color.Gold;
            this.movie_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_details.Location = new System.Drawing.Point(625, 68);
            this.movie_details.Name = "movie_details";
            this.movie_details.Size = new System.Drawing.Size(110, 24);
            this.movie_details.TabIndex = 27;
            this.movie_details.Text = "Movie Details";
            // 
            // Rental_details
            // 
            this.Rental_details.BackColor = System.Drawing.Color.Gold;
            this.Rental_details.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rental_details.Location = new System.Drawing.Point(625, 401);
            this.Rental_details.Name = "Rental_details";
            this.Rental_details.Size = new System.Drawing.Size(121, 27);
            this.Rental_details.TabIndex = 28;
            this.Rental_details.Text = "Rental Details";
            // 
            // First_name_label
            // 
            this.First_name_label.AutoSize = true;
            this.First_name_label.BackColor = System.Drawing.Color.DarkGray;
            this.First_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name_label.Location = new System.Drawing.Point(56, 425);
            this.First_name_label.Name = "First_name_label";
            this.First_name_label.Size = new System.Drawing.Size(67, 15);
            this.First_name_label.TabIndex = 29;
            this.First_name_label.Text = "First Name";
            // 
            // Last_name_label
            // 
            this.Last_name_label.AutoSize = true;
            this.Last_name_label.BackColor = System.Drawing.Color.DarkGray;
            this.Last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name_label.Location = new System.Drawing.Point(57, 484);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(67, 15);
            this.Last_name_label.TabIndex = 30;
            this.Last_name_label.Text = "Last Name";
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.BackColor = System.Drawing.Color.DarkGray;
            this.Address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_label.Location = new System.Drawing.Point(57, 539);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(51, 15);
            this.Address_label.TabIndex = 31;
            this.Address_label.Text = "Address";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.BackColor = System.Drawing.Color.DarkGray;
            this.Phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.Location = new System.Drawing.Point(56, 594);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(43, 15);
            this.Phone_label.TabIndex = 32;
            this.Phone_label.Text = "Phone";
            // 
            // issue_rental_details
            // 
            this.issue_rental_details.Location = new System.Drawing.Point(544, 629);
            this.issue_rental_details.Name = "issue_rental_details";
            this.issue_rental_details.Size = new System.Drawing.Size(75, 23);
            this.issue_rental_details.TabIndex = 33;
            this.issue_rental_details.Text = "issue";
            this.issue_rental_details.UseVisualStyleBackColor = true;
            // 
            // return_rental_details
            // 
            this.return_rental_details.Location = new System.Drawing.Point(691, 629);
            this.return_rental_details.Name = "return_rental_details";
            this.return_rental_details.Size = new System.Drawing.Size(75, 23);
            this.return_rental_details.TabIndex = 35;
            this.return_rental_details.Text = "Return";
            this.return_rental_details.UseVisualStyleBackColor = true;
            // 
            // Add_moive_details
            // 
            this.Add_moive_details.Location = new System.Drawing.Point(554, 328);
            this.Add_moive_details.Name = "Add_moive_details";
            this.Add_moive_details.Size = new System.Drawing.Size(75, 23);
            this.Add_moive_details.TabIndex = 36;
            this.Add_moive_details.Text = "Add";
            this.Add_moive_details.UseVisualStyleBackColor = true;
            this.Add_moive_details.Click += new System.EventHandler(this.Add_moive_details_Click);
            // 
            // Delete_movie_details
            // 
            this.Delete_movie_details.Location = new System.Drawing.Point(767, 328);
            this.Delete_movie_details.Name = "Delete_movie_details";
            this.Delete_movie_details.Size = new System.Drawing.Size(75, 23);
            this.Delete_movie_details.TabIndex = 37;
            this.Delete_movie_details.Text = "Delete";
            this.Delete_movie_details.UseVisualStyleBackColor = true;
            this.Delete_movie_details.Click += new System.EventHandler(this.Delete_movie_details_Click);
            // 
            // Update_moive_details
            // 
            this.Update_moive_details.Location = new System.Drawing.Point(660, 328);
            this.Update_moive_details.Name = "Update_moive_details";
            this.Update_moive_details.Size = new System.Drawing.Size(75, 23);
            this.Update_moive_details.TabIndex = 38;
            this.Update_moive_details.Text = "Update";
            this.Update_moive_details.UseVisualStyleBackColor = true;
            this.Update_moive_details.Click += new System.EventHandler(this.Update_moive_details_Click);
            // 
            // First_Name_Text
            // 
            this.First_Name_Text.Location = new System.Drawing.Point(265, 424);
            this.First_Name_Text.Name = "First_Name_Text";
            this.First_Name_Text.Size = new System.Drawing.Size(100, 20);
            this.First_Name_Text.TabIndex = 39;
            // 
            // Last_Name_Text
            // 
            this.Last_Name_Text.Location = new System.Drawing.Point(265, 488);
            this.Last_Name_Text.Name = "Last_Name_Text";
            this.Last_Name_Text.Size = new System.Drawing.Size(100, 20);
            this.Last_Name_Text.TabIndex = 40;
            // 
            // Address_Text
            // 
            this.Address_Text.Location = new System.Drawing.Point(265, 538);
            this.Address_Text.Name = "Address_Text";
            this.Address_Text.Size = new System.Drawing.Size(100, 20);
            this.Address_Text.TabIndex = 41;
            // 
            // Phone_Text
            // 
            this.Phone_Text.Location = new System.Drawing.Point(265, 593);
            this.Phone_Text.Name = "Phone_Text";
            this.Phone_Text.Size = new System.Drawing.Size(100, 20);
            this.Phone_Text.TabIndex = 42;
            // 
            // moviename_text
            // 
            this.moviename_text.Location = new System.Drawing.Point(724, 446);
            this.moviename_text.Name = "moviename_text";
            this.moviename_text.Size = new System.Drawing.Size(100, 20);
            this.moviename_text.TabIndex = 43;
            // 
            // custname_text
            // 
            this.custname_text.Location = new System.Drawing.Point(724, 492);
            this.custname_text.Name = "custname_text";
            this.custname_text.Size = new System.Drawing.Size(100, 20);
            this.custname_text.TabIndex = 44;
            // 
            // Rating_text
            // 
            this.Rating_text.Location = new System.Drawing.Point(724, 96);
            this.Rating_text.Name = "Rating_text";
            this.Rating_text.Size = new System.Drawing.Size(100, 20);
            this.Rating_text.TabIndex = 47;
            // 
            // Title_text
            // 
            this.Title_text.Location = new System.Drawing.Point(724, 133);
            this.Title_text.Name = "Title_text";
            this.Title_text.Size = new System.Drawing.Size(100, 20);
            this.Title_text.TabIndex = 48;
            // 
            // Year_text
            // 
            this.Year_text.Location = new System.Drawing.Point(724, 166);
            this.Year_text.Name = "Year_text";
            this.Year_text.Size = new System.Drawing.Size(100, 20);
            this.Year_text.TabIndex = 49;
            // 
            // Rental_cost_text
            // 
            this.Rental_cost_text.Location = new System.Drawing.Point(724, 195);
            this.Rental_cost_text.Name = "Rental_cost_text";
            this.Rental_cost_text.Size = new System.Drawing.Size(100, 20);
            this.Rental_cost_text.TabIndex = 50;
            // 
            // copies_text
            // 
            this.copies_text.Location = new System.Drawing.Point(724, 224);
            this.copies_text.Name = "copies_text";
            this.copies_text.Size = new System.Drawing.Size(100, 20);
            this.copies_text.TabIndex = 51;
            // 
            // polt_text
            // 
            this.polt_text.Location = new System.Drawing.Point(725, 253);
            this.polt_text.Name = "polt_text";
            this.polt_text.Size = new System.Drawing.Size(100, 20);
            this.polt_text.TabIndex = 52;
            // 
            // genre_text
            // 
            this.genre_text.Location = new System.Drawing.Point(724, 285);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(100, 20);
            this.genre_text.TabIndex = 53;
            // 
            // date_returned_text
            // 
            this.date_returned_text.Location = new System.Drawing.Point(625, 585);
            this.date_returned_text.Name = "date_returned_text";
            this.date_returned_text.Size = new System.Drawing.Size(200, 20);
            this.date_returned_text.TabIndex = 54;
            // 
            // date_rented_text
            // 
            this.date_rented_text.Location = new System.Drawing.Point(625, 535);
            this.date_rented_text.Name = "date_rented_text";
            this.date_rented_text.Size = new System.Drawing.Size(200, 20);
            this.date_rented_text.TabIndex = 55;
            // 
            // allrented
            // 
            this.allrented.Location = new System.Drawing.Point(782, 673);
            this.allrented.Name = "allrented";
            this.allrented.Size = new System.Drawing.Size(75, 23);
            this.allrented.TabIndex = 56;
            this.allrented.Text = "All Rented";
            this.allrented.UseVisualStyleBackColor = true;
            // 
            // popmovie
            // 
            this.popmovie.Location = new System.Drawing.Point(480, 673);
            this.popmovie.Name = "popmovie";
            this.popmovie.Size = new System.Drawing.Size(107, 23);
            this.popmovie.TabIndex = 57;
            this.popmovie.Text = "Popular Movie";
            this.popmovie.UseVisualStyleBackColor = true;
            // 
            // popcust
            // 
            this.popcust.Location = new System.Drawing.Point(625, 673);
            this.popcust.Name = "popcust";
            this.popcust.Size = new System.Drawing.Size(108, 23);
            this.popcust.TabIndex = 58;
            this.popcust.Text = "Popular customer";
            this.popcust.UseVisualStyleBackColor = true;
            // 
            // most_popular_movie
            // 
            this.most_popular_movie.ForeColor = System.Drawing.Color.Maroon;
            this.most_popular_movie.Location = new System.Drawing.Point(4, 22);
            this.most_popular_movie.Name = "most_popular_movie";
            this.most_popular_movie.Padding = new System.Windows.Forms.Padding(3);
            this.most_popular_movie.Size = new System.Drawing.Size(501, 253);
            this.most_popular_movie.TabIndex = 3;
            this.most_popular_movie.Text = "Most Popular_Movie";
            this.most_popular_movie.UseVisualStyleBackColor = true;
            // 
            // most_popular_costumer
            // 
            this.most_popular_costumer.Location = new System.Drawing.Point(4, 22);
            this.most_popular_costumer.Name = "most_popular_costumer";
            this.most_popular_costumer.Padding = new System.Windows.Forms.Padding(3);
            this.most_popular_costumer.Size = new System.Drawing.Size(501, 253);
            this.most_popular_costumer.TabIndex = 4;
            this.most_popular_costumer.Text = "Most Popular Costumer";
            this.most_popular_costumer.UseVisualStyleBackColor = true;
            // 
            // VideoRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(878, 696);
            this.Controls.Add(this.popcust);
            this.Controls.Add(this.popmovie);
            this.Controls.Add(this.allrented);
            this.Controls.Add(this.date_rented_text);
            this.Controls.Add(this.date_returned_text);
            this.Controls.Add(this.genre_text);
            this.Controls.Add(this.polt_text);
            this.Controls.Add(this.copies_text);
            this.Controls.Add(this.Rental_cost_text);
            this.Controls.Add(this.Year_text);
            this.Controls.Add(this.Title_text);
            this.Controls.Add(this.Rating_text);
            this.Controls.Add(this.custname_text);
            this.Controls.Add(this.moviename_text);
            this.Controls.Add(this.Phone_Text);
            this.Controls.Add(this.Address_Text);
            this.Controls.Add(this.Last_Name_Text);
            this.Controls.Add(this.First_Name_Text);
            this.Controls.Add(this.Update_moive_details);
            this.Controls.Add(this.Delete_movie_details);
            this.Controls.Add(this.Add_moive_details);
            this.Controls.Add(this.return_rental_details);
            this.Controls.Add(this.issue_rental_details);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Last_name_label);
            this.Controls.Add(this.First_name_label);
            this.Controls.Add(this.Rental_details);
            this.Controls.Add(this.movie_details);
            this.Controls.Add(this.Date_returned_label);
            this.Controls.Add(this.Date_rented_label);
            this.Controls.Add(this.Custname_label);
            this.Controls.Add(this.Moviename_label);
            this.Controls.Add(this.Rental_penal);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Rating_label);
            this.Controls.Add(this.Genre_label);
            this.Controls.Add(this.Polt_label);
            this.Controls.Add(this.Copies_label);
            this.Controls.Add(this.Rental_cost_label);
            this.Controls.Add(this.Year_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_customer_details);
            this.Controls.Add(this.Delete_customer_details);
            this.Controls.Add(this.Add_customer_details);
            this.Controls.Add(this.Customer_details);
            this.Controls.Add(this.customer_penal);
            this.Controls.Add(this.Moive_penal);
            this.Controls.Add(this.video_rental);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VideoRental";
            this.Text = "VideoRental";
            this.video_rental.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).EndInit();
            this.Rent_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moive_penal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_penal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rental_penal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl video_rental;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_Movie;
        private System.Windows.Forms.TabPage Rent_tab;
        private System.Windows.Forms.DataGridView DGV_Rental;
        private System.Windows.Forms.PictureBox Moive_penal;
        private System.Windows.Forms.PictureBox customer_penal;
        private System.Windows.Forms.TextBox Customer_details;
        private System.Windows.Forms.Button Add_customer_details;
        private System.Windows.Forms.Button Delete_customer_details;
        private System.Windows.Forms.Button update_customer_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.Label Rental_cost_label;
        private System.Windows.Forms.Label Copies_label;
        private System.Windows.Forms.Label Polt_label;
        private System.Windows.Forms.Label Genre_label;
        private System.Windows.Forms.Label Rating_label;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.PictureBox Rental_penal;
        private System.Windows.Forms.Label Moviename_label;
        private System.Windows.Forms.Label Custname_label;
        private System.Windows.Forms.Label Date_rented_label;
        private System.Windows.Forms.Label Date_returned_label;
        private System.Windows.Forms.TextBox movie_details;
        private System.Windows.Forms.TextBox Rental_details;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Button issue_rental_details;
        private System.Windows.Forms.Button return_rental_details;
        private System.Windows.Forms.Button Add_moive_details;
        private System.Windows.Forms.Button Delete_movie_details;
        private System.Windows.Forms.Button Update_moive_details;
        private System.Windows.Forms.TextBox First_Name_Text;
        private System.Windows.Forms.TextBox Last_Name_Text;
        private System.Windows.Forms.TextBox Address_Text;
        private System.Windows.Forms.TextBox Phone_Text;
        private System.Windows.Forms.TextBox moviename_text;
        private System.Windows.Forms.TextBox custname_text;
        private System.Windows.Forms.TextBox Rating_text;
        private System.Windows.Forms.TextBox Title_text;
        private System.Windows.Forms.TextBox Year_text;
        private System.Windows.Forms.TextBox Rental_cost_text;
        private System.Windows.Forms.TextBox copies_text;
        private System.Windows.Forms.TextBox polt_text;
        private System.Windows.Forms.TextBox genre_text;
        private System.Windows.Forms.DateTimePicker date_returned_text;
        private System.Windows.Forms.DateTimePicker date_rented_text;
        private System.Windows.Forms.Button allrented;
        private System.Windows.Forms.Button popmovie;
        private System.Windows.Forms.Button popcust;
        private System.Windows.Forms.TabPage most_popular_movie;
        private System.Windows.Forms.TabPage most_popular_costumer;
    }
}

