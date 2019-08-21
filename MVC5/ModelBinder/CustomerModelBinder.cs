using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.Models;

namespace MVC5.ModelBinder
{
    /// <summary>
    /// Implement the Custom Model Binder
    /// Step1: class must be inherited from IModelBinder interface
    /// Step2: override the BindModel method
    /// Step3: Decorate this binder with in the Controller
    /// </summary>
    public class CustomerModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, 
                                    ModelBindingContext bindingContext)
        {
            HttpContextBase httpContextBase = controllerContext.HttpContext;
            string custCode = httpContextBase.Request.Form["txtCustomerCode"];
            string custName = httpContextBase.Request.Form["txtCustomerName"];
            Customer objCustomer = new Customer()
                                        {
                                            CustomerCode = custCode,
                                            CustomerName = custName
                                        };
            return objCustomer;
        }
    }
}