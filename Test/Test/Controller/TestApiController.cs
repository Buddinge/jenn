using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Demain;
using Test.Demain.Ins;
using Volo.Abp.DependencyInjection;

namespace Test.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestApiController : ControllerBase
    {
        public TestApiController()
        {

        }



        [HttpGet]
        public async Task<string> Test(string name)
        {

            var res = typeof(Class1).Assembly;

            var types = res.GetTypes();

            foreach (var type in types)
            {

                // 获取继承 Iyyds 的
                if (type.IsAssignableTo(typeof(ITransientDependency)))
                {
                    // 它是要找到程序集下 有 "I" + type.Name 才行
                    var thisI = type.GetInterface("I" + type.Name);


                }
            }


            // var bases = res.BaseType;

            return name;
        }
    }
}