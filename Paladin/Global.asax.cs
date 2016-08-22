using AutoMapper;
using Ar.Present.Infrastructure;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ar.Inf.Binder;
using Ar.Inf.Common;
using Ar.Model;
using Ar.Model.ViewModels;

namespace Ar.Present
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["ActiveTheme"]))
            {
                var activeTheme = ConfigurationManager.AppSettings["ActiveTheme"];
                ViewEngines.Engines.Insert(0, new ThemeViewEngine(activeTheme));
            }
            ModelBinderProviders.BinderProviders.Add(new XmlModelBinderProvider());

            ValueProviderFactories.Factories.Insert(0, new HttpValueProviderFactory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Mapper.Initialize(cfg => {
                cfg.CreateMap<ApplicantVM, Applicant>();
                cfg.CreateMap<VehicleVM, Vehicle>();
                cfg.CreateMap<AddressVM, Address>();
                cfg.CreateMap<EmploymentVM, Employment>();
                cfg.CreateMap<ProductsVM, Products>();
                cfg.CreateMap<Applicant, ApplicantVM>();
                cfg.CreateMap<Vehicle, VehicleVM>();
                cfg.CreateMap<Address, AddressVM>();
                cfg.CreateMap<Employment, EmploymentVM>();
                cfg.CreateMap<Products, ProductsVM>();
            });

         
        }
    }
}
