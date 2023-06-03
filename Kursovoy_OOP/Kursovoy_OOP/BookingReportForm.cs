using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoy_OOP
{
    public partial class BookingReportForm : Form
    {
        const string FILE_BOOKING = "Booking.json";

        public BookingReportForm()
        {
            Task.Run(() => File.Open(FILE_BOOKING, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка данных о бронировании из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void BookingReportForm_Load(object sender, EventArgs e)
        {
            bookingsReportTable.AllowUserToAddRows = false;
            if (File.Exists(FILE_BOOKING))
            {
                var bookings = await ReadFromFile<Booking>(FILE_BOOKING);
                
                if (bookings != null)
                    for (int i = 0; i < bookings.Count; i++)
                    {
                        bookingsReportTable.Rows.Add();
                        bookingsReportTable.Rows[i].Cells[0].Value = bookings[i].BookingDate;
                        bookingsReportTable.Rows[i].Cells[1].Value = bookings[i].BookingTime;
                        bookingsReportTable.Rows[i].Cells[2].Value = bookings[i].Number;
                        bookingsReportTable.Rows[i].Cells[3].Value = bookings[i].BookingStart;
                        bookingsReportTable.Rows[i].Cells[4].Value = bookings[i].BookingEnd;
                    }
            }
            if (bookingsReportTable.Rows.Count > 0)
                bookingsReportTable.Rows[0].Selected = false;
        }

        /// <summary>
        /// Удаление записи из базы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void DeleteBookingButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = -1;
            for (int i = 0; i < bookingsReportTable.Rows.Count; i++)
            {
                if (bookingsReportTable.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    var bookings = await ReadFromFile<Booking>(FILE_BOOKING);

                    string bookingDate = bookingsReportTable.Rows[i].Cells[0].Value.ToString();
                    string bookingTime = bookingsReportTable.Rows[i].Cells[1].Value.ToString();
                    int number = (int)bookingsReportTable.Rows[i].Cells[2].Value;
                    string bookingStart = bookingsReportTable.Rows[i].Cells[3].Value.ToString();
                    string bookingEnd = bookingsReportTable.Rows[i].Cells[4].Value.ToString();

                    foreach (var s in bookings)
                    {
                        if (s.BookingDate == bookingDate &&
                            s.BookingTime == bookingTime &&
                            s.Number == number &&
                            s.BookingStart == bookingStart &&
                            s.BookingEnd == bookingEnd)
                        {
                            bookings.Remove(s);
                            break;
                        }
                    }

                    
                    bookingsReportTable.Rows.Remove(bookingsReportTable.Rows[selectedRowIndex]);
                    bookingsReportTable.Refresh();
                    MessageBox.Show($"Сведения о бронировании стола номер '{number}' удалены из базы",
                        "Удаление записи", 0, MessageBoxIcon.Information);
                    await WriteToFile(bookings, FILE_BOOKING);
                    break;
                }
            }

            if (selectedRowIndex < 0)
                MessageBox.Show("Выберете соответствующую запись!",
                    "Удаление записи", 0, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Очистка базы бронирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void ClearBookingsButton_Click(object sender, EventArgs e)
        {
            if (bookingsReportTable.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите очистить базу?",
                    "Очистить все", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    while (bookingsReportTable.Rows.Count > 0)
                        bookingsReportTable.Rows.Remove(bookingsReportTable.Rows[0]);
                    bookingsReportTable.Refresh();

                    var bookings = await ReadFromFile<Booking>(FILE_BOOKING);
                    bookings.Clear();
                    
                    await WriteToFile(bookings, FILE_BOOKING);
                    MessageBox.Show("База успешно очищена",
                        "Очистить все", 0, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("База пуста!",
                    "Очистить все", 0, MessageBoxIcon.Information);

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
        async public Task WriteToFile<T>(List<T> data, string FILE_NAME)
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
        async public Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }
    }
}
