using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp.net.core.mvc_turorial.Controllers
{
    //Controller 의 모든 public 메서드는 HTTP 엔드포인트로 호출할 수 있다.
    public class HelloWorldController : Controller
    {
        //GET : /HelloWorld/
        public IActionResult Index()
        {
            //return "This is my default action";
            return View();
        }

        /*
        //GET: /HelloWorld/Welcome
        public String Welcome()
        {
            return "This is the Welcome action method...";
        }
        */

        /*
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        // ex) /HelloWorld/Welcome?name=park&numTimes=5

        public String Welcome(String name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        */

        /*
        // ex) https://localhost:5001/HelloWorld/Welcome/3?name=park
        // default 3번째 인자가 id 이기 때문에 매개변수 명과 일치하여 연결
        // "{controller=Home}/{action=Index}/{id?}");
        public String Welcome(String name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
        */
        
        public IActionResult Welcome(String name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}