
namespace Kursovoy_OOP
{
    partial class BookingReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingReportForm));
            this.bookingsReportTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToMainFormButton = new System.Windows.Forms.Button();
            this.DeleteBookingButton = new System.Windows.Forms.Button();
            this.ClearBookingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingsReportTable
            // 
            this.bookingsReportTable.AllowUserToAddRows = false;
            this.bookingsReportTable.AllowUserToDeleteRows = false;
            this.bookingsReportTable.AllowUserToResizeColumns = false;
            this.bookingsReportTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookingsReportTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingsReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookingsReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingsReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingsReportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookingsReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.bookingsReportTable.Location = new System.Drawing.Point(12, 12);
            this.bookingsReportTable.MultiSelect = false;
            this.bookingsReportTable.Name = "bookingsReportTable";
            this.bookingsReportTable.ReadOnly = true;
            this.bookingsReportTable.RowHeadersWidth = 51;
            this.bookingsReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookingsReportTable.RowTemplate.Height = 24;
            this.bookingsReportTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookingsReportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingsReportTable.Size = new System.Drawing.Size(876, 354);
            this.bookingsReportTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата бронирования";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время бронирования";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер стола";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Забронирован на";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Забронирован до";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ToMainFormButton
            // 
            this.ToMainFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMainFormButton.Location = new System.Drawing.Point(905, 320);
            this.ToMainFormButton.Name = "ToMainFormButton";
            this.ToMainFormButton.Size = new System.Drawing.Size(141, 46);
            this.ToMainFormButton.TabIndex = 1;
            this.ToMainFormButton.Text = "Назад";
            this.ToMainFormButton.UseVisualStyleBackColor = true;
            this.ToMainFormButton.Click += new System.EventHandler(this.ToMainFormButton_Click);
            // 
            // DeleteBookingButton
            // 
            this.DeleteBookingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookingButton.Location = new System.Drawing.Point(906, 56);
            this.DeleteBookingButton.Name = "DeleteBookingButton";
            this.DeleteBookingButton.Size = new System.Drawing.Size(141, 46);
            this.DeleteBookingButton.TabIndex = 2;
            this.DeleteBookingButton.Text = "Удалить запись";
            this.DeleteBookingButton.UseVisualStyleBackColor = true;
            this.DeleteBookingButton.Click += new System.EventHandler(this.DeleteBookingButton_Click);
            // 
            // ClearBookingsButton
            // 
            this.ClearBookingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBookingsButton.Location = new System.Drawing.Point(906, 118);
            this.ClearBookingsButton.Name = "ClearBookingsButton";
            this.ClearBookingsButton.Size = new System.Drawing.Size(141, 46);
            this.ClearBookingsButton.TabIndex = 3;
            this.ClearBookingsButton.Text = "Очистить все";
            this.ClearBookingsButton.UseVisualStyleBackColor = true;
            this.ClearBookingsButton.Click += new System.EventHandler(this.ClearBookingsButton_Click);
            // 
            // BookingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 378);
            this.Controls.Add(this.ClearBookingsButton);
            this.Controls.Add(this.DeleteBookingButton);
            this.Controls.Add(this.ToMainFormButton);
            this.Controls.Add(this.bookingsReportTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о бронировании";
            this.Load += new System.EventHandler(this.BookingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingsReportTable;
        private System.Windows.Forms.Button ToMainFormButton;
        private System.Windows.Forms.Button DeleteBookingButton;
        private System.Windows.Forms.Button ClearBookingsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}