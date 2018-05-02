using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            TableSvc.ListSvcClient svc = new TableSvc.ListSvcClient();
            var ls = svc.getJsonMsg();
            svc.TestSvc();
            svc.Close();
        }
    }
}
