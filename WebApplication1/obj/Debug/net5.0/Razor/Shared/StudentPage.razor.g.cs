#pragma checksum "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502537e4c79b25f24d2198f1248e86a396b74163"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Shared
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
#line 4 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/StudentPag/{SId}")]
    public partial class StudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><u>Student\'s details</u></h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<head><style>
        .grid-container {
            display: grid;
            grid-gap: 10px;
            background-color: #2196F3;
            padding: 10px;
        }

        .grid-item {
            background-color: rgba(255, 255, 255, 0.8);
            text-align: center;
            padding: 20px;
            font-size: 30px;
        }

        .item1 {
            grid-column: 1 / span 2;
            grid-row: 1;
        }

        .item2 {
            grid-column: 3;
            grid-row: 1 / span 3;
        }

        .item5 {
            grid-column: 1 / span 3;
            grid-row: 3;
        }
    </style></head>
");
            __builder.OpenElement(2, "body");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "grid-container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "grid-item item2");
            __builder.AddMarkupContent(7, "<label>Avatar:</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                                 stud.Picture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stud.Picture = __value, stud.Picture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            <br>\r\n            ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 55 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                      stud.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "alt", "Avatar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddMarkupContent(16, "<div class=\"grid-item item3\">First name: </div>\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "grid-item item4");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                                                           stud.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stud.FirstName = __value, stud.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.AddMarkupContent(23, "<div class=\"grid-item item6\">Last name:</div>\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "grid-item item7");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                                                          stud.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stud.LastName = __value, stud.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.AddMarkupContent(30, "<div class=\"grid-item item8\">Birthdate</div>\r\n\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "grid-item item9");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                                                          stud.Birthdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stud.Birthdate = __value, stud.Birthdate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.AddMarkupContent(37, "<div class=\"grid-item item10\">Studies</div>\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "grid-item item11");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
                                                           stud.Studies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stud.Studies = __value, stud.Studies));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        <div class=\"item12\"></div>\r\n        ");
            __builder.AddMarkupContent(44, "<div class=\"grid-item item13\"><button id=\"rbutton\"><a href=\"/Students\">Return</a></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\kodSem4\Apbdzajecia12chrome\Apbdzajecia12dziwne\Apbdzajecia12dziwne\WebApplication1\Shared\StudentPage.razor"
       
    [Parameter]
    public string SId { get; set; }
    public Student stud { get; set; }


    protected override void OnInitialized()
    {
        stud = Data.students.FirstOrDefault(e => e.Id == Int32.Parse(SId));
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentsData Data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager menager { get; set; }
    }
}
#pragma warning restore 1591
