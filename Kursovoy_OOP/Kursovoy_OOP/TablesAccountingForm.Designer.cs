
namespace Kursovoy_OOP
{
    partial class TablesAccountingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesAccountingForm));
            this.tablesTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.ToMainFormButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.ClearTablesButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.SearchTableButton = new System.Windows.Forms.Button();
            this.totalCountTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.EditTableButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesTable
            // 
            this.tablesTable.AllowUserToAddRows = false;
            this.tablesTable.AllowUserToDeleteRows = false;
            this.tablesTable.AllowUserToResizeColumns = false;
            this.tablesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablesTable.Location = new System.Drawing.Point(15, 34);
            this.tablesTable.MultiSelect = false;
            this.tablesTable.Name = "tablesTable";
            this.tablesTable.ReadOnly = true;
            this.tablesTable.RowHeadersWidth = 51;
            this.tablesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablesTable.RowTemplate.Height = 24;
            this.tablesTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tablesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesTable.Size = new System.Drawing.Size(1083, 300);
            this.tablesTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Всего столов";
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterLabel.Location = new System.Drawing.Point(191, 343);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(93, 18);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Фильтрация";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Номер стола",
            "Русский/Американский",
            "Забронирован на",
            "Забронирован до",
            "Количество человек",
            "Стоимость"});
            this.filterComboBox.Location = new System.Drawing.Point(29, 393);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(189, 24);
            this.filterComboBox.TabIndex = 4;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterTextBox.Location = new System.Drawing.Point(246, 393);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(189, 22);
            this.filterTextBox.TabIndex = 5;
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextChanged_Click);
            // 
            // ToMainFormButton
            // 
            this.ToMainFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToMainFormButton.BackColor = System.Drawing.SystemColors.Control;
            this.ToMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToMainFormButton.Location = new System.Drawing.Point(1109, 373);
            this.ToMainFormButton.Name = "ToMainFormButton";
            this.ToMainFormButton.Size = new System.Drawing.Size(148, 44);
            this.ToMainFormButton.TabIndex = 9;
            this.ToMainFormButton.Text = "Назад";
            this.ToMainFormButton.UseVisualStyleBackColor = false;
            this.ToMainFormButton.Click += new System.EventHandler(this.ToMainFormButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreateTableButton.BackColor = System.Drawing.SystemColors.Control;
            this.CreateTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTableButton.Location = new System.Drawing.Point(1109, 34);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(143, 44);
            this.CreateTableButton.TabIndex = 10;
            this.CreateTableButton.Text = "Добавить стол";
            this.CreateTableButton.UseVisualStyleBackColor = false;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteTableButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTableButton.Location = new System.Drawing.Point(771, 373);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(151, 44);
            this.DeleteTableButton.TabIndex = 11;
            this.DeleteTableButton.Text = "Удалить стол";
            this.DeleteTableButton.UseVisualStyleBackColor = false;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
            // 
            // ClearTablesButton
            // 
            this.ClearTablesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearTablesButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTablesButton.Location = new System.Drawing.Point(947, 373);
            this.ClearTablesButton.Name = "ClearTablesButton";
            this.ClearTablesButton.Size = new System.Drawing.Size(151, 44);
            this.ClearTablesButton.TabIndex = 12;
            this.ClearTablesButton.Text = "Очистить все";
            this.ClearTablesButton.UseVisualStyleBackColor = false;
            this.ClearTablesButton.Click += new System.EventHandler(this.ClearTablesButton_Click);
            // 
            // BookingButton
            // 
            this.BookingButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookingButton.BackColor = System.Drawing.SystemColors.Control;
            this.BookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookingButton.Location = new System.Drawing.Point(1109, 203);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(143, 44);
            this.BookingButton.TabIndex = 13;
            this.BookingButton.Text = "Забронировать стол";
            this.BookingButton.UseVisualStyleBackColor = false;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // SearchTableButton
            // 
            this.SearchTableButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchTableButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTableButton.Location = new System.Drawing.Point(1109, 290);
            this.SearchTableButton.Name = "SearchTableButton";
            this.SearchTableButton.Size = new System.Drawing.Size(148, 44);
            this.SearchTableButton.TabIndex = 14;
            this.SearchTableButton.Text = "Найти стол";
            this.SearchTableButton.UseVisualStyleBackColor = false;
            this.SearchTableButton.Click += new System.EventHandler(this.SearchTableButton_Click);
            // 
            // totalCountTextBox
            // 
            this.totalCountTextBox.Location = new System.Drawing.Point(125, 6);
            this.totalCountTextBox.Name = "totalCountTextBox";
            this.totalCountTextBox.ReadOnly = true;
            this.totalCountTextBox.Size = new System.Drawing.Size(93, 22);
            this.totalCountTextBox.TabIndex = 15;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterButton.BackColor = System.Drawing.SystemColors.Control;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(472, 375);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(148, 44);
            this.FilterButton.TabIndex = 16;
            this.FilterButton.Text = "Фильтровать";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // EditTableButton
            // 
            this.EditTableButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EditTableButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTableButton.Location = new System.Drawing.Point(1109, 117);
            this.EditTableButton.Name = "EditTableButton";
            this.EditTableButton.Size = new System.Drawing.Size(143, 44);
            this.EditTableButton.TabIndex = 18;
            this.EditTableButton.Text = "Редактировать";
            this.EditTableButton.UseVisualStyleBackColor = false;
            this.EditTableButton.Click += new System.EventHandler(this.EditTableButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Параметр фильтрации";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(303, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Значение";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 94.33155F;
            this.Column1.HeaderText = "Номер стола";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 128.3422F;
            this.Column2.HeaderText = "Русский/Американский";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 94.33155F;
            this.Column3.HeaderText = "Забронирован на";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 94.33155F;
            this.Column4.HeaderText = "Забронирован до";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 94.33155F;
            this.Column5.HeaderText = "Количество человек";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 94.33155F;
            this.Column6.HeaderText = "Стоимость, руб";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // TablesAccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1271, 442);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditTableButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.totalCountTextBox);
            this.Controls.Add(this.SearchTableButton);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.ClearTablesButton);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.ToMainFormButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TablesAccountingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет столов";
            this.Load += new System.EventHandler(this.ProductsAccountingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablesTable;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMainFormButton;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button DeleteTableButton;
        private System.Windows.Forms.Button ClearTablesButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Button SearchTableButton;
        private System.Windows.Forms.TextBox totalCountTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button EditTableButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}