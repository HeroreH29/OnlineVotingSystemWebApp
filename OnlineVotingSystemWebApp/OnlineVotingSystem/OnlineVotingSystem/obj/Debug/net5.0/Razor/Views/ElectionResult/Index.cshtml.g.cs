#pragma checksum "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0570e12a873a80ac83316ea29404708b38c92c10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ElectionResult_Index), @"mvc.1.0.view", @"/Views/ElectionResult/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0570e12a873a80ac83316ea29404708b38c92c10", @"/Views/ElectionResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4ac2c64c0e964254eee68f6e1afbabfc884526", @"/Views/_ViewImports.cshtml")]
    public class Views_ElectionResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPieChart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
  
	ViewData["Title"] = "Vote Result";
	Layout = "~/Views/Shared/_ElectionResultLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ChairpersonResult", async() => {
                WriteLiteral("\r\n\t<td style=\"width:50%\">\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 303, "\"", 342, 1);
#nullable restore
#line 12 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 309, Url.Content(ViewBag.Chairperson), 309, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 13 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.chairpersonFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""chairpersondiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetChairperson',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'chairpersonFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].chairpersonFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.");
                WriteLiteral(@"PieChart(document.getElementById('chairpersondiv'));
						chart.draw(data, {
							title: ""Chairperson"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
	
");
            }
            );
            DefineSection("ViceChairpersonResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 2034, "\"", 2077, 1);
#nullable restore
#line 72 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 2040, Url.Content(ViewBag.ViceChairperson), 2040, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 73 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.viceChairpersonFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""vicechairpersondiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetViceChairperson',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'viceChairpersonFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].viceChairpersonFullName, Data[i].voteCount]);
						}

						var chart = new googl");
                WriteLiteral(@"e.visualization.PieChart(document.getElementById('vicechairpersondiv'));
						chart.draw(data, {
							title: ""Vice Chairperson"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("SecretaryResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 3789, "\"", 3826, 1);
#nullable restore
#line 131 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 3795, Url.Content(ViewBag.Secretary), 3795, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 132 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.secretaryFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""secretarydiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetSecretary',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'secretaryFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].secretaryFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieChart");
                WriteLiteral(@"(document.getElementById('secretarydiv'));
						chart.draw(data, {
							title: ""Secretary"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("TreasurerResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 5495, "\"", 5532, 1);
#nullable restore
#line 190 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 5501, Url.Content(ViewBag.Treasurer), 5501, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 191 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.treasurerFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""treasurerdiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetTreasurer',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'treasurerFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].treasurerFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieChart");
                WriteLiteral(@"(document.getElementById('treasurerdiv'));
						chart.draw(data, {
							title: ""Treasurer"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("AuditorResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 7199, "\"", 7234, 1);
#nullable restore
#line 249 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 7205, Url.Content(ViewBag.Auditor), 7205, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 250 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.auditorFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""auditordiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetAuditor',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'auditorFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].auditorFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieChart(documen");
                WriteLiteral(@"t.getElementById('auditordiv'));
						chart.draw(data, {
							title: ""Auditor"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("FourthYearResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 8890, "\"", 8924, 1);
#nullable restore
#line 308 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 8896, Url.Content(ViewBag.Fourth), 8896, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 309 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.fourthYearFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""fourthyeardiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetFourthYear',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'fourthYearFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].fourthYearFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieC");
                WriteLiteral(@"hart(document.getElementById('fourthyeardiv'));
						chart.draw(data, {
							title: ""4th Year Representative"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("ThirdYearResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 10613, "\"", 10646, 1);
#nullable restore
#line 367 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 10619, Url.Content(ViewBag.Third), 10619, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 368 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.thirdYearFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""thirdyeardiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetThirdYear',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'thirdYearFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].thirdYearFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieChart");
                WriteLiteral(@"(document.getElementById('thirdyeardiv'));
						chart.draw(data, {
							title: ""3rd Year Representative"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("SecondYearResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 12330, "\"", 12364, 1);
#nullable restore
#line 426 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 12336, Url.Content(ViewBag.Second), 12336, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 427 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.secondYearFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""secondyeardiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetSecondYear',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'secondYearFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].secondYearFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieC");
                WriteLiteral(@"hart(document.getElementById('secondyeardiv'));
						chart.draw(data, {
							title: ""2nd Year Representative"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            DefineSection("FirstYearResult", async() => {
                WriteLiteral("\r\n\t<td>\r\n\t\t<table class=\"table table-borderless text-center align-items-center justify-content-center\">\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 14053, "\"", 14086, 1);
#nullable restore
#line 485 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
WriteAttributeValue("", 14059, Url.Content(ViewBag.First), 14059, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle shadow-4 mt-5\" style=\"width: 200px; height:200px\" alt=\"Avatar\"/>\r\n\t\t\t\t\t<h5 class=\"mt-1\">");
#nullable restore
#line 486 "E:\Hero\3rd Year\WEBFRAME\VS2022\OVS\OnlineVotingSystem\OnlineVotingSystem\Views\ElectionResult\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => Model.firstYearFullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
				</td>
			</tr>
		</table>
	</td>
	<td>
		<div class=""container"">
			<div class=""row"">
				<div class=""col-lg-12"">
					<div id=""firstyeardiv"" style=""width:600px; height:350px"">

					</div>
				</div>
			</div>
		</div>
		<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
		<script type=""text/javascript"">
			google.charts.load('current', { 'packages': ['corechart'] });
			google.charts.setOnLoadCallback(DrawonLoad);

			function DrawonLoad(){
				$(function () {
					$.ajax({
					type:'GET',
					url: '/ElectionResult/GetFirstYear',
					success: function (chartsdata){
						var Data = chartsdata.jsonList;
						var data = new google.visualization.DataTable();

						data.addColumn('string', 'firstYearFullName');
						data.addColumn('number', 'voteCount');

						for(var i = 0;i < Data.length; i++){
							data.addRow([Data[i].firstYearFullName, Data[i].voteCount]);
						}

						var chart = new google.visualization.PieChart");
                WriteLiteral(@"(document.getElementById('firstyeardiv'));
						chart.draw(data, {
							title: ""1st Year Representative"",
							position: ""top"",
							fontsize: ""14px"",
							is3D: true
						});
					},
					error: function (){
						alert('Error loading data! Please try again.')
					}
				})
			});
		}
		</script>
	</td>
");
            }
            );
            WriteLiteral("\r\n\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPieChart> Html { get; private set; }
    }
}
#pragma warning restore 1591