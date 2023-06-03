using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_OOP
{
    class Booking
    {
        /// <summary>
        /// Дата бронирования
        /// </summary>
        public string BookingDate { get; set; }

        /// <summary>
        /// Время бронирования
        /// </summary>
        public string BookingTime { get; set; }

        /// <summary>
        /// Номер стола
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Забронирован на
        /// </summary>
        public string BookingStart { get; set; }

        /// <summary>
        /// Забронирован до
        /// </summary>
        public string BookingEnd { get; set; }

        /// <summary>
        /// Конструктор класса Product
        /// </summary>
        /// <param name="bookingDate">Дата бронирования</param>
        /// <param name="bookingTime">Время бронирования</param>
        /// <param name="number">Номер стола</param>
        /// <param name="bookingStart">Забронирован на</param>
        /// <param name="bookingEnd">Забронирован до</param>
        public Booking(string bookingDate, string bookingTime, int number, string bookingStart, string bookingEnd)
        {
            BookingDate = bookingDate;
            BookingTime = bookingTime;
            Number = number;
            BookingStart = bookingStart;
            BookingEnd = bookingEnd;
        }
    }
}
