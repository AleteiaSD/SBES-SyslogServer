using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
   public  interface IConsumer
    {

        [OperationContract]
        string Read();

        [OperationContract]
        bool Update(int id, string newMsg);

        [OperationContract]
        bool Delete(int id);
    }
}
