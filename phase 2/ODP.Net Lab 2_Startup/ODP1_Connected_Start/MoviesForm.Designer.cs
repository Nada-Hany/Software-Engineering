namespace ODP1_Connected_Start
{
    partial class MoviesForm
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
            this.movie_names_cmb = new System.Windows.Forms.ComboBox();
            this.movie_names = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.show_date_cmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seats_cmb = new System.Windows.Forms.ComboBox();
            this.category_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start_time_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_names_cmb
            // 
            this.movie_names_cmb.FormattingEnabled = true;
            this.movie_names_cmb.Location = new System.Drawing.Point(725, 141);
            this.movie_names_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movie_names_cmb.Name = "movie_names_cmb";
            this.movie_names_cmb.Size = new System.Drawing.Size(158, 24);
            this.movie_names_cmb.TabIndex = 0;
            this.movie_names_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // movie_names
            // 
            this.movie_names.AutoSize = true;
            this.movie_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_names.Location = new System.Drawing.Point(728, 119);
            this.movie_names.Name = "movie_names";
            this.movie_names.Size = new System.Drawing.Size(67, 20);
            this.movie_names.TabIndex = 1;
            this.movie_names.Text = "Movies ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 491);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(673, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(278, 32);
            this.label18.TabIndex = 3;
            this.label18.Text = "Reserve Your Seat!";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Availible Dates";
            // 
            // show_date_cmb
            // 
            this.show_date_cmb.FormattingEnabled = true;
            this.show_date_cmb.Location = new System.Drawing.Point(725, 230);
            this.show_date_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_date_cmb.Name = "show_date_cmb";
            this.show_date_cmb.Size = new System.Drawing.Size(158, 24);
            this.show_date_cmb.TabIndex = 4;
            this.show_date_cmb.SelectedIndexChanged += new System.EventHandler(this.show_date_cmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(725, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(728, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Availible Seats";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // seats_cmb
            // 
            this.seats_cmb.FormattingEnabled = true;
            this.seats_cmb.Location = new System.Drawing.Point(725, 391);
            this.seats_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seats_cmb.Name = "seats_cmb";
            this.seats_cmb.Size = new System.Drawing.Size(158, 24);
            this.seats_cmb.TabIndex = 7;
            this.seats_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // category_txt
            // 
            this.category_txt.AutoSize = true;
            this.category_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_txt.Location = new System.Drawing.Point(729, 167);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(106, 16);
            this.category_txt.TabIndex = 9;
            this.category_txt.Text = "movie category: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Time";
            // 
            // start_time_cmb
            // 
            this.start_time_cmb.FormattingEnabled = true;
            this.start_time_cmb.Location = new System.Drawing.Point(725, 306);
            this.start_time_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_time_cmb.Name = "start_time_cmb";
            this.start_time_cmb.Size = new System.Drawing.Size(158, 24);
            this.start_time_cmb.TabIndex = 10;
            this.start_time_cmb.SelectedIndexChanged += new System.EventHandler(this.start_time_cmb_SelectedIndexChanged);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_time_cmb);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seats_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_date_cmb);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.movie_names);
            this.Controls.Add(this.movie_names_cmb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoviesForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoviesForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movie_names_cmb;
        private System.Windows.Forms.Label movie_names;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox show_date_cmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seats_cmb;
        private System.Windows.Forms.Label category_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox start_time_cmb;
    }
}