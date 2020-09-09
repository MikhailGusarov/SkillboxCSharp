namespace Example_1922
{


    /// <summary>
    /// Класс, описывающий менеджера по персоналу
    /// </summary>
    class HrManager : IWorker
    {
        static int counter;

        static HrManager() { counter = 1; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public HrManager(string Position, string Salary, string Name)
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
