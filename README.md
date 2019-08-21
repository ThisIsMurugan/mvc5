# MVC 5
#### Custom Model Binder
     Step1: class must be inherited from IModelBinder interface
     Step2: override the BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) method
     Step3: Decorate this binder with in the Controller. ([ModelBinder(typeof(CustomerModelBinder))] 
                                                                Customer objCustomer)
