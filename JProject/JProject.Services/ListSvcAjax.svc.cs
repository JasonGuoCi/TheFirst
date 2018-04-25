using JProject.Services.Helper;
using JProject.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace JProject.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [JavascriptCallbackBehavior(UrlParameterName = "jsoncallback")]
    public class ListSvcAjax
    {
        // 要使用 HTTP GET，请添加 [WebGet] 特性。(默认 ResponseFormat 为 WebMessageFormat.Json)
        // 要创建返回 XML 的操作，
        //     请添加 [WebGet(ResponseFormat=WebMessageFormat.Xml)]，
        //     并在操作正文中包括以下行:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // 在此处添加操作实现
            return;
        }

        // 在此处添加更多操作并使用 [OperationContract] 标记它们




        //无参数wcf
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string TestSvc()
        {
            return "test svc";
        }

        //有参数wcf
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        public string TestHasParametersMethod(string str)
        {
            string msg = string.Format("我的第二个WCF方法，我【{0}】调用成功啦，好开心，O(∩_∩)O哈哈~", str);
            return msg;
        }
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string getJsonMsg()
        {
            List<JsonResult> jr = new List<JsonResult>(){
              new JsonResult{ ID=1, Name="Arbet", Sex="男"},
                new JsonResult{ ID= 2, Name="Arbet1", Sex="女" },
                new JsonResult{ID=3, Name="Arbet2",Sex="男" },
                new JsonResult{ID=4, Name="Arbet3",Sex="女" },
                new JsonResult{ID=5, Name="Arbet4",Sex="男" },
                new JsonResult{ID=6, Name="Arbet5",Sex="男" },
                new JsonResult{ID=7, Name="Arbet6",Sex="女" },
                new JsonResult{ID=8, Name="Arbet7",Sex="男" },
                new JsonResult { ID=9, Name="Arbet1", Sex="女" },
                new JsonResult{ID=10, Name="Arbet2",Sex="男" },
                new JsonResult{ID=11, Name="Arbet3",Sex="女" },
                new JsonResult{ID=12, Name="Arbet4",Sex="男" },
                new JsonResult{ID=13, Name="Arbet5",Sex="男" },
                new JsonResult{ID=14, Name="Arbet6",Sex="女" },
                new JsonResult{ID=15, Name="Arbet7",Sex="男" }
            };

            var total = jr.Count;
            var rows = jr.ToList();
            return JsonHelper.SerializeObject(new { total, rows });
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public JsonResult2 getJsonMsg2()
        {
            List<JsonResult> jr = new List<JsonResult>(){
              new JsonResult{ ID=1, Name="Arbet", Sex="男"},
                new JsonResult{ ID= 2, Name="Arbet1", Sex="女" },
                new JsonResult{ID=3, Name="Arbet2",Sex="男" },
                new JsonResult{ID=4, Name="Arbet3",Sex="女" },
                new JsonResult{ID=5, Name="Arbet4",Sex="男" },
                new JsonResult{ID=6, Name="Arbet5",Sex="男" },
                new JsonResult{ID=7, Name="Arbet6",Sex="女" },
                new JsonResult{ID=8, Name="Arbet7",Sex="男" },
                new JsonResult { ID=9, Name="Arbet1", Sex="女" },
                new JsonResult{ID=10, Name="Arbet2",Sex="男" },
                new JsonResult{ID=11, Name="Arbet3",Sex="女" },
                new JsonResult{ID=12, Name="Arbet4",Sex="男" },
                new JsonResult{ID=13, Name="Arbet5",Sex="男" },
                new JsonResult{ID=14, Name="Arbet6",Sex="女" },
                new JsonResult{ID=15, Name="Arbet7",Sex="男" }
            };

            var total = jr.Count;
            var rows = jr.ToList();
            JsonResult2 js = new JsonResult2(total, rows);
            return js;
        }
    }
}
