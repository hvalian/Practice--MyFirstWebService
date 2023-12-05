using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceTest.TestWeb;

namespace WebServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 webService = new Service1();
            string srt = webService.SimpleMethod("homayoon");
            Console.WriteLine(srt);
            Console.WriteLine(webService.AnotherSimpleMethod (1,2));

        }
    }
}
