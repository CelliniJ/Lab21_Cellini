#pragma checksum "C:\Users\Joseph Cellini\Desktop\Grand Circus Labs & Excersices\Lab21and25_Cellini\Lab21and25_Cellini\Views\Home\RegistrationResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08726fde623e89d2799bbfeefbf17ef33243247a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegistrationResult), @"mvc.1.0.view", @"/Views/Home/RegistrationResult.cshtml")]
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
#line 1 "C:\Users\Joseph Cellini\Desktop\Grand Circus Labs & Excersices\Lab21and25_Cellini\Lab21and25_Cellini\Views\_ViewImports.cshtml"
using Lab21and25_Cellini;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joseph Cellini\Desktop\Grand Circus Labs & Excersices\Lab21and25_Cellini\Lab21and25_Cellini\Views\_ViewImports.cshtml"
using Lab21and25_Cellini.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08726fde623e89d2799bbfeefbf17ef33243247a", @"/Views/Home/RegistrationResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e992cd6015517261e305117a8e5c9892d2119c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegistrationResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joseph Cellini\Desktop\Grand Circus Labs & Excersices\Lab21and25_Cellini\Lab21and25_Cellini\Views\Home\RegistrationResult.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Registration Result</h1>\r\n\r\n<h3>");
#nullable restore
#line 9 "C:\Users\Joseph Cellini\Desktop\Grand Circus Labs & Excersices\Lab21and25_Cellini\Lab21and25_Cellini\Views\Home\RegistrationResult.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered.</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
