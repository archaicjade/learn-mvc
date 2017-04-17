using mvc.learn.com.Models;
using System.Web.Mvc;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using Webdiyer.WebControls.Mvc;

namespace mvc.learn.com.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginmodel)
        {
            if (loginmodel.UserName == "张三" && loginmodel.Password == "123456")
                Response.Write("正确！");
            else
                Response.Write("不正确！");
            return View();
        }


        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [LogActionFilter(LogMessage = "服么")]
        public ActionResult UserDetail()
        {
            UserModels userModel = new UserModels();
            userModel.UserName = "用户名";
            userModel.Password = "密码";
            userModel.Sex = 0;
            userModel.Age = 30;
            userModel.Height = 170;
            userModel.Weight = 70;
            userModel.Graduated = "毕业院校";
            return View(userModel);
        }

        [HttpPost]
        public ActionResult UserDetail(UserModels um)
        {
            if (ModelState.IsValid)
            {
                var o = um;
                return View(o);
            }

            return View();
        }


        public ActionResult UserList(int pageIndex = 1)
        {
            List<UserModels> li = new List<UserModels>();
            li.Add(new UserModels { UserName = "a" });
            li.Add(new UserModels { UserName = "b" });
            li.Add(new UserModels { UserName = "c" });
            li.Add(new UserModels { UserName = "aa" });
            li.Add(new UserModels { UserName = "bb" });
            li.Add(new UserModels { UserName = "cc" });
            li.Add(new UserModels { UserName = "aaaa" });
            li.Add(new UserModels { UserName = "bbbb" });
            li.Add(new UserModels { UserName = "cccc" });
            li.Add(new UserModels { UserName = "aaaaaaaa" });
            li.Add(new UserModels { UserName = "bbbbbbbb" });
            li.Add(new UserModels { UserName = "cccccccc" });
            li.Add(new UserModels { UserName = "cccccccc1" });
            PagedList<UserModels> items = li.AsQueryable().ToPagedList(pageIndex, 3);
            items.TotalItemCount = li.Count;
            items.CurrentPageIndex = pageIndex;
            return View(items);
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}
