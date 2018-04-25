using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using JProject.Web2.Biz;
using JProject.Web2.Helper;

namespace JProject.Web2.WebSvcs
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“ListsSvc”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 ListsSvc.svc 或 ListsSvc.svc.cs，然后开始调试。
    public class ListsSvc : IListsSvc
    {
        public void DoWork()
        {
        }

        public string GetJsonResult()
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
    }
}
