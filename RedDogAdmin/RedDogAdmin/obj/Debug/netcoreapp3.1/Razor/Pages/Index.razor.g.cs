#pragma checksum "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb05f23b0b3ab2879fab014b59b89a92a950ec5"
// <auto-generated/>
#pragma warning disable 1591
namespace RedDogAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using RedDogAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Source\repos\RedDogAdmin\RedDogAdmin\_Imports.razor"
using RedDogAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
using BlazorTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
using RedDogAdmin.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
using RedDogAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
using RedDogAdmin.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>User Admin</h1>\r\n");
#nullable restore
#line 15 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
 if (tableList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<BlazorTable.Table<RedDogUser>>(4);
            __builder.AddAttribute(5, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RedDogUser>>(
#nullable restore
#line 22 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                         tableList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                              10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "SelectionType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTable.SelectionType>(
#nullable restore
#line 22 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                 selectionType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "RowClickAction", new System.Action<RedDogUser>(
#nullable restore
#line 22 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                                RowClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "SelectedItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<RedDogUser>>(
#nullable restore
#line 22 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                                                         selectedItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<RedDogUser>>(12);
                __builder2.AddAttribute(13, "Title", "Full Name");
                __builder2.AddAttribute(14, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<RedDogUser, System.Object>>>(
#nullable restore
#line 23 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                  x => x.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Width", "20%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<RedDogUser>>(19);
                __builder2.AddAttribute(20, "Title", "ID");
                __builder2.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<RedDogUser, System.Object>>>(
#nullable restore
#line 24 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                           x => x.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Width", "20%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Column<RedDogUser>>(26);
                __builder2.AddAttribute(27, "Title", "Email Confirmed");
                __builder2.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<RedDogUser, System.Object>>>(
#nullable restore
#line 25 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                        x => x.EmailConfirmed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Width", "10%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<BlazorTable.Pager>(33);
                __builder2.AddAttribute(34, "ShowPageNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ShowTotalCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddMarkupContent(38, "<div>Selected:</div> ");
            __builder.AddContent(39, 
#nullable restore
#line 28 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                           selectedItems.Any() ? selectedItems.Select(x => x.Id).Aggregate((c, n) => $"{c},{n}") : "None"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "    <br>\r\n");
#nullable restore
#line 30 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
     if (selected != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                      DeleteId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Delete Selected");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 33 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "    <br>\r\n");
            __builder.AddContent(47, 
#nullable restore
#line 35 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
     ResultMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
                  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Source\repos\RedDogAdmin\RedDogAdmin\Pages\Index.razor"
      

    private List<RedDogUser> tableList;
    private SelectionType selectionType = SelectionType.Single;
    private RedDogUser selected;
    private List<RedDogUser> selectedItems = new List<RedDogUser>();
    private string ResultMessage;

    protected override async Task OnInitializedAsync()
    {
        tableList = identUtilService.GetUserListAsync(UserManager);
    }

    public void RowClick(RedDogUser data)
    {
        selected = data;
        StateHasChanged();
    }
    public void DeleteId()
    {
        try
        {
            var Id = selected.Id;
            var result = identUtilService.DeleteRedDogUser(Id, UserManager);
            if (result == true)
            {

                StateHasChanged();
                NavigationManager.NavigateTo("/DeleteConfirmed");
            }
        }
        catch (Exception)
        {
            StateHasChanged();
            ResultMessage = "Nothing selected to delete.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentUtilService identUtilService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<IdentityUser> SignInManager { get; set; }
    }
}
#pragma warning restore 1591
