using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_OOP
{
    class Table
    {
        /// <summary>
        /// Номер стола
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Русский или американский
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Забронирован на
        /// </summary>
        public string BookingStart { get; set; }

        /// <summary>
        /// Забронирован до
        /// </summary>
        public string BookingEnd { get; set; }

        /// <summary>
        /// Количество человек
        /// </summary>
        public int PersonsNumber { get; set; }

        /// <summary>
        /// Стоимость (в рублях)
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Конструктор класса Table
        /// </summary>
        /// <param name="number">Номер стола</param>
        /// <param name="type">Русский или американский</param>
        /// <param name="bookingStart">Забронирован на</param>
        /// <param name="bookingEnd">Забронирован до</param>
        /// <param name="personsNumber">Количество человек</param>
        /// <param name="price">Стоимость (в рублях)</param>
        public Table(int number, string type, string bookingStart, string bookingEnd, int personsNumber, int price)
        {
            Number = number;
            Type = type;
            BookingStart = bookingStart;
            BookingEnd = bookingEnd;
            PersonsNumber = personsNumber;
            Price = price;
        }
    }
}
