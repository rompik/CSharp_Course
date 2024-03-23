using Server;
using SharedLibrary;


namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1 service1 = new Service1();

            UserDTO userDTO = new UserDTO
            {

            };

            userDTO = service1.GetDataUsingDataContract(userDTO);

            Console.WriteLine(userDTO.StringValue);
        }

    }
}


