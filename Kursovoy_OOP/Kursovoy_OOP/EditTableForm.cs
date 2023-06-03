using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kursovoy_OOP
{
    public partial class EditTableForm : Form
    {
        public static int NewNumber = -1;
        public static string NewType = "";
        public static string NewBookingStart = "";
        public static string NewBookingEnd = "";
        public static int NewPersonsNumber = -1;
        public static int NewPrice = -1;
        public static bool flag;

        public EditTableForm()
        {
            InitializeComponent();
            flag = false;
            comboBox1.SelectedItem = "Русский";
        }

        /// <summary>
        /// Загрузка редактируемых данных в форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = NewNumber.ToString();
            comboBox1.Text = NewType;
            comboBox2.Text = NewBookingStart;
            textBox5.Text = NewPersonsNumber.ToString();
            textBox6.Text = NewPrice.ToString();
        }

        /// <summary>
        /// Редактирование стола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            bool inputIsCorrect = true;
            
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
            if (comboBox2.Text != "-")
            {
                NewBookingStart = comboBox2.Text;
                NewBookingEnd = (Int32.Parse(comboBox2.Text.Split(':')[0]) + 1).ToString() + ":" + comboBox2.Text.Split(':')[1];
            }
            else
            {
                NewBookingStart = "-";
                NewBookingEnd = "-";
            }
               
            if (int.TryParse(textBox5.Text, out NewPersonsNumber) && NewPersonsNumber >= 0)
                label11.Text = "";
            else
            {
                inputIsCorrect = false;
                label11.Text = "Допускаются только целые положительные числа";
            }

            if (int.TryParse(textBox6.Text, out NewPrice) && NewPrice >= 0)
                label12.Text = "";
            else
            {
                inputIsCorrect = false;
                label12.Text = "Допускаются только целые положительные числа";
            }

            if (inputIsCorrect)
            {
                flag = true;
                Close();
            }
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
