namespace Example_1921
{
    /// <summary>
    /// Класс, описывающий бухгалтера
    /// </summary>
    class Accountant : IWorker
    {
        static int counter;

        static Accountant() { counter = 1; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Accountant(string Position, string Salary, string Name)
        {
            this.Position = Position + $" {counter}";
            this.Salary = Salary + $" {counter}";
            this.Name = Name + $" {counter}";
            counter++;
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
