using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class SearchTableForm : Form
    {
        const string FILE_TABLES = "Tables.json";

        public SearchTableForm()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Русский";
        }

        /// <summary>
        /// Проверка введенных данных на корректность, поиск товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void SearchButton_Click(object sender, EventArgs e)
        {
            bool inputIsCorrect = true;

            if (int.TryParse(textBox1.Text, out var number) && int.Parse(textBox1.Text) > 0)
                label4.Text = "";
            else
            {
                label4.Text = "Допускаются только целые положительные числа";
                inputIsCorrect = false;
            }

            if (Regex.Match(textBox3.Text, "^[A-Za-z0-9А-Яа-я\\s]+$").Success)
                label6.Text = "";
            else
            {
                label6.Text = "Допускаются только символы латиницы, кириллицы, пробела и цифры";
                inputIsCorrect = false;
            }

            if (inputIsCorrect)
            {
                var tables = await ReadFromFile<Table>(FILE_TABLES);
                var flag = true;
                foreach (var p in tables)
                {
                    if (p.Number.ToString() == textBox1.Text &&
                        p.Type == comboBox1.Text &&
                        p.Price.ToString() == textBox3.Text)
                    {
                        MessageBox.Show($"Номер стола: {p.Number} \n" +
                            $"Русский/Американский: {p.Type} \n" +
                            $"Производитель: {p.BookingStart} \n" +
                            $"Забронирован на: {p.BookingEnd} \n" +
                            $"Забронирован до: {p.PersonsNumber} \n" +
                            $"Стоимость {p.Price} руб.",
                            "Поиск стола", 0, MessageBoxIcon.Information);
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    MessageBox.Show($"Стол не найден",
                            "Поиск стола", 0, MessageBoxIcon.Information);
            }
            
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Чтение из файла JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FILE_NAME"></param>
        /// <returns></returns>
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }
    }
}
