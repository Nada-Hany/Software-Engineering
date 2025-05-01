
namespace ODP1_Connected_Start
{
    partial class Form1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.category_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate_picker = new System.Windows.Forms.DateTimePicker();
            this.endDate_picker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(847, 513);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // category_cmb
            // 
            this.category_cmb.FormattingEnabled = true;
            this.category_cmb.Location = new System.Drawing.Point(669, 56);
            this.category_cmb.Name = "category_cmb";
            this.category_cmb.Size = new System.Drawing.Size(160, 24);
            this.category_cmb.TabIndex = 1;
            this.category_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // startDate_picker
            // 
            this.startDate_picker.Location = new System.Drawing.Point(669, 113);
            this.startDate_picker.Name = "startDate_picker";
            this.startDate_picker.Size = new System.Drawing.Size(166, 22);
            this.startDate_picker.TabIndex = 3;
            // 
            // endDate_picker
            // 
            this.endDate_picker.Location = new System.Drawing.Point(669, 178);
            this.endDate_picker.Name = "endDate_picker";
            this.endDate_picker.Size = new System.Drawing.Size(166, 22);
            this.endDate_picker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDate_picker);
            this.Controls.Add(this.startDate_picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_cmb);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox category_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate_picker;
        private System.Windows.Forms.DateTimePicker endDate_picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}