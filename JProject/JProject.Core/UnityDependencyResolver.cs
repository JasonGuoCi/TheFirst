using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity;

namespace JProject.Core
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private const string HttpContextKey = "perRequestContainer";//静态常量，声明时必须初始化,编译时被解析,可以声明在类中也可以在函数体中

        private readonly IUnityContainer _container;//动态常量，可以延迟到构造函数初始化，运行时解析，只能声明在类中

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
