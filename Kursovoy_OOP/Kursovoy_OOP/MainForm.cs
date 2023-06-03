using System;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            using (var authorInfo = new AuthorInfo())
            {
                authorInfo.ShowDialog();
            }
            InitializeComponent();
        }

        /// <summary>
        /// Запуск формы учета столов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TablesAccountingButton_Click(object sender, EventArgs e)
        {
            new TablesAccountingForm().ShowDialog();
        }

        /// <summary>
        /// Запуск формы отчета о бронировании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookingReportButtton_Click(object sender, EventArgs e)
        {
            new BookingReportForm().ShowDialog();
        }

        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
