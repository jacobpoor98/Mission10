#pragma checksum "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06a0c6753e6a4ef861b3517f66b0bac9d43dc7e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(3, "\n\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\n            ");
            __builder.AddMarkupContent(8, "<th>Book ID:</th>\n            ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 12 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(10, b.BookId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\n            ");
            __builder.AddMarkupContent(15, "<th>Title:</th>\n            ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 17 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(17, b.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\n            ");
            __builder.AddMarkupContent(22, "<th>Author:</th>\n            ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 22 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(24, b.Author);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n        ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\n            ");
            __builder.AddMarkupContent(29, "<th>Publisher:</th>\n            ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 27 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(31, b.Publisher);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n        ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\n            ");
            __builder.AddMarkupContent(36, "<th>Isbn:</th>\n            ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 32 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(38, b.Isbn);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\n            ");
            __builder.AddMarkupContent(43, "<th>Classification:</th>\n            ");
            __builder.OpenElement(44, "td");
#nullable restore
#line 37 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(45, b.Classification);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n\n        ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\n            ");
            __builder.AddMarkupContent(50, "<th>Category:</th>\n            ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 42 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(52, b.Category);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n\n        ");
            __builder.OpenElement(55, "tr");
            __builder.AddMarkupContent(56, "\n            ");
            __builder.AddMarkupContent(57, "<th>Page Count:</th>\n            ");
            __builder.OpenElement(58, "td");
#nullable restore
#line 47 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(59, b.PageCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n        ");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "\n            ");
            __builder.AddMarkupContent(64, "<td>Price:</td>\n            ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 52 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
__builder.AddContent(66, b.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
            __builder.AddAttribute(72, "class", "btn btn-warning");
            __builder.AddAttribute(73, "href", 
#nullable restore
#line 59 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(75, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
            __builder.AddAttribute(78, "class", "btn btn-secondary");
            __builder.AddAttribute(79, "href", "/admin/books");
            __builder.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(81, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Details.razor"
       

    // bring in the IBookProjectRepository
    [Inject]
    public IBookProjectRepository repo { get; set; }

    // initialize some variables needed above
    [Parameter]
    public long Id { get; set; }

    public Book b { get; set; }

    protected override void OnParametersSet()
    {
        b = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }

    // route to edit with the Book ID
    public string EditUrl => $"/admin/books/edit/{b.BookId}";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591