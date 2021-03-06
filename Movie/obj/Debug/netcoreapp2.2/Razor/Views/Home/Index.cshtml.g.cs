#pragma checksum "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f2293e927ef747fbb7632312a1df32f6586929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\_ViewImports.cshtml"
using Movie;

#line default
#line hidden
#line 2 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\_ViewImports.cshtml"
using Movie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2293e927ef747fbb7632312a1df32f6586929", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1bac32f50c0b8229b0984a69d01eeb7178b0b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Movies Catalogue";
    // Layout = null;

#line default
#line hidden
            BeginContext(459, 35, true);
            WriteLiteral("    <h3>Movies</h3>\r\n<br /><br />\r\n");
            EndContext();
#line 23 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Get))
{
    

#line default
#line hidden
            BeginContext(560, 25, false);
#line 25 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
Write(Html.TextBox("searching"));

#line default
#line hidden
            EndContext();
            BeginContext(585, 40, true);
            WriteLiteral("<input type=\"submit\" value=\"Search\" />\r\n");
            EndContext();
#line 26 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(628, 161, true);
            WriteLiteral("    <table class=\"table-condensed\">\r\n        <thead>\r\n            <tr>\r\n                <td><b>Name</b></td>\r\n                <td><b>Year, when issued</b></td>\r\n");
            EndContext();
            BeginContext(828, 222, true);
            WriteLiteral("                <td><b>Release Date</b></td>\r\n                <td><b>Runtime, minutes</b></td>\r\n                <td><b>Genre</b></td>\r\n                <td><b>IMDbRating</b></td>\r\n                <td><b>IMDbVotes</b></td>\r\n");
            EndContext();
            BeginContext(1089, 81, true);
            WriteLiteral("                <td></td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 43 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
            BeginContext(1223, 154, true);
            WriteLiteral("                <tr>\r\n                    <td colspan=\"7\" style=\"color:red\">\r\n                        No Match Any Document\r\n                        <p>\r\n");
            EndContext();
            BeginContext(1635, 80, true);
            WriteLiteral("                        </p>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 55 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
            }
            else
            {
                foreach (var movie in Model)
                {

#line default
#line hidden
            BeginContext(1828, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1883, 10, false);
#line 61 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1929, 10, false);
#line 62 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1939, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(2000, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(2029, 17, false);
#line 64 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2082, 13, false);
#line 65 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.Runtime);

#line default
#line hidden
            EndContext();
            BeginContext(2095, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2131, 11, false);
#line 66 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(2142, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2178, 16, false);
#line 67 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.IMDbRating);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2230, 15, false);
#line 68 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                       Write(movie.IMDbVotes);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(2306, 31, true);
            WriteLiteral("                        <td><p>");
            EndContext();
            BeginContext(2338, 60, false);
#line 70 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                          Write(Html.ActionLink("Details", "Details", new { id = movie.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 38, true);
            WriteLiteral("</p></td>\r\n                    </tr>\r\n");
            EndContext();
#line 72 "D:\work\PrimeXM\02_test\02_Search\Movie\Movie\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2470, 42, true);
            WriteLiteral("        </tbody>\r\n        \r\n    </table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
