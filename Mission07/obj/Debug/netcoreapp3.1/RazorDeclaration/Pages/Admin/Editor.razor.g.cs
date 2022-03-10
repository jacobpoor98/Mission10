// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBookProjectRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "/Users/jacob.poor98/Documents/GitHub/Mission10/Mission07/Pages/Admin/Editor.razor"
       

    [Parameter]
    public long Id { get; set; }

    public string ThemeColor => Id == 0 ? "primary" : "warning";

    public string TitleText => Id == 0 ? "Add" : "Edit";

    public Book b { get; set; } = new Book();

    public IBookProjectRepository repo => Service;

    protected override void OnParametersSet()
    {
        // method for an exisiting book
        if (Id != 0)
        {
            b = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void SaveBook()
    {
        // for a new project
        if (Id == 0)
        {
            repo.CreateBook(b);
        }
        else
        {
            repo.SaveBook(b);
        }

        NavManager.NavigateTo("/admin/books");
    }

    [Inject]
    public NavigationManager NavManager { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
