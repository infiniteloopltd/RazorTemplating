using System;
using System.IO;
using Newtonsoft.Json.Linq;  // Install-Package Newtonsoft.JSON
using RazorEngine; // Install-Package RazorEngine.NetCore
using RazorEngine.Templating;

namespace RazorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllText("data.json");
            var template = File.ReadAllText("template.html");
            dynamic model = JObject.Parse(data);
            var result =
                Engine.Razor.RunCompile(
                    template,
                    "template",
                    null,
                    (object)model);
            Console.WriteLine(result);
        }
    }
}
