using SharedLibrary;
using System.ServiceModel;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        UserDTO GetDataUsingDataContract(UserDTO composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    public class User
    {
        int Id { get; set; }
        bool boolValue;
        string stringValue;

        public bool BoolValue;

        public string StringValue;

        private void Foo() { }

    }
}
