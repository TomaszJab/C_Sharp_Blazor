#pragma checksum "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d3b5c1816ee7110a49620beeccfb00011b1fcb"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class StudentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><u>Studenci</u></h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    td, td {\r\n        border: 1px solid black;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
#nullable restore
#line 17 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
     if (students.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<tr><td>\r\n                There are no students\r\n            </td></tr>");
#nullable restore
#line 24 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
    }
    else
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<td>Avatar</td>\r\n            ");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                          firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "First name");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                          lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Last name");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                          birthDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Birthdate");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                          studies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Studies");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
         foreach (var s in students)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "center");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/StudentPag/" + (
#nullable restore
#line 40 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                                                  s.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(27, "img");
            __builder.AddAttribute(28, "src", 
#nullable restore
#line 40 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                                                                   s.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "width", "40");
            __builder.AddAttribute(30, "height", "40");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenComponent<WebApplication1.Shared.DeleteComponent>(32);
            __builder.AddAttribute(33, "Student", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApplication1.Models.Student>(
#nullable restore
#line 42 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                                          s

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "OnDeleteClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<WebApplication1.Models.Student>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<WebApplication1.Models.Student>(this, 
#nullable restore
#line 42 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
                                                              DeleteStudent

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Pages\StudentList.razor"
       

    private static List<Student> students;
    protected override void OnInitialized()
    {
        students = Data.students;
    }

    private async Task DeleteStudent(Student student)
    {

        bool confirm = await runtime.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirm)
        {
            students.Remove(student);
        }
    }

    private bool firstNameb = false;
    private bool lastNameb = false;
    private bool birthDateb = false;
    private bool studiesb = false;

    public void firstName()
    {
        if (firstNameb)
        {
            firstNameb = false;
            students = students.OrderByDescending(e => e.FirstName).ToList();
        }
        else
        {
            firstNameb = true;
            students = students.OrderBy(e => e.FirstName).ToList();
        }
    }

    public void lastName()
    {
        if (lastNameb)
        {
            lastNameb = false;
            students = students.OrderByDescending(e => e.LastName).ToList();
        }
        else
        {
            lastNameb = true;
            students = students.OrderBy(e => e.LastName).ToList();
        }
    }
    public void birthDate()
    {
        if (birthDateb)
        {
            birthDateb = false;
            students = students.OrderByDescending(e => e.Birthdate).ToList();
        }
        else
        {
            birthDateb = true;
            students = students.OrderBy(e => e.Birthdate).ToList();
        }
    }
    public void studies()
    {
        if (studiesb)
        {
            studiesb = false;
            students = students.OrderByDescending(e => e.Studies).ToList();
        }
        else
        {
            studiesb = true;
            students = students.OrderBy(e => e.Studies).ToList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentsData Data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigraionManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime runtime { get; set; }
    }
}
#pragma warning restore 1591
