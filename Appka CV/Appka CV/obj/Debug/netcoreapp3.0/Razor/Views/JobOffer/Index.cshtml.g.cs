#pragma checksum "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c9a7bb19e6c9c375a42ecaee61a59da4073b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer_Index), @"mvc.1.0.view", @"/Views/JobOffer/Index.cshtml")]
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
#line 1 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Appka_CV.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Appka_CV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c9a7bb19e6c9c375a42ecaee61a59da4073b00", @"/Views/JobOffer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62f4ccdd51e6248ebde0cb971ef272a21890a23", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobOffer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/szukaj.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/rightarrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: relative; margin-left: 80px; margin-top: 9px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOffer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div style=""display: flex; margin-top: 90px; margin-left: 120px; flex-direction: row;"">
    <div class=""szukaj"">
        <div class=""szukajtextbox"">
            <input type=""text"" class=""szukajka"" id=""szukajka"" placeholder=""Szukaj..."">
            <button class=""searchbutton"" onclick=""applyFilter()"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86c9a7bb19e6c9c375a42ecaee61a59da4073b005994", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n        </div>\r\n        <div class=\"filtrbutton\" id=\"filtr\" onclick=\"myFunction()\">\r\n            <div class=\"filtrtext\">Pokaż filtry</div>\r\n            <div class=\"filtrarrow\" id=\"arrow\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86c9a7bb19e6c9c375a42ecaee61a59da4073b007239", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86c9a7bb19e6c9c375a42ecaee61a59da4073b008312", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Dodaj ofertę\" style=\"background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px;\r\n        height: 40px; color: white; font-weight: bold;\"/>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<div class=""szukajexpand"" id=""szukajexpand"">
    <div class=""linia""></div>
    <div class=""dziedzina"">Dziedzina</div>
    <input type=""text"" class=""dziedzinatext"" id=""category"">
    <div class=""pozycja"">Pozycja</div>
    <input type=""text"" class=""pozycjatext"" id=""position"">
    <div class=""miasto"">Miasto</div>
    <input type=""text"" class=""miastotext"" id=""city"">
    <div class=""zarobki"">Zarobki</div>
    <input type=""text"" class=""zarobkitext"" id=""zarobki"">
</div>

");
#nullable restore
#line 33 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"offerlist\" id=\"hrid\">\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"display: flex; position: absolute; right: 100px; margin-top: 50px;\" id=\"pageid\">\r\n</div>\r\n\r\n\r\n<script src=\"https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js\"></script>\r\n<script>\r\n    var uri = \'");
#nullable restore
#line 44 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
          Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/api/JobOffers\';\r\n    var addUri = \'");
