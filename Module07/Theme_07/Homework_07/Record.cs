using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    struct Record
    {
        /// <summary>
        /// Дата записи
        /// </summary>
        private DateTime date;
        /// <summary>
        /// Время записи
        /// </summary>
        private TimeSpan time;
        /// <summary>
        /// Заголовок записи
        /// </summary>
        private string header;
        /// <summary>
        ///  Содержание записи
        /// </summary>
        private string body;
        /// <summary>
        /// Статус завершения 
        /// </summary>
        private bool isDone;



        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get { return this.date; } set { this.date = value.Date; } }
        /// <summary>
        /// Время
        /// </summary>
        public TimeSpan Time { get { return this.time; } set { this.time = value; } }
        /// <summary>
        /// Заголовок записи
        /// </summary>
        public string Header { get { return this.header; } set { this.header = value; } }
        /// <summary>
        /// Сождержание записи
        /// </summary>
        public string Body { get { return this.body; } set { this.body = value; } }
        /// <summary>
        /// Статус завершения 
        /// </summary>
        public bool IsDone { get { return this.isDone; } set { this.isDone = value; } }

        public Record(DateTime date, TimeSpan time, string header, string body, bool isDone)
        {
            this.date = date;
            this.time = time;
            this.header = header;
            this.body = body;
            this.isDone = isDone;
        }
        public Record(DateTime date, TimeSpan time, string header, string body):
            this(date, time, header, body, false)
        {

        }
        public Record(DateTime date, TimeSpan time, string header) :
            this(date, time, header, "", false)
        {

        }
        public Record(DateTime date, string header) :
            this(date, TimeSpan.Zero, header, "", false)
        {

        }
        public Record(DateTime date, string header, string body) :
            this(date, TimeSpan.Zero, header, body, false)
        {

        }

        /// <summary>
        /// Вывод информации о записи на экран
        /// </summary>
        /// <returns>Строка с информацией о записи</returns>
        public string GetInfoRecord()
        {
            // TODO реализовать
            return "";
        }

    }
}
