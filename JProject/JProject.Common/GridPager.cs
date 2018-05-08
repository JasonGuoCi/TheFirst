using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.Common
{
    public class GridPager
    {
        //每页行数
        public int rows { get; set; }

        //当前页是第几页
        public int page { get; set; }

        //排序方式
        public string order { get; set; }
        //排序列
        public string sort { get; set; }
        //总行数
        public int totalRows { get; set; }

        public int totalPages
        {
            get
            {
                return (int)Math.Ceiling((float)totalRows / (float)rows);
            }
        }
    }
}
