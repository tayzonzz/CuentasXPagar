//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_ProvidersModels_Edit_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_ProvidersModels_Edit_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
  
    ViewBag.Title = "Edit";


#line default
#line hidden

#line 3 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
using (Html.BeginForm())
{
    

#line default
#line hidden

#line 4 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
__o = Html.AntiForgeryToken();


#line default
#line hidden

#line 5 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
                            
    
    

#line default
#line hidden

#line 6 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm
   __o = Html.ValidationSummary(true, "", new { @class = "text-danger" });


#line default
#line hidden

#line 7 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm
   __o = Html.HiddenFor(model => model.Id);


#line default
#line hidden

#line 8 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm       __o = Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 9 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 10 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" });


#line default
#line hidden

#line 11 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm       __o = Html.LabelFor(model => moNamerRNC, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 12 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.EditorFor(model => moNamerRNC, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 13 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.ValidationMessageFor(model => moNamerRNC, "", new { @class = "text-danger" });


#line default
#line hidden

#line 14 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm       __o = Html.LabelFor(model => moCedulaOrRNCance, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 15 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.EditorFor(model => moCedulaOrRNCance, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 16 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm           __o = Html.ValidationMessageFor(model => moCedulaOrRNCance, "", new { @class = "text-danger" });


#line default
#line hidden

#line 17 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtm   __o = Html.LabelFor(model => model.Balance, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 18 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
       __o = Html.EditorFor(model => model.Balance, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 19 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
       __o = Html.ValidationMessageFor(model => model.Balance, "", new { @class = "text-danger" });


#line default
#line hidden

#line 20 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
          
}

#   __o = Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" });


#line default
#line hidden

#line 21 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
       __o = Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } });


#line default
#line hidden

#line 22 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
       __o = Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" });


#line default
#line hidden

#line 23 "C:\Users\joand\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
line default
#line hidden

#l21e 18 "C:\Users\j24nd\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
__o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden
DefineSection("Scripts", () => {


#l22e 19 "C:\Users\j25nd\AppData\Local\Temp\3F042A385105FBFF25DE55A8C30E255BD07B\7\CuentasXPagar\Views\ProvidersModels\Edit.cshtml"
__o = Scripts.Render("~/bundles/jqueryval");


#line default
#line hidden
});

}
}
}
