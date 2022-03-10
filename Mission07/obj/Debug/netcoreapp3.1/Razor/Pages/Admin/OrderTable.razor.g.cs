#pragma checksum "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ec9fcf1678cac60279a41db5c27be78323f387"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission07.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 3 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/_Imports.razor"
using Mission07.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
#nullable restore
#line 7 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(10, TableTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.OpenElement(14, "tbdoy");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 13 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
             foreach (Purchase p in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 18 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(20, p.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 19 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(23, p.Zip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.AddMarkupContent(25, "<th>Book</th>\n                    ");
            __builder.AddMarkupContent(26, "<th>Quantity</th>\n\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
                                                                          x => OrderSelected.InvokeAsync(p.PurchaseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\n                            ");
#nullable restore
#line 25 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(33, ButtonLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 30 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
                 foreach (BasketLineItem b in p.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\n                        <td colspan=\"2\"></td>\n                        ");
            __builder.OpenElement(41, "td");
#nullable restore
#line 34 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(42, b.Book.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                        ");
            __builder.OpenElement(44, "td");
#nullable restore
#line 35 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
__builder.AddContent(45, b.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#nullable restore
#line 37 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
             
        }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
                          
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "            ");
            __builder.AddMarkupContent(49, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Orders</td>\n            </tr>\n");
#nullable restore
#line 46 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/OrderTable.razor"
       

    //initilaize some variables
    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Purchase> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
