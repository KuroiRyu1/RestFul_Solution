using System.Web.Mvc;

namespace RestFul_1.Areas.myapi
{
    public class myapiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "myapi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "myapi_default",
                "myapi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}