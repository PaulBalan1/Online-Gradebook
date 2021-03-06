#pragma checksum "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0217201d7fa480d367e5ab0eeae780b071542e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
using WebApplication.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Student")]
    public partial class StudentView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <link rel=\"stylesheet\" href=\"css/gradeTable.css\">\r\n    <link rel=\"stylesheet\" href=\"css/overallTheme.css\">\r\n</head>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h2");
            __builder.AddAttribute(4, "class", "blue-border center-horiz");
            __builder.AddContent(5, "Student - ");
            __builder.OpenElement(6, "b");
            __builder.AddContent(7, 
#nullable restore
#line 12 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                                       student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, " ");
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                                                          student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(10, ", ID = ");
            __builder.AddContent(11, 
#nullable restore
#line 12 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                                                                                      student.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "blue-border");
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "table");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 19 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
     foreach (String course in courses)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "th");
            __builder.AddAttribute(23, "class", "course");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                course

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<td style=\"width: 7em\">Grades</td>\r\n                ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 26 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                     foreach (Grade grade in student.Grades)
                    {
                        string gradeOpacity = "0." + (int)(grade.GradeValue*0.9);
                        if (grade.GradeValue == 10) gradeOpacity = "1";
                        string gradeColor = "rgba(15, 180, 255, " + gradeOpacity + ")";
                        if (grade.Course.Equals(course))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                            ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "cell");
            __builder.AddAttribute(34, "style", "background-color:" + " " + (
#nullable restore
#line 33 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                                                       gradeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, 
#nullable restore
#line 33 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                                                                    grade.GradeValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 34 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 38 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                     foreach (Grade grade in student.Grades)
                    {
                        if (grade.Course.Equals(course))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                            ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "cell");
            __builder.AddContent(44, 
#nullable restore
#line 42 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                              grade.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 43 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddMarkupContent(51, "<td style=\"width: 7em\">Absences</td>\r\n                ");
            __builder.OpenElement(52, "tr");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 50 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                     foreach (Absence absence in student.Absences)
                    {
                        if (absence.Course.Equals(course))
                        {
                            if (absence.Motivated)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                                ");
            __builder.AddMarkupContent(55, "<td class=\"cell\" style=\"background-color: #8aff78\">Motivated</td>\r\n");
#nullable restore
#line 57 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.AddMarkupContent(57, "<td class=\"cell\" style=\"background-color: #ff606f\">Unmotivated</td>   \r\n");
#nullable restore
#line 61 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "tr");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 66 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                     foreach (Absence absence in student.Absences)
                    {
                        if (absence.Course.Equals(course))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                            ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", "cell");
            __builder.AddContent(65, 
#nullable restore
#line 70 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                              absence.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 71 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 76 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "blue-border center-horiz");
            __builder.AddMarkupContent(75, "\r\n");
            __builder.OpenElement(76, "h4");
            __builder.AddContent(77, "Student\'s address: ");
            __builder.OpenElement(78, "b");
            __builder.AddContent(79, 
#nullable restore
#line 83 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                           student.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.OpenElement(81, "h4");
            __builder.AddContent(82, "Student\'s phone number: ");
            __builder.OpenElement(83, "b");
            __builder.AddContent(84, 
#nullable restore
#line 84 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
                                student.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\StudentView.razor"
       
    Student student = CustomAuthenticationStateProvider.CachedStudent;
    List<string> courses = new List<string>();

    private void ExtractCourses()
    {
        foreach (Grade grade in student.Grades)
        {
            if (courses == null)
            {
                courses.Add(grade.Course);
            }
            else if (!courses.Contains(grade.Course))
            {
                courses.Add(grade.Course);
            }
        }
        foreach (Absence absence in student.Absences)
        {
            if(courses==null) courses.Add(absence.Course);
            else if (!courses.Contains(absence.Course))
            {
                courses.Add(absence.Course);
            }
        }
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ExtractCourses();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
