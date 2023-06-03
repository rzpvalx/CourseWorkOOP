
namespace Kursovoy_OOP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProjectName = new System.Windows.Forms.Label();
            this.TablesAccountingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BookingReportButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectName.AutoSize = true;
            this.ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProjectName.Location = new System.Drawing.Point(234, 82);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(339, 54);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "Главное меню";
            // 
            // TablesAccountingButton
            // 
            this.TablesAccountingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TablesAccountingButton.BackColor = System.Drawing.Color.Silver;
            this.TablesAccountingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesAccountingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesAccountingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TablesAccountingButton.Location = new System.Drawing.Point(46, 204);
            this.TablesAccountingButton.Name = "TablesAccountingButton";
            this.TablesAccountingButton.Size = new System.Drawing.Size(240, 68);
            this.TablesAccountingButton.TabIndex = 3;
            this.TablesAccountingButton.Text = "Учет столов";
            this.TablesAccountingButton.UseVisualStyleBackColor = false;
            this.TablesAccountingButton.Click += new System.EventHandler(this.TablesAccountingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(276, 370);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(240, 68);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BookingReportButtton
            // 
            this.BookingReportButtton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BookingReportButtton.BackColor = System.Drawing.Color.Silver;
            this.BookingReportButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingReportButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookingReportButtton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BookingReportButtton.Location = new System.Drawing.Point(523, 204);
            this.BookingReportButtton.Name = "BookingReportButtton";
            this.BookingReportButtton.Size = new System.Drawing.Size(240, 68);
            this.BookingReportButtton.TabIndex = 5;
            this.BookingReportButtton.Text = "Отчет о бронировании";
            this.BookingReportButtton.UseVisualStyleBackColor = false;
            this.BookingReportButtton.Click += new System.EventHandler(this.BookingReportButtton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookingReportButtton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TablesAccountingButton);
            this.Controls.Add(this.ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Button TablesAccountingButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BookingReportButtton;
    }
}