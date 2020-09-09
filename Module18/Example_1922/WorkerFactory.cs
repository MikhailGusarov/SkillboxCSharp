namespace Example_1922
{
    static class WorkerFactory
    {

        public static IWorker GetWorker(string TypeWorker,
                                        string Position,
                                        string Salary,
                                        string Name)
        {
            switch (TypeWorker)
            {
                case "HrManager": return new HrManager(Position, Salary, Name);
                case "Accountant": return new Accountant(Position, Salary, Name);
                case "Courier": return new Courier(Position, Salary, Name);
                //default: return null;

                #region _

                default: return new NullWorker();

                #endregion

            }
        }
    }
}