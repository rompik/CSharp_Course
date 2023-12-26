namespace Model
{
    public interface IDomainObject
    {
        int Id { get; set; }
    }

    public class Employee : IDomainObject
    {
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Возраст сотрудника (>=18)
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Зарплата
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Множитель премии в этом месяце (% от зарплаты)
        /// </summary>
        public double BonusMultiplier { get; set; }

        public int Id { get; set; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
