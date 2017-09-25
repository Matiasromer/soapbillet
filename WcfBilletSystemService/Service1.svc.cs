using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;


namespace WcfBilletSystemService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BilletService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BilletService1.svc or BilletService1.svc.cs at the Solution Explorer and start debugging.
    // test
    public class BilletService1 : IBilletService1
    {
        public int BilMedRabat()
        {
            var bilRabat = new Bil();
            bilRabat.BroBizz = true;
            return bilRabat.Pris();
        }

        public int BilPris()
        {
            var bil = new Bil();
            return bil.Pris();
        }

        public int BilØresund()
        {
            var biløresund = new BilØresund();
            return biløresund.Pris();
        }

        public int BilØresundRabat()
        {
            var biløresundrabat = new BilØresund();
            biløresundrabat.BroBizz = true;
            return biløresundrabat.Pris();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        

        public int MCPris()
        {
            var mc = new MC();
            return mc.Pris();
        }

        public int MCØresund()
        {
            var mcøresund = new MCØresund();
            return mcøresund.Pris();
        }

        public int MCØresundRabat()
        {
            var mcøresundrabat = new MCØresund();
            mcøresundrabat.BroBizz = true;
            return mcøresundrabat.Pris();
        }
    }
}
