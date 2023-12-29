namespace HomeWork2
{
    /// <summary>
    /// Базовый класс для животных
    /// </summary>
    public abstract class Animal
    {

        #region constructor
        #endregion

        #region fields
        private string? _name = string.Empty;
        private int _health = 100;
        private readonly int _age = 0;
        #endregion

        #region property

        #endregion


        #region methods
        #endregion


        public int Age { get { return _age; } }

        public int Health
        {
            get { return _health; }
        }
        public string? Name
        {
            get { return _name; }
            set { if (String.IsNullOrEmpty(_name)) { _name = value; } }
        }

        public string Color
        {
            get
            {
                if (this._health <= 50)
                {
                    return "Red";
                }

                else
                {
                    return "Green";
                }
            }
        }

        public Animal(int age) { _age = age; }

        public abstract void Say();

        public void Feed(int foodCount)
        {
            if ((_health + foodCount) <= 100)
            {
                _health += foodCount;
            }

            else
            {
                _health = 100;
            }

        }

        public void Punish(int punchCount)
        {
            if ((_health - punchCount) >= 0)
            {
                _health -= punchCount;
            }

            else
            {
                _health = 0;
            }

        }

    }
}
