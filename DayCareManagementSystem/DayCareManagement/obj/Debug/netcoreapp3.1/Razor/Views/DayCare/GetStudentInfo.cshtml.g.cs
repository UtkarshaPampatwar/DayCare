#pragma checksum "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca733b7bf66e9d35c68e40463b0d9da14956048"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DayCare_GetStudentInfo), @"mvc.1.0.view", @"/Views/DayCare/GetStudentInfo.cshtml")]
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
#line 1 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\_ViewImports.cshtml"
using DayCareManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\_ViewImports.cshtml"
using DayCareManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca733b7bf66e9d35c68e40463b0d9da14956048", @"/Views/DayCare/GetStudentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ebb2276d9fbe78fea4f96132d82d95cf79834b", @"/Views/_ViewImports.cshtml")]
    public class Views_DayCare_GetStudentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DayCareManagement.Models.Student>
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
#nullable restore
#line 2 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
  
    ViewData["Title"] = "GetStudentInfo";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
 using (Html.BeginForm("RetrieveStudentInfo", "DayCare", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>GetStudentInfo</h1>\n    <label>Enter the student Id: <span></span> </label>\n    <input id=\"ID\" name=\"ID\" type=\"text\" required />\n    <input type=\"submit\" value=\"Search\" />\n    <p></p>\n");
#nullable restore
#line 12 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
  
    var data = ViewData.Model;
    if (data != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table style=""width:100%;border: 1px solid black"">
            <tr style=""border: 1px solid black"">

                <th>FirstName</th>
                <th>LastName</th>
                <th>Age</th>
                <th>Address</th>
                <th>Father's Name</th>
                <th>Mother's Name</th>
                <th>Date of Joining</th>
                <th>Date of Birth</th>
            </tr>
            <tr style=""border: 1px solid black"">
                <td>");
#nullable restore
#line 31 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 34 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 36 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.MotherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 37 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.DateOfJoining);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 38 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
               Write(data.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>

        </table>
        <p></p>
        <table style=""width:100%;border: 1px solid black"">
            <tr style=""border: 1px solid black"">
                <th>Hib</th>
                <th>DTap</th>
                <th>Polio</th>
                <th>Hep B</th>
                <th>MMR</th>
                <th>Varicella</th>
            </tr>
            <tr style=""border: 1px solid black"">
                <td>
");
#nullable restore
#line 54 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "Hib").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                        ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 63 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "DTap").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                         ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 72 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "Polio").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                          ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 81 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "Hepatitis B").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                                ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 90 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "MMR").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                        ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 99 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                      
                        if (@data.getImmunizationRecord() != null)
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                       Write(data.getImmunizationRecord().Where(x => x.getImmunizationName() == "Varicella").FirstOrDefault().getNextDueDate());

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
                                                                                                                                              ;


                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n        </table>\n");
#nullable restore
#line 109 "D:\My files\ajay\Masters\SEM4\C#\DayCare_v4.0\DayCare\DayCareManagementSystem\DayCareManagement\Views\DayCare\GetStudentInfo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p></p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca733b7bf66e9d35c68e40463b0d9da1495604815993", async() => {
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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DayCareManagement.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
