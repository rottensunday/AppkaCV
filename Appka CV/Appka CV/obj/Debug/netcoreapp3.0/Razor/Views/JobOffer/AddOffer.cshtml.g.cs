#pragma checksum "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de2e99df57b0bb2b44292dc83e553cd0815e97f1"
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
#nullable restore
#line 4 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2e99df57b0bb2b44292dc83e553cd0815e97f1", @"/Views/JobOffer/AddOffer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c0fbd94f067aee304abe0ea45292254460eae1", @"/Views/_ViewImports.cshtml")]
    public class Views_JobOffer_AddOffer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/address.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/kategoria.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/pozycja.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/obrazki/gotowka.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cvform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("grid-template-rows: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p style=\"margin-top: 100px; margin-left: 40px; font-family: Roboto; font-size: 64px; color:white;\">Dodaj ofertę</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e99df57b0bb2b44292dc83e553cd0815e97f17279", async() => {
                WriteLiteral(@"

    <div class=""cvexpand2"" style=""grid-row-gap: 30px"">
        <div class=""cvline1"" style=""grid-column: 1 / span 2; margin-top: 20px;""></div>
        <div class=""wyksztalcenie"" style=""height: 30px;"">Firma:</div>
        <select class=""wyksztalcenietext"" style=""height: 30px; width: 150px;"" id=""companies"" data-bind=""readSelectedText: company"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e99df57b0bb2b44292dc83e553cd0815e97f17918", async() => {
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
            <input type=""text"" style=""margin-left: 60px; margin-right: 30px; width: 400px;"" id=""title"" name=""title"" data-bind=""value: jobTitle"">
        </div>
        <div class=""zainteresowania"">Opis:</div>
        <textarea style=""margin-left: 60px; width: 700px; height: 170px;"" id=""description""></textarea>
        <div class=""jezyki"">Kategoria:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""category"" data-bind=""value: category"">
        <div class=""adres"">Pozycja:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""position"" data-bind=""value: position"">
        <div class=""adres"" style=""grid-column: 1; grid-row: 7;"">Zarobki:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""salaryFrom"" data-bind=""value: salaryFrom"">
        <div c");
                WriteLiteral(@"lass=""adres"" style=""grid-column: 1; grid-row: 8;"">Miasto:</div>
        <input type=""text"" style=""margin-left: 60px; width: 400px;"" id=""city"" data-bind=""value: city"">
        <div class=""cvline2"" style=""grid-column: 1 / span 2; grid-row: 9;""></div>
        <div class=""adres"" style=""grid-column: 1; grid-row: 10; margin-bottom: 20px;"">Logo firmy:</div>
        <input type=""file"" id=""file"">
        <div style=""grid-row: 11; grid-column-start: span 2; display:flex; justify-content: center;"">
            <div class=""oferta"" style=""margin-top: 0px;"">
                <div class=""logo""><img id=""img"" style=""width: 100%; height: 100%;""></div>
                <div class=""workcontent"">
                    <div class=""worktitle"" data-bind=""text: jobTitle""></div>
                    <div class=""firma"" data-bind=""text: company""></div>
                    <div class=""addressicon"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de2e99df57b0bb2b44292dc83e553cd0815e97f111632", async() => {
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
                WriteLiteral("</div>\r\n                    <div class=\"categoryicon\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de2e99df57b0bb2b44292dc83e553cd0815e97f112774", async() => {
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
                WriteLiteral("</div>\r\n                    <div class=\"positionicon\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de2e99df57b0bb2b44292dc83e553cd0815e97f113916", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                    <div class=\"cashicon\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de2e99df57b0bb2b44292dc83e553cd0815e97f115054", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                    <div class=""address"" data-bind=""text: city""></div>
                    <div class=""category"" data-bind=""text: category""></div>
                    <div class=""position"" data-bind=""text: position""></div>
                    <div class=""cash"" data-bind=""text: salaryFrom""></div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 46 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
         if (Model == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button type=""button"" style=""margin-right: 100px; margin-bottom: 50px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px;
                    height: 40px; color: white; font-weight: bold; grid-column: 2; justify-self: end; margin-bottom: 20px; margin-right: 20px;"" class=""offerButton"">
                Dodaj
            </button>
");
#nullable restore
#line 52 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button type=""button"" style=""margin-right: 100px; margin-bottom: 50px; background: #3BB55D; box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25); border: none; font-family: Roboto; width: 170px;
                    height: 40px; color: white; font-weight: bold; grid-column: 2; justify-self: end; margin-bottom: 20px; margin-right: 20px;"" class=""offerButton"">
                Zapisz
            </button>
");
#nullable restore
#line 59 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
<script src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.5.0/knockout-min.js""></script>
<script>
    var info = ");
#nullable restore
#line 70 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var uri;\r\n    var fileData = \"\";\r\n    var fileName = \"\";\r\n    if (info == 0) uri = \'");
#nullable restore
#line 74 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
                     Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'/api/JobOffers\';\r\n    else uri = \'");
#nullable restore
#line 75 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
           Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/api/JobOffers/' + info;
    const inputElement = document.getElementById(""file"");
    inputElement.addEventListener(""change"", loadFile, false);

    function loadFile() {
        var reader = new FileReader();
        reader.onload = function () {
            fileData = reader.result;
            document.getElementById(""img"").src = reader.result;
        };
        reader.readAsDataURL(document.getElementById(""file"").files[0]);
    }

    var companiesRequest = $.ajax({
        url: '");
#nullable restore
#line 89 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
         Write(Startup.Configuration["ApiAddress"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/api/Companies',
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        async: false
    });
    var request = $.ajax({
        url: uri,
        type: 'GET',
        contentType: 'application/json; charset=utf-8'
    });

    ko.bindingHandlers.readSelectedText = {
      init: function(element, valueAccessor) {
        var value = valueAccessor();

        $(element).change(function() {
          value($(""option:selected"", this).text());
        });
      },
      update: function(element, valueAccessor) {}
    };

    $(document).ready(function () {
        companiesRequest.done(function (data) {
            $.each(data, function (key, item) {
                $(""#companies"").append($(""<option></option>"").text(item.name).val(item.id));
            });
        });
        if (info != 0) {
            request.done(function (data) {
                document.getElementById(""companies"").value = data.company.id;
                document.getElementBy");
            WriteLiteral(@"Id(""title"").setAttribute('value', data.jobTitle);
                document.getElementById(""description"").innerHTML = data.description;
                document.getElementById(""category"").setAttribute('value', data.category);
                document.getElementById(""position"").setAttribute('value', data.position);
                document.getElementById(""salaryFrom"").setAttribute('value', data.salaryFrom);
                document.getElementById(""city"").setAttribute('value', data.city);
                document.getElementById(""img"").src = data.fileData;
                fileName = data.fileName;
                fileData = data.fileData;
                ko.applyBindings(new AppViewModel());
            });
        }
        else ko.applyBindings(new AppViewModel());

        $('#info').validate({ // initialize plugin
        // rules & options,
            rules: {
                title: {
                    required: true
                }
            },
            messages: {
          ");
            WriteLiteral("      title: {\r\n                    required: \"Tytuł nie może być pusty.\"\r\n                }\r\n            },\r\n            submitHandler: function (form) {\r\n                if (");
#nullable restore
#line 147 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
               Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 0) addOffer();\r\n                else editOffer(");
#nullable restore
#line 148 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
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

    
    function AppViewModel() {
        this.jobTitle = ko.observable(document.getElementById(""title"").getAttribute('value'));
        this.category = ko.observable(document.getElementById('category').getAttribute('value'));
        this.position = ko.observable(document.getElementById('position').getAttribute('value'));
        this.salaryFrom = ko.observable(document.getElementById('salaryFrom').getAttribute('value'));
        this.city = ko.observable(document.getElementById('city').getAttribute('value'));
        var company = document.getElementById(""companies"");
        var companyId = company.value;
        var companyName = company.options[company.selectedIndex].text;
        this.company = ko.observable(companyName);
    }


    function addOffer() {
        var ");
            WriteLiteral(@"jobTitle = document.getElementById(""title"").value;
        var description = document.getElementById(""description"").value;
        var category = document.getElementById(""category"").value;
        var position = document.getElementById(""position"").value;
        var salaryFrom = document.getElementById(""salaryFrom"").value;
        var city = document.getElementById(""city"").value;
        var company = document.getElementById(""companies"");
        var companyId = company.value;
        var companyName = company.options[company.selectedIndex].text;
        if (typeof (document.getElementById(""file"").files[0]) != 'undefined') {
            fileName = document.getElementById(""file"").files[0].name;
        }
        else {
            fileName = """";
            fileData = """";
        }
        $.ajax({
            url: uri,
            type: 'POST',
            data: JSON.stringify({
                jobTitle: jobTitle,
                description: description,
                category: catego");
            WriteLiteral(@"ry,
                position: position,
                salaryFrom: salaryFrom,
                city: city,
                company: {
                    id: companyId,
                    name: companyName
                },
                hr: '");
#nullable restore
#line 204 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
                Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                fileData: fileData,
                fileName: fileName

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
        var companyId = company.value;
        var companyName = company.options[company.selectedIndex].text;
        if (typeof (document.getElementById(""file"").files[0]) != 'undefined') {");
            WriteLiteral(@"
            fileName = document.getElementById(""file"").files[0].name;
        }
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
                },
                hr: '");
#nullable restore
#line 243 "D:\NAUKA\source\repos\AppkaCVRepo2\Appka CV\Appka CV\Views\JobOffer\AddOffer.cshtml"
                Write(User.Claims.FirstOrDefault(x => x.Type == "emails")?.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                fileData: fileData,
                fileName: fileName
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
