namespace HomeWork3
{
    public class Customer
    {
        private string fio;
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public Car Car { get; set; }
        public Customer(string fio)
        {
            this.fio = fio;
        }

    }
}
