using JProject.ServicesTest.Helper;
using JProject.ServicesTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace JProject.ServicesTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“ListSvc”。
    public class ListSvc : BaseService, IListSvc
    {
        public List<object> getJsonMsg()
        {
            var data = new List<object>(){new { ID=1, Name="Arbet", Sex="男"},
                new { ID= 2, Name="Arbet1", Sex="女" },
                new {ID=3, Name="Arbet2",Sex="男" },
                new {ID=4, Name="Arbet3",Sex="女" },
                new {ID=5, Name="Arbet4",Sex="男" },
                new {ID=6, Name="Arbet5",Sex="男" },
                new {ID=7, Name="Arbet6",Sex="女" },
                new {ID=8, Name="Arbet7",Sex="男" },
                new { ID=9, Name="Arbet1", Sex="女" },
                new {ID=10, Name="Arbet2",Sex="男" },
                new {ID=11, Name="Arbet3",Sex="女" },
                new {ID=12, Name="Arbet4",Sex="男" },
                new {ID=13, Name="Arbet5",Sex="男" },
                new {ID=14, Name="Arbet6",Sex="女" },
                new {ID=15, Name="Arbet7",Sex="男" }
            };
            return data;
        }

        public JsonResult getJsonMsg2()
        {
            List<NavigationEntity> jr = new List<NavigationEntity>(){
              new NavigationEntity{ ID=1, Name="Arbet", Sex="男"},
                new NavigationEntity{ ID= 2, Name="Arbet1", Sex="女" },
                new NavigationEntity{ID=3, Name="Arbet2",Sex="男" },
                new NavigationEntity{ID=4, Name="Arbet3",Sex="女" },
                new NavigationEntity{ID=5, Name="Arbet4",Sex="男" },
                new NavigationEntity{ID=6, Name="Arbet5",Sex="男" },
                new NavigationEntity{ID=7, Name="Arbet6",Sex="女" },
                new NavigationEntity{ID=8, Name="Arbet7",Sex="男" },
                new NavigationEntity { ID=9, Name="Arbet1", Sex="女" },
                new NavigationEntity{ID=10, Name="Arbet2",Sex="男" },
                new NavigationEntity{ID=11, Name="Arbet3",Sex="女" },
                new NavigationEntity{ID=12, Name="Arbet4",Sex="男" },
                new NavigationEntity{ID=13, Name="Arbet5",Sex="男" },
                new NavigationEntity{ID=14, Name="Arbet6",Sex="女" },
                new NavigationEntity{ID=15, Name="Arbet7",Sex="男" }
            };

            //var total = jr.Count;
            //var rows = jr.ToList();
            var js = Json(jr);
            return js;
        }

        public string TestHasParametersMethod(string str)
        {
            string msg = string.Format("我的第二个WCF方法，我【{0}】调用成功啦，好开心，O(∩_∩)O哈哈~", str);
            return msg;
        }

        //public void DoWork()
        //{
        //}

        public string TestSvc()
        {
            return "test svc";
        }
    }
}
