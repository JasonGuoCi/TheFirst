using JProject.Web2.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JProject.Web2.WebSvcs
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IListsSvc”。
    [ServiceContract]
    public interface IListsSvc
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        string GetJsonResult();
    }
}
