using ITI_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI_Project.Controllers
{
    public class StudentsController : Controller
    {
        public string GetName()
        {
            return "Ali";
        }

        public ContentResult GetName2()
        {
            ContentResult contentResult = new ContentResult();
            contentResult.Content = "ali";
            return contentResult;
        }

        public JsonResult GetJson()
        {
            JsonResult result = new JsonResult(new {id=10,name="ali"});
            return result;
        }

        public ViewResult GetView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "test"; 
            return result;
        }

        public ActionResult GetData(int id) {
            if ((id % 2) == 0)
            {
                return View("test");
            }
            else
            {
                return Content("not valid");
            }
        }

        public ActionResult GetStudentData()
        {
            Student studentObj = new Student()
            {
                Id = 10,
                Name = "ali",
                Address = "Cairo",
                Age = 17
            };

            return View("student",studentObj);
        }
    }
}
