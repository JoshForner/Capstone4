#pragma checksum "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a03afda24dbbd362fc2c845c9124c380ff7faf1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_FindTask), @"mvc.1.0.view", @"/Views/User/FindTask.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\_ViewImports.cshtml"
using Capstone4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\_ViewImports.cshtml"
using Capstone4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03afda24dbbd362fc2c845c9124c380ff7faf1b", @"/Views/User/FindTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d18b1ed506511db49f214a202a5d64a36e42b6", @"/Views/_ViewImports.cshtml")]
    public class Views_User_FindTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
 foreach (Tasks task in Model)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 6 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
       Write(task.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 7 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
       Write(task.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 8 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
       Write(task.TaskDue.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
       Write(task.TaskComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 239, "\"", 276, 2);
            WriteAttributeValue("", 246, "/User/MarkComplete?id=", 246, 22, true);
#nullable restore
#line 10 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
WriteAttributeValue("", 268, task.Id, 268, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-outline-primary\">Completion Status</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 348, "\"", 379, 2);
            WriteAttributeValue("", 355, "/User/Delete?id=", 355, 16, true);
#nullable restore
#line 11 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
WriteAttributeValue("", 371, task.Id, 371, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-outline-danger\">Delete Task</a></td>\r\n");
#nullable restore
#line 12 "C:\Users\forne\source\repos\CSHARP\Capstone4\Capstone4\Views\User\FindTask.cshtml"
   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
