using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Kursovoy_OOP
{
    public partial class CreateTableForm : Form
    {
        public static int NewNumber = -1;
        public static string NewType = "";
        public static string NewBookingStart = "-";
        public static string NewBookingEnd = "-";
        public static int NewPersonsNumber = 0;
        public static int NewPrice = -1;
        public static bool flag;

        public CreateTableForm()
        {
            InitializeComponent();
            flag = false;
            comboBox1.SelectedItem = "Русский";
        }

        /// <summary>
        /// Добавление стола в базу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool inputIsCorrect = true;
            flag = true;

            if (int.TryParse(textBox1.Text, out NewNumber) && NewNumber > 0)
            {
                label7.Text = "";
            }
            else
            {
                label7.Text = "Допускаются только целые положительные числа";
                inputIsCorrect = false;
            }

            NewType = comboBox1.Text;
   
            if (int.TryParse(textBox6.Text, out NewPrice) && NewPrice >= 0)
                label12.Text = "";
            else
            {
                inputIsCorrect = false;
                label12.Text = "Допускаются только целые положительные числа";
            }

            if (inputIsCorrect) Close();
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelCreateButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
