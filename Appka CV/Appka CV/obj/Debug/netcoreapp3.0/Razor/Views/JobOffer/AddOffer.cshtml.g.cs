#pragma checksum "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32c92cdbaa595fdfd77f2027414607ef624c1b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobOffer_AddOffer), @"mvc.1.0.view", @"/Views/JobOffer/AddOffer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32c92cdbaa595fdfd77f2027414607ef624c1b0", @"/Views/JobOffer/AddOffer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ba3feedf1a3b2f895fda9cc5639b2654bd12f5", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_AddOffer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cvform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("grid-template-rows: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p style=\"margin-top: 100px; margin-left: 40px; font-family: Roboto; font-size: 64px; color:white;\">Dodaj ofertę</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32c92cdbaa595fdfd77f2027414607ef624c1b05275", async() => {
                WriteLiteral(@"

    <div class=""cvexpand2"" style=""grid-row-gap: 30px"">
        <div class=""cvline1"" style=""grid-column: 1 / span 2; margin-top: 20px;""></div>
        <div class=""wyksztalcenie"" style=""height: 30px;"">Firma:</div>
        <select class=""wyksztalcenietext"" style=""height: 30px; width: 150px;"" id=""companies"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b32c92cdbaa595fdfd77f2027414607ef624c1b05874", async() => {
                    WriteLiteral("Wybierz firmę");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>
        <div class=""umiejetnosci"" style=""grid-row: 3; grid-column: 1;"">Tytuł:</div>
        <div style=""grid-row:3; grid-column:2; width: 700px; display: flex;"">
            <input type=""text"" style=""margin-left: 60px; margin-right: 30px; width: 400px;"" id=""title"" name=""title"">
        </div>
        <div class=""zainteresowania"">Opis:</div>
        <textarea style=""margin-left: 60px; width: 700px; height: 170px;"" id=""description""></textarea>
        <div class=""jezyki"">Kategoria:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""category"">
        <div class=""adres"">Pozycja:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""position"">
        <div class=""adres"" style=""grid-column: 1; grid-row: 7;"">Zarobki:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""salaryFrom"">
        <div class=""adres"" style=""grid-column: 1; grid-row: 8;"">Miasto:</div>
        <input type=""text"" style=""margin-left: 60");
                WriteLiteral("px; width: 400px;\" id=\"city\">\r\n        <div class=\"cvline2\" style=\"grid-column: 1 / span 2; grid-row: 9;\"></div>\r\n        <div class=\"adres\" style=\"grid-column: 1; grid-row: 10; margin-bottom: 20px;\">Logo firmy:</div>\r\n        <input type=\"file\">\r\n");
#nullable restore
#line 32 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
         if (Model == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button type=""button""  style=""margin-right: 100px; margin-bottom: 50px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px;
                    height: 40px; color: white; font-weight: bold; grid-column: 2; justify-self: end; margin-bottom: 20px; margin-right: 20px;"" class=""offerButton"">
                Dodaj
            </button>
");
#nullable restore
#line 38 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button type=""button""  style=""margin-right: 100px; margin-bottom: 50px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px;
                    height: 40px; color: white; font-weight: bold; grid-column: 2; justify-self: end; margin-bottom: 20px; margin-right: 20px;"" class=""offerButton"">
                Zapisz
            </button>
");
#nullable restore
#line 45 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
    var info = ");
#nullable restore
#line 55 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var uri;\r\n    if (info == 0) uri = \'");
#nullable restore
#line 57 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
                     Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/api/JobOffers\';\r\n    else uri = \'");
#nullable restore
#line 58 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
           Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/api/JobOffers/\' + info;\r\n\r\n    var companiesRequest = $.ajax({\r\n        url: \'");
#nullable restore
#line 61 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
         Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/api/Companies',
        type: 'GET',
        contentType: 'application/json; charset=utf-8'
    });
    var request = $.ajax({
        url: uri,
        type: 'GET',
        contentType: 'application/json; charset=utf-8'
    });


    $(document).ready(function () {
        companiesRequest.done(function (data) {
            $.each(data, function (key, item) {
                $(""#companies"").append($(""<option></option>"").text(item.name).val(item.id));
        });
        if (info != 0) {
        request.done(function (data) {
            document.getElementById(""companies"").value = data.company.id;
            document.getElementById(""title"").setAttribute('value', data.jobTitle);
            document.getElementById(""description"").innerHTML = data.description;
            document.getElementById(""category"").setAttribute('value', data.category);
            document.getElementById(""position"").setAttribute('value', data.position);
            document.getElementById(""salaryFrom"").set");
            WriteLiteral(@"Attribute('value', data.salaryFrom);
            document.getElementById(""city"").setAttribute('value', data.city);
            })
            }

        $('#info').validate({ // initialize plugin
        // rules & options,
            rules: {
                title: {
                    required: true
                }
            },
            messages: {
                title: {
                    required: ""Tytuł nie może być pusty.""
                }
            },
            submitHandler: function (form) {
                if (");
#nullable restore
#line 102 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
               Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 0) addOffer();\r\n                else editOffer(");
#nullable restore
#line 103 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
                return false;  // blocks regular submit since you have ajax
            }
        });

        $('.offerButton').on('click', function () {
            $('#info').submit();
        });

    });


    })

    function addOffer() {
        var jobTitle = document.getElementById(""title"").value;
        var description = document.getElementById(""description"").value;
        var category = document.getElementById(""category"").value;
        var position = document.getElementById(""position"").value;
        var salaryFrom = document.getElementById(""salaryFrom"").value;
        var city = document.getElementById(""city"").value;
        var company = document.getElementById(""companies"");
        var companyId = company.value;
        var companyName = company.options[company.selectedIndex].text;
        $.ajax({
            url: uri,
            type: 'POST',
            data: JSON.stringify({
                jobTitle: jobTitle,
                description: description,
   ");
            WriteLiteral(@"             category: category,
                position: position,
                salaryFrom: salaryFrom,
                city: city,
                company: {
                    id: companyId,
                    name: companyName
                }
            }),
            contentType: 'application/json; charset=utf-8',
            success: function(result) { window.alert(""Dodano ofertę!""); },
            error: function (result) { window.alert(""Nie udało się dodać oferty.""); }
        })
    }

    function editOffer(id) {
        var jobTitle = document.getElementById(""title"").value;
        var description = document.getElementById(""description"").value;
        var category = document.getElementById(""category"").value;
        var position = document.getElementById(""position"").value;
        var salaryFrom = document.getElementById(""salaryFrom"").value;
        var city = document.getElementById(""city"").value;
        var company = document.getElementById(""companies"");
       ");
            WriteLiteral(@" var companyId = company.value;
        var companyName = company.options[company.selectedIndex].text;
        $.ajax({
            url: uri,
            type: 'PUT',
            data: JSON.stringify({
                id: id,
                jobTitle: jobTitle,
                description: description,
                category: category,
                position: position,
                salaryFrom: salaryFrom,
                city: city,
                company: {
                    id: companyId,
                    name: companyName
                }
            }),
            contentType: 'application/json; charset=utf-8',
            success: function(result) { window.alert(""Zmieniono ofertę!""); },
            error: function (result) { window.alert(""Nie udało się zmienić oferty.""); }
        })
    }
</script>");
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
