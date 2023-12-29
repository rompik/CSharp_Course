namespace HomeWork3
{
    public class FactoryAF
    {

        public List<Car> Cars = new List<Car>();

        public List<Customer> Customers = new List<Customer>();

        public void AddCar()
        {
            Cars.Add(new Car());
        }

        public void SaleCar()
        {
            if (Cars.Count > Customers.Count)
            {
                foreach (Customer customer in Customers)
                {

                    customer.Car = Cars[0];
                    Cars.Remove(customer.Car);

                }

                Cars.Clear();

            }

            else
            {
                foreach (Customer customer in Customers)
                {
                    if (Cars.Count > 0)
                    {

                        customer.Car = Cars[Cars.Count - 1];
                        Cars.RemoveAt(Cars.Count - 1);

                    }
                }
            }
        }
    }
}
