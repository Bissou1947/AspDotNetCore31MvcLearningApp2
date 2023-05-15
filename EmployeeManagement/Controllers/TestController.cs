using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagement.Controllers
{
    public class TestController : Controller
    {
        //....to make devloper in development mode not use this function
        //....
        [Obsolete("Please use Func1(int a, int b) , this is done before",false)] //..try make it true
        public void Func1(int a)
        {

        }
        public void Func1(int a, int b)
        {

        }
        //...try here
        public void ExecuteFunc1()
        {
            Func1(10);
        }


        //...............end.............................//

    }
}
