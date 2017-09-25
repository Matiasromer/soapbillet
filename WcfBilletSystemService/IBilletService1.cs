using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfBilletSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBilletService1" in both code and config file together
    [ServiceContract]
    public interface IBilletService1
    {

        

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        int BilPris();
        // Mc Pris
        [OperationContract]
        int MCPris();
        // lul
        [OperationContract]
        int BilMedRabat();

        [OperationContract]
        int MCØresund();

        [OperationContract]
        int BilØresund();

        [OperationContract]
        int BilØresundRabat();

        [OperationContract]
        int MCØresundRabat();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
