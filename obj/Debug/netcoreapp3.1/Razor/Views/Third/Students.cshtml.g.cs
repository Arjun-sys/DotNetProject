#pragma checksum "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f1199b7acacfdf592d4742c7f3e8b3106e0634c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Third_Students), @"mvc.1.0.view", @"/Views/Third/Students.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\Easy CSIT\Views\_ViewImports.cshtml"
using EasyCSIT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\Easy CSIT\Views\_ViewImports.cshtml"
using EasyCSIT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1199b7acacfdf592d4742c7f3e8b3106e0634c", @"/Views/Third/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c841dc2f78dc3024c0f2f0360efb9bebdc1dbcee", @"/Views/_ViewImports.cshtml")]
    public class Views_Third_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EasyCSIT.Models.StudentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Crud", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Third", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add_Markslip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
  
    ViewData["Title"] = "Students";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int studentCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1199b7acacfdf592d4742c7f3e8b3106e0634c5144", async() => {
                WriteLiteral(@"
    <style>
        /* style for the css menu dropdown container */
        .menu {
            position: relative;
            display: inline-block;
            ​ z-index:2;
            padding: 0;
            margin: 0;
            outline: 0;
            text-align: left;
        }

            /* style for the button */
            .menu:before {
                content: ""\2630 \a0 More"";
                color: #555;
                padding: 5px 10px;
                border: 1px solid #555;
                border-radius: 3px;
                background: white;
            }

            .menu:focus {
                pointer-events: none;
            }

                /* If :focus detected the dropdown menu is displayed by making it visible */
                .menu:focus .menu-dropdown {
                    opacity: 1;
                    visibility: visible;
                }

        /* style for the dropdown box */
        .menu-dropdown {
            background-col");
                WriteLiteral(@"or: white;
            width: auto;
            margin: 3px 0 0 0;
            padding: 15px;
            border-radius: 3px;
            border: 1px black solid;
            border-radius: 3px;
            pointer-events: auto;
            position: absolute;
            z-index: 1;
            opacity: 0;
            visibility: hidden;
            transition: visibility 1s;
            background: #f8f8ff;
        }

            /* style the links in the dropdown */
            .menu-dropdown a {
                background: transparent;
                border: none;
                outline: 0;
                display: block;
                color: #808080;
                text-decoration: none;
                width: 120px;
                padding: 2px;
            }

                .menu-dropdown a:hover {
                    color: black;
                }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1199b7acacfdf592d4742c7f3e8b3106e0634c8089", async() => {
                WriteLiteral(@"
    <div class=""terms"">


        <p>
            <h3><b>Student Of Third Semester</b></h3>
          
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        SN
                    </th>
                    <th>
                        ");
#nullable restore
#line 93 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 96 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.Semester));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 99 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.StudentRoll));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 102 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 105 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 108 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                   Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </th>
                    <th>
                        Action
                        &nbsp;&nbsp;
                        <div tabindex=""0"" class=""menu"">
                            <div class=""menu-dropdown"">

                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1199b7acacfdf592d4742c7f3e8b3106e0634c10895", async() => {
                    WriteLiteral("Add Student");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <hr />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1199b7acacfdf592d4742c7f3e8b3106e0634c12408", async() => {
                    WriteLiteral("Add Subject");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <hr />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f1199b7acacfdf592d4742c7f3e8b3106e0634c13921", async() => {
                    WriteLiteral("Add MarkSheet");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 130 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 134 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(studentCounter);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 137 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 140 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Semester));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 143 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StudentRoll));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 146 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 149 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Batch));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 152 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 156 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", "Crud", new { studentId = item.StudentId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
#nullable restore
#line 157 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.ActionLink("Details", "Details", "Crud", new { studentId = item.StudentId }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("|\r\n                            ");
#nullable restore
#line 158 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", "crud", new { studentId = item.StudentId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("|\r\n                            ");
#nullable restore
#line 159 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                       Write(Html.ActionLink("Marks", "StudentMarks", "crud", new { studentId = item.StudentId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 163 "C:\Users\admin\Desktop\Easy CSIT\Views\Third\Students.cshtml"
                    studentCounter++;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EasyCSIT.Models.StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
