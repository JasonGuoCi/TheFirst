
using JProject.ServicesTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace JProject.ServicesTest
{

    [ServiceBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public abstract class BaseService
    {
        protected virtual JsonResult Json(Object obj)
        {
            return new JsonResult() { Data = obj };
        }

        protected virtual JsonResult Json(Exception ex)
        {
            return new JsonResult() { IsError = true, ErrorMsg = ex.Message };
        }
    }
}
