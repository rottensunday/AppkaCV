#pragma checksum "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98c987a0846065f4006259b7b02cdbd9293ea939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_AddCompany), @"mvc.1.0.view", @"/Views/Administrator/AddCompany.cshtml")]
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
#line 1 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Appka_CV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Appka_CV.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Appka_CV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98c987a0846065f4006259b7b02cdbd9293ea939", @"/Views/Administrator/AddCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ba3feedf1a3b2f895fda9cc5639b2654bd12f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_AddCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: flex; margin-left: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p style=\"margin-top: 100px; margin-left: 120px; font-family: Roboto; font-size: 64px; color:white;\">Dodaj/Zmień firmę</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98c987a0846065f4006259b7b02cdbd9293ea9394854", async() => {
                WriteLiteral("\r\n    <span style=\"font-family: Roboto; color: white; font-size: 20px;\">Nazwa firmy:</span>\r\n    <input type=\"text\" style=\"margin-left: 50px; margin-right: 30px; width: 200px;\" id=\"name\" name=\"name\" />\r\n");
#nullable restore
#line 10 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
     if (@Model == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"button\" style=\"margin-left: 200px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px; color: white; font-weight: bold;\" class=\"companyButton\">Dodaj firmę</button>\r\n");
#nullable restore
#line 13 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"button\" style=\"margin-left: 200px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px; color: white; font-weight: bold;\" class=\"companyButton\">Zmień nazwę</button>\r\n");
#nullable restore
#line 17 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
                                                                      Write(Model);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-idcompany", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.1/jquery.validate.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js""></script>
<script>
    var info = document.getElementById(""info"").dataset.idcompany;
    var uri;
    if (info == 0) uri = '");
#nullable restore
#line 28 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
                     Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/api/Companies\';\r\n    else uri = \'");
#nullable restore
#line 29 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
           Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/api/Companies/' + info;

    var request = $.ajax({
        url: uri,
        type: 'GET',
        contentType: 'application/json; charset=utf-8'
    });
    $(document).ready(function () {
        if (info != 0) {
            request.done(function (data) {
                document.getElementById(""name"").setAttribute('value', data.name);
            });
        }
        $('#info').validate({ // initialize plugin
        // rules & options,
            rules: {
                name: {
                    required: true
                }
            },
            messages: {
                name: {
                    required: ""Nazwa nie może być pusta.""
                }
            },
            submitHandler: function (form) {
                if (");
#nullable restore
#line 55 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
               Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 0) addCompany();\r\n                else editCompany(");
#nullable restore
#line 56 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\Administrator\AddCompany.cshtml"
                            Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
                return false;  // blocks regular submit since you have ajax
            }
        });
        $('.companyButton').on('click', function () {
            $('#info').submit();
        });

    })

    function addCompany() {
        var name = document.getElementById(""name"").value;
        $.ajax({
            url: uri,
            type: 'POST',
            data: JSON.stringify({ name: name, }),
            contentType: 'application/json; charset=utf-8',
            success: function(result) { window.alert(""Dodano firmę!""); },
            error: function (result) { window.alert(""Nie udało się dodać firmy.""); }
        })
    }

    function editCompany(id) {
        var name = document.getElementById(""name"").value;
        $.ajax({
            url: uri,
            type: 'PUT',
            data: JSON.stringify({ id: id, name: name }),
            contentType: 'application/json; charset=utf-8',
            success: function(result) { window.alert(""Zmieniono nazwę!"")");
            WriteLiteral("; },\r\n            error: function (result) { window.alert(\"Nie udało się zmienić nazwy.\"); }\r\n        })\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
