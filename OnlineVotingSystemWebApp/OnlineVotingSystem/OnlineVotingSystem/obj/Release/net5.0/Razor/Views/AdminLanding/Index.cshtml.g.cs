#pragma checksum "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a791a00d972b73cb2ddb05859e122671a7b873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLanding_Index), @"mvc.1.0.view", @"/Views/AdminLanding/Index.cshtml")]
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
#line 1 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\_ViewImports.cshtml"
using OnlineVotingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\_ViewImports.cshtml"
using OnlineVotingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a791a00d972b73cb2ddb05859e122671a7b873", @"/Views/AdminLanding/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4ac2c64c0e964254eee68f6e1afbabfc884526", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminLanding_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminLandingModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DateTimePicker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "goBacktoIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminLanding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HasVoted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HasNotVoted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "endNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "acceptCandi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "rejectCandi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
  
	ViewData["Title"] = "Admin Dashboard";
	

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--NAVIGATION BAR START SKRRT PANG PANG STICKY ICKY GOOD KUSH-->
<nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
	<div class=""container-fluid"" style=""padding:5px;"">
		<span class=""navbar-brand mb-0 h1"" style=""margin-left:20px;"">Pending Candidacy Registration</span>
		<div class=""d-flex me-5 pe-5"" id=""navbarNavDropdown""> 
			<ul class=""navbar-nav"">
				<li class=""nav-item ms-2"">
					<button class=""btn btn-light"" aria-current=""page"" style=""width:100%;"" type=""button"" disabled>Manage Candidates</button>
				</li>
				<li class=""nav-item ms-2"">
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b8737829", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<button type=\"submit\" class=\"btn btn-outline-light\">Pick a date</button>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
				</li>
				<li class=""nav-item ms-2"">
					<button type=""submit"" class=""btn btn-outline-light"" data-bs-toggle=""modal"" data-bs-target=""#endElection"">End Election</button>
				</li>
				<li class=""nav-item ms-2"">
					<button type=""submit"" class=""btn btn-outline-light"" data-bs-toggle=""modal"" data-bs-target=""#staticBackdrop"">Voters Log</button>
				</li>
				<li class=""nav-item ms-2"">
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b8739782", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<button class=\"btn btn-outline-light\" style=\"width:100%;\" type=\"submit\">Log out</button>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
				</li>
			</ul>
		</div>
	</div>
</nav>
<!--Modal for Voters Log-->
<div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
			  <div class=""modal-dialog modal-dialog-centered"">
				<div class=""modal-content"">
				  <div class=""modal-header"">
					<h5 class=""modal-title"" id=""staticBackdropLabel"">Please choose if you are a voter or a candidate</h5>
					<button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
				  </div>
				  <div class=""modal-body mt-3"" style=""padding: 0 20%;"">
					<p>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b87312033", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-primary\" style=\"width:45%\">Voters Log (Voted)</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" or \r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b87313720", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<button type=\"button\"  class=\"btn btn-primary\"style=\"width:45%\">Voters Log (Not Voted)</button>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					</p>
				  </div>
				</div>
			  </div>
			</div>
<!--Modal for End Election-->
<div class=""modal fade"" id=""endElection"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
			  <div class=""modal-dialog modal-dialog-centered"">
				<div class=""modal-content"">
				  <div class=""modal-header"">
					<h5 class=""modal-title"" id=""staticBackdropLabel"">Are you <b>SURE</b> you want to end the Election <b>NOW</b></h5>
				  </div>
				  <div class=""modal-body mt-3"" style=""padding: 0 20%;"">
					<p>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b87316028", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-success\" style=\"width:45%\">Accept</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" or \r\n\t\t\t\t\t\t<button type=\"button\" class=\"btn btn-danger\" data-bs-dismiss=\"modal\" aria-label=\"Close\" style=\"width:45%\">Return</button>\r\n\t\t\t\t\t</p>\r\n\t\t\t\t  </div>\r\n\t\t\t\t</div>\r\n\t\t\t  </div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 75 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
   
	if(Model != null)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<table class=\"table\">\r\n\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td class=\"ms-2\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 3475, "\"", 3520, 1);
#nullable restore
#line 83 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
WriteAttributeValue("", 3481, Url.Content(ViewBag.AdminLandingImage), 3481, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle shadow-4\" style=\"width: 150px;\" alt=\"Avatar\" target=\"_blank\"/>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 87 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.candidateFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - \"");
#nullable restore
#line 87 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.candidateYearSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h5>\r\n\t\t\t\t\t\t\t\t<p style=\"font-weight:normal; font-size:small;\"><b>Position:</b> \"");
#nullable restore
#line 88 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.candidatePosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n\t\t\t\t\t\t\t\t<p style=\"font-weight:normal; font-size:small;\"><b>Background:</b> \"");
#nullable restore
#line 89 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => item.candidateBackground));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n\t\t\t\t\t\t\t\t<p style=\"font-weight:normal; font-size:small;\"><b>Achievements:</b> \"");
#nullable restore
#line 90 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem => item.candidateAchievements));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n\t\t\t\t\t\t\t\t<p style=\"font-weight:normal; font-size:small;\"><b>Background:</b> \"");
#nullable restore
#line 91 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => item.candidatePersonalQualities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</p>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</td>\r\n\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b87321864", async() => {
                WriteLiteral("Accept Candidate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-personId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                    WriteLiteral(item.candidateFullName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-personId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a791a00d972b73cb2ddb05859e122671a7b87324218", async() => {
                WriteLiteral("Reject Candidate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-personId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                                                                    WriteLiteral(item.candidateFullName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-personId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n\t\t\t\t\t</table> \r\n");
#nullable restore
#line 103 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
                 
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"text-center mx-auto\">\r\n\t\t\t\t\t<h3>No pending candidates are listed.</h3>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 110 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\AdminLanding\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminLandingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
