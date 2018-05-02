
using JProject.ServicesTest.Entities;
using JProject.ServicesTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JProject.ServicesTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IListSvc”。
    [ServiceContract]
    [ServiceKnownType(typeof(NavigationEntity))]
    [ServiceKnownType(typeof(TicketEntity))]
    public interface IListSvc
    {
        //[OperationContract]
        //void DoWork();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string TestSvc();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string TestHasParametersMethod(string str);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        JsonResult getJsonMsg2();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<NavigationEntity> getJsonMsg();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<TicketEntity> GetTicket();
    }
}
