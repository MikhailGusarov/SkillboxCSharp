namespace Example_1922
{

    /// <summary>
    /// Класс, описывающий несуществующего рабочего
    /// </summary>
    class NullWorker : IWorker
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        public NullWorker()
        {
            this.Position = "Not Determined";
            this.Salary = "Not Determined";
            this.Name = "Not Determined";
        }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public string Salary { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Position} {this.Salary}";
        }

    }

}