#nullable restore
#line 45 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
             Write(Url.Action("AddOffer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var nElem = 0;\r\n    var pageSize = 6;\r\n    var pageNo = 1;\r\n    var filter = \"\";\r\n    var category = \"\";\r\n    var position = \"\";\r\n    var city = \"\";\r\n    var zarobki = \"\";\r\n    var applicationUri = \'");
#nullable restore
#line 54 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                     Write(Url.Action("AddApplication", "Application"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n    var request = $.ajax({\r\n        url: uri,\r\n        type: \'GET\',\r\n        data: { pageSize: pageSize, pageNo: pageNo, email: \'");
#nullable restore
#line 59 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                                                       Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' } ,
        contentType: 'application/json; charset=utf-8'
    });

    var nElemsRequest = $.ajax({
        url: uri + '/JobOffersCount',
        type: 'GET',
        contentType: 'application/json; charset=utf-8'
    });

    $(document).ready(function () {
            nElemsRequest.done(function (data) {
                nElems = data;
                var paging = """";
                for (var i = 1; i <= Math.ceil(nElems / pageSize); i++) {
                    if(i == pageNo)
                        paging += '<button style=""border: 1px solid black; background-color: lightpink; width: 30px; height: 30px;"" id=""page' + i + '"" onclick=""changePage(' + i +')"">' + i + '</button>';
                    else
                        paging += '<button style=""border: 1px solid black; background-color: white; height: 30px; width: 30px;"" id=""page' + i + '"" onclick=""changePage(' + i +')"">' + i + '</button>';
                }
                var d1 = document.getElementById('pageid');
             ");
            WriteLiteral(@"   d1.insertAdjacentHTML('beforeend', paging);
            });
            request.done(function (data) {
                $.each(data, function (key, item) {
                    result = loadData(item);

                    var d1 = document.getElementById('hrid');
                    d1.insertAdjacentHTML('beforeend', result);
                    });
                });
        })

    function deleteItem(id) {
        var delUri = '");
#nullable restore
#line 93 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                 Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/api/JobOffers/' + id;
        $.ajax({
            url: delUri,
            type: 'DELETE',
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                document.getElementById(id).remove();
            },
            error: function (data) {
                window.alert(""Nie można usunąć!"");
            }
        });
    }

    function changePage(page) {
        document.getElementById(""page"" + pageNo).style.backgroundColor = ""white"";
        document.getElementById(""page"" + page).style.backgroundColor = ""lightpink"";
        pageNo = page;
        document.getElementById(""hrid"").innerHTML = """";

        request = $.ajax({
            url: uri,
            type: 'GET',
            data: { pageSize: pageSize, pageNo: pageNo, filter: filter, category: category, position: position, city: city, email: '");
#nullable restore
#line 116 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                                                                                                                               Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
            contentType: 'application/json; charset=utf-8'
        });
        request.done(function (data) {
            $.each(data, function (key, item) {
                result = loadData(item);

                var d1 = document.getElementById('hrid');
                d1.insertAdjacentHTML('beforeend', result);
            });
        });
    }

    function applyFilter() {
        filter = document.getElementById(""szukajka"").value;
        category = document.getElementById(""category"").value;
        position = document.getElementById(""position"").value;
        city = document.getElementById(""city"").value;
        zarobki = document.getElementById(""zarobki"").value;

        document.getElementById(""hrid"").innerHTML = """";
        document.getElementById(""pageid"").innerHTML = """";
        pageNo = 1;

        $.ajax({
            url: uri + '/JobOffersCount',
            type: 'GET',
            data: {filter: filter, category: category, position: position, city: city},
   ");
            WriteLiteral(@"         contentType: 'application/json; charset=utf-8'
        }).done(function (data) {
            nElems = data;
            var paging = """";
            for (var i = 1; i <= Math.ceil(nElems / pageSize); i++) {
                if(i == pageNo)
                    paging += '<button style=""border: 1px solid black; background-color: lightpink; width: 30px; height: 30px;"" id=""page' + i + '"" onclick=""changePage(' + i +')"">' + i + '</button>';
                else
                    paging += '<button style=""border: 1px solid black; background-color: white; height: 30px; width: 30px;"" id=""page' + i + '"" onclick=""changePage(' + i +')"">' + i + '</button>';
            }
            var d1 = document.getElementById('pageid');
            d1.insertAdjacentHTML('beforeend', paging);
        });

        $.ajax({
            url: uri,
            type: 'GET',
            data: { pageSize: pageSize, pageNo: pageNo, filter: filter, category: category, position: position, city: city, email: '");
#nullable restore
#line 161 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                                                                                                                               Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
            contentType: 'application/json; charset=utf-8'
        }).done(function (data) {
            $.each(data, function (key, item) {
                result = loadData(item);

                var d1 = document.getElementById('hrid');
                d1.insertAdjacentHTML('beforeend', result);
            });
        });

    }

    function loadData(item) {
        var result;
        var email = '");
#nullable restore
#line 176 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
                Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'

        result = '<div class=""offercard"" id=""' + item.id + '"">';
        result += '<div class=""logo""><img src=""' + item.fileData + '"" style=""width: 100%; height: 100%;""></div>';
        result += '<div class=""workcontent"">';
        result += '<div class=""worktitle"">' + item.jobTitle + '</div>';
        result += '<div class=""firma"">' + item.company.name + '</div>';
        result += '<div class=""addressicon""><img src=""obrazki/address.png""></div>'
        result += '<div class=""categoryicon""><img src=""obrazki/kategoria.png""></div>';
        result += '<div class=""positionicon""><img src=""obrazki/pozycja.png""></div>';
        result += '<div class=""cashicon""><img src=""obrazki/gotowka.png""></div>';
        result += '<div class=""address"">' + item.city + '</div>';
        result += '<div class=""category"">' + item.category + '</div>';
        result += '<div class=""position"">' + item.position + '</div>';
        result += '<div class=""cash"">' + item.salaryFrom + '</div>';
        result += '</di");
            WriteLiteral("v>\';\r\n        result += \'<div style=\"display: flex; flex-direction: column; justify-content: end; gap: 10px;\">\';\r\n");
#nullable restore
#line 193 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
         if (User.HasClaim(claim => claim.Type == "extension_IsHR" && claim.Value == "true"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("if (email == item.hr)\r\n            ");
            WriteLiteral("{\r\n            ");
            WriteLiteral("result += \'<button class=\"firmamodyfikuj\" style=\"width: 120px; bottom: 10px; background: rgb(175, 56, 35);\" onclick=\"deleteItem(\' + item.id + \')\">Usuń</button>\';\r\n            ");
            WriteLiteral("result += \'<a class=\"firmamodyfikuj\" style=\"width: 120px; bottom: 10px; background: rgb(181, 190, 50);\" href=\"\' + addUri + \'/\' + item.id + \'\">Zmień</a>\';\r\n            ");
            WriteLiteral("}\r\n");
#nullable restore
#line 200 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
         if (User.Identity.IsAuthenticated && !(User.HasClaim(claim => claim.Type == "extension_IsHR" && claim.Value == "true") || User.HasClaim(claim => claim.Type == "extension_IsAdmin" && claim.Value == "true")))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("if (item.hasApplied) {\r\n            ");
            WriteLiteral("   result += \'<a class=\"firmamodyfikuj\" style=\"width: 120px; bottom: 10px; background: green;\" href=\"\' + applicationUri + \'/\' + item.applicationId + \'\">Zmień CV</button>\';\r\n            ");
            WriteLiteral("}\r\n            ");
            WriteLiteral("else\r\n            ");
            WriteLiteral("result += \'<a class=\"firmamodyfikuj\" style=\"width: 120px; bottom: 10px; background: #3BB55D;\" href=\"\' + applicationUri + \'?jobOffer=\' + item.id + \'\">Aplikuj</button>\';\r\n");
#nullable restore
#line 208 "D:\Nauka\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        result += \'</div>\';\r\n        result += \'</div>\';\r\n        return result;\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobOffer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
