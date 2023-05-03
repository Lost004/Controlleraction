using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller 
    {


        public ViewResult Index()
        {
           ViewResult result = new ViewResult();
        }



        //   public ContentResult Index()
        // {
        // ContentResult result = new ContentResult();
        //  result.Content = "P138 Salam content";
        //result.ContentType = "test";

        //return result;
        //}


        //  public JsonResult Index()
        // {
        //      JsonResult jsonResult = new JsonResult("Salam");
        //    return jsonResult;
        //     jsonResult.StatusCode = 200;
        // }

    }
}
