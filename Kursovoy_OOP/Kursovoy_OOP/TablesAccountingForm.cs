using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovoy_OOP
{
    public partial class TablesAccountingForm : Form
    {
        const string FILE_TABLES = "Tables.json";
        const string FILE_BOOKING = "Booking.json";
        public TablesAccountingForm()
        {
            Task.Run(() => File.Open(FILE_TABLES, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        /// <summary>
        /// Заполнение таблицы данными из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ProductsAccountingForm_Load(object sender, EventArgs e)
        {
            tablesTable.AllowUserToAddRows = false;
            if (File.Exists(FILE_TABLES))
            {
                var tables = await ReadFromFile<Table>(FILE_TABLES);
                totalCountTextBox.Text = tables.Count.ToString();

                if (tables != null)
                    for (int i = 0; i < tables.Count; i++)
                    {
                        tablesTable.Rows.Add();
                        tablesTable.Rows[i].Cells[0].Value = tables[i].Number;
                        tablesTable.Rows[i].Cells[1].Value = tables[i].Type;
                        tablesTable.Rows[i].Cells[2].Value = tables[i].BookingStart;
                        tablesTable.Rows[i].Cells[3].Value = tables[i].BookingEnd;
                        tablesTable.Rows[i].Cells[4].Value = tables[i].PersonsNumber;
                        tablesTable.Rows[i].Cells[5].Value = tables[i].Price;
                    }
            }
            if (tablesTable.Rows.Count > 0)
                tablesTable.Rows[0].Selected = false;
            tablesTable.Sort(tablesTable.Columns[0], ListSortDirection.Descending);
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTableButton_Click(object sender, EventArgs e)
        {
            new SearchTableForm().ShowDialog();
        }

        /// <summary>
        /// Открытие формы бронирования стола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void BookingButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < tablesTable.Rows.Count; i++)
            {
                if (tablesTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;

                    var bookings = await ReadFromFile<Table>(FILE_BOOKING);
                    var flag = true;
                    foreach (var p in bookings)
                    {
                        if (p.Number.ToString() == tablesTable.Rows[i].Cells[0].Value.ToString() &&
                            p.BookingStart == tablesTable.Rows[i].Cells[2].Value.ToString())
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (tablesTable.Rows[i].Cells[3].Value.ToString() != "-" && flag)
                    {
                        var booking = await ReadFromFile<Booking>(FILE_BOOKING);

                        DateTime dt = DateTime.Now;
                        string currentDate = "";
                        if (dt.Day < 10)
                            currentDate += "0" + dt.Day + ".";
                        else
                            currentDate += dt.Day + ".";
                        if (dt.Month < 10)
                            currentDate += "0" + dt.Month + ".";
                        else
                            currentDate += dt.Month + ".";
                        currentDate += dt.Year;

                        string currentTime = "";
                        if (dt.Hour < 10)
                            currentTime += "0" + dt.Hour + ":";
                        else
                            currentTime += dt.Hour + ":";
                        if (dt.Minute < 10)
                            currentTime += "0" + dt.Minute + ":";
                        else
                            currentTime += dt.Minute + ":";
                        if (dt.Second < 10)
                            currentTime += "0" + dt.Second;
                        else
                            currentTime += dt.Second;

                        string bookingDate = currentDate;
                        string bookingTime = currentTime;
                        int number = (int)tablesTable.Rows[i].Cells[0].Value;
                        string bookingStart = tablesTable.Rows[i].Cells[2].Value.ToString();
                        string bookingEnd = tablesTable.Rows[i].Cells[3].Value.ToString();

                        Booking newBooking = new Booking(
                            bookingDate,
                            bookingTime,
                            number,
                            bookingStart,
                            bookingEnd
                        );
                        booking.Add(newBooking);
                        MessageBox.Show($"Стол номер '{number}' успешно забронирован",
                            "Бронирование стола", 0, MessageBoxIcon.Information);
                        await WriteToFile(booking, FILE_BOOKING);
                    }
                    else
                        MessageBox.Show($"Стол уже забронирован на это время или время не задано!",
                            "Бронирование стола", 0, MessageBoxIcon.Information);
                    
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую запись!",
                    "Удаление записи", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Открытие формы редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void EditTableButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < tablesTable.Rows.Count; i++)
            {
                if (tablesTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;

                    Table currentProduct = new Table(
                        (int)tablesTable.Rows[i].Cells[0].Value,
                        tablesTable.Rows[i].Cells[1].Value.ToString(),
                        tablesTable.Rows[i].Cells[2].Value.ToString(),
                        tablesTable.Rows[i].Cells[3].Value.ToString(),
                        (int)tablesTable.Rows[i].Cells[4].Value,
                        (int)tablesTable.Rows[i].Cells[5].Value
                    );
                    EditTableForm.NewNumber = currentProduct.Number;
                    EditTableForm.NewType = currentProduct.Type;
                    EditTableForm.NewBookingStart = currentProduct.BookingStart;
                    EditTableForm.NewBookingEnd = currentProduct.BookingEnd;
                    EditTableForm.NewPersonsNumber = currentProduct.PersonsNumber;
                    EditTableForm.NewPrice = currentProduct.Price;

                    var tables = await ReadFromFile<Table>(FILE_TABLES);
                    foreach (var p in tables)
                    {
                        if (p.Number == currentProduct.Number &&
                            p.Type == currentProduct.Type &&
                            p.BookingStart == currentProduct.BookingStart)
                        {
                            tables.Remove(p);
                            break;
                        }
                    }
                    new EditTableForm().ShowDialog();
                    if (EditTableForm.flag)
                    {
                        currentProduct.Number = EditTableForm.NewNumber;
                        currentProduct.Type = EditTableForm.NewType;
                        currentProduct.BookingStart = EditTableForm.NewBookingStart;
                        currentProduct.BookingEnd = EditTableForm.NewBookingEnd;
                        currentProduct.PersonsNumber = EditTableForm.NewPersonsNumber;
                        currentProduct.Price = EditTableForm.NewPrice;
                        tables.Add(currentProduct);
                        await WriteToFile(tables, FILE_TABLES);
                        tablesTable.Rows[i].Cells[0].Value = currentProduct.Number;
                        tablesTable.Rows[i].Cells[1].Value = currentProduct.Type;
                        tablesTable.Rows[i].Cells[2].Value = currentProduct.BookingStart;
                        tablesTable.Rows[i].Cells[3].Value = currentProduct.BookingEnd;
                        tablesTable.Rows[i].Cells[4].Value = currentProduct.PersonsNumber;
                        tablesTable.Rows[i].Cells[5].Value = currentProduct.Price;
                        tablesTable.Refresh();
                    }
                   
                    break;
                }
            }


            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете стол!",
                    "Редактирование стола", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Открытие формы добавление нового стола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void CreateTableButton_Click(object sender, EventArgs e)
        {
            new CreateTableForm().ShowDialog();

            int newNumber = CreateTableForm.NewNumber;
            string newType = CreateTableForm.NewType;
            string newBookingStart = CreateTableForm.NewBookingStart;
            string newBookingEnd = CreateTableForm.NewBookingEnd;
            int newPersonsNumber = CreateTableForm.NewPersonsNumber;
            int newPrice = CreateTableForm.NewPrice;

            if (newNumber > 0 &&
                !string.IsNullOrEmpty(newType) &&
                !string.IsNullOrEmpty(newBookingStart) &&
                !string.IsNullOrEmpty(newBookingEnd) &&
                newPersonsNumber >= 0 &&
                newPrice >= 0)
            {
                Table newProduct = new Table(
                    newNumber,
                    newType,
                    newBookingStart,
                    newBookingEnd,
                    newPersonsNumber,
                    newPrice
                );

                if (CreateTableForm.flag)
                {
                    var tables = await ReadFromFile<Table>(FILE_TABLES);
                    foreach (var p in tables)
                    {
                        if (p.Number == newNumber)
                        {
                            MessageBox.Show($"Стол с номером '{p.Number}' уже есть в базе",
                                "Добавление стола", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    tables.Add(newProduct);
                    totalCountTextBox.Text = tables.Count.ToString();


                    await WriteToFile(tables, FILE_TABLES);

                    tablesTable.Rows.Add();
                    tablesTable.Rows[tables.Count - 1].Cells[0].Value = newNumber;
                    tablesTable.Rows[tables.Count - 1].Cells[1].Value = newType;
                    tablesTable.Rows[tables.Count - 1].Cells[2].Value = newBookingStart;
                    tablesTable.Rows[tables.Count - 1].Cells[3].Value = newBookingEnd;
                    tablesTable.Rows[tables.Count - 1].Cells[4].Value = newPersonsNumber;
                    tablesTable.Rows[tables.Count - 1].Cells[5].Value = newPrice;
                }

                
            }
        }

        /// <summary>
        /// Удаление стола
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void DeleteTableButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < tablesTable.Rows.Count; i++)
            {
                if (tablesTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    var tables = await ReadFromFile<Table>(FILE_TABLES);

                    int number = (int)tablesTable.Rows[i].Cells[0].Value;
                    string type = tablesTable.Rows[i].Cells[1].Value.ToString();
                    string bookingStart = tablesTable.Rows[i].Cells[2].Value.ToString();
                    string bookingEnd = tablesTable.Rows[i].Cells[3].Value.ToString();
                    int personsNumber = (int)tablesTable.Rows[i].Cells[4].Value;
                    int price = (int)tablesTable.Rows[i].Cells[5].Value;

                    foreach (var p in tables)
                    {
                        if (p.Number == number &&
                            p.Type == type &&
                            p.BookingStart == bookingStart &&
                            p.BookingEnd == bookingEnd &&
                            p.PersonsNumber == personsNumber &&
                            p.Price == price)
                        {
                            tables.Remove(p);
                            break;
                        }
                    }

                    totalCountTextBox.Text = tables.Count.ToString();
                    tablesTable.Rows.Remove(tablesTable.Rows[selectedRowIndex]);
                    tablesTable.Refresh();
                    MessageBox.Show($"Стол номер '{number}' удален из базы", "Удаление стола", 0,
                            MessageBoxIcon.Information);
                    await WriteToFile(tables, FILE_TABLES);
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете стол!",
                    "Удаление стола", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Очистка базы товаров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ClearTablesButton_Click(object sender, EventArgs e)
        {
            if (tablesTable.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите полностью очистить базу?",
                    "Очистить все", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    while (tablesTable.Rows.Count > 0)
                        tablesTable.Rows.Remove(tablesTable.Rows[0]);
                    tablesTable.Refresh();

                    var tables = await ReadFromFile<Table>(FILE_TABLES);
                    tables.Clear();
                    totalCountTextBox.Text = tables.Count.ToString();
                    await WriteToFile(tables, FILE_TABLES);
                    MessageBox.Show("База успешно очищена",
                        "Очистить все", 0, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("База пуста!",
                    "Очистить все", 0, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Фильтр столов в таблице по критериям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            string value = filterTextBox.Text;
            int columnIndex = filterComboBox.SelectedIndex;
            bool hasVisibleRows = false;
            if (filterComboBox.SelectedIndex == -1)
            {
                filterComboBox.Text = "";
                MessageBox.Show($"Выберите поле по которому будет поизводиться фильтрация", "Внимание",
                    0, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in tablesTable.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(value))
                    {
                        row.Visible = true;
                        hasVisibleRows = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                if (!hasVisibleRows)
                {
                    MessageBox.Show($"Полей с такими данными: {value} - нет!", "Внимание", 0, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Отображение таблицы после сброса фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterTextChanged_Click(object sender, EventArgs e)
        {
            if (filterTextBox.Text == "")
                foreach (DataGridViewRow row in tablesTable.Rows)
                    row.Visible = true;
        }

        /// <summary>
        /// Закрытие текущей формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMainFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Запись в файл JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="FILE_NAME"></param>
        /// <returns></returns>
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
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
