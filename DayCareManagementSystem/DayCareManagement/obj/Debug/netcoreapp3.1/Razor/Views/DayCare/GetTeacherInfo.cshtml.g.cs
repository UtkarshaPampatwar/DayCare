#pragma checksum "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124e15d7ece01f5f81930e26e92ccdf4e8108a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DayCare_GetTeacherInfo), @"mvc.1.0.view", @"/Views/DayCare/GetTeacherInfo.cshtml")]
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
#line 1 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\_ViewImports.cshtml"
using DayCareManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\_ViewImports.cshtml"
using DayCareManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124e15d7ece01f5f81930e26e92ccdf4e8108a6c", @"/Views/DayCare/GetTeacherInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ebb2276d9fbe78fea4f96132d82d95cf79834b", @"/Views/_ViewImports.cshtml")]
    public class Views_DayCare_GetTeacherInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DayCareManagement.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DayCare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
  
    ViewData["Title"] = "GetTeacherInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
 using (Html.BeginForm("RetrieveTeacherInfo", "DayCare", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>GetTeacherInfo</h1>\r\n    <label>Enter the teacher Id: </label>");
#nullable restore
#line 10 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
                                    Write(Html.TextBox("ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Search\" />\r\n    <p></p>\r\n");
#nullable restore
#line 14 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
   
    var data = ViewData.Model;
    if (data != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table style=""width:100%;border: 1px solid"">
            <tr>

                <th>FirstName</th>
                <th>LastName</th>
                <th>Class ID</th>
                <th>Group ID</th>
                
            </tr>
            <tr>
                <td>");
#nullable restore
#line 30 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
               Write(data.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
               Write(data.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
               Write(data.ClassID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
               Write(data.GroupID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n\r\n        </table>\r\n        <p></p>\r\n");
#nullable restore
#line 39 "C:\Users\putka\OneDrive\Documents\NEU\Sem 5\Object Oriented with C#\Project - Ajay\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetTeacherInfo.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124e15d7ece01f5f81930e26e92ccdf4e8108a6c8121", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DayCareManagement.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
