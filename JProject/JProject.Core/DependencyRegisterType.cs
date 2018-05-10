using JProject.BLL;
using JProject.DAL;
using JProject.IBLL;
using JProject.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace JProject.Core
{
    public class DependencyRegisterType
    {
        //系统注入
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<ISysSampleBLL, SysSampleBLL>();//样例类似注册
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();
        }
    }
}
