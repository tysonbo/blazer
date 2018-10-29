#pragma checksum "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\ContactContextCarousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f026d45df73f28a96bd52e4bbabee9c2cae43924"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDash.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorDash;
    using BlazorDash.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/contactcontextcarousel")]
    public class ContactContextCarousel : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Call Journey - Replay</h1>\n\n<link href=\"//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\n\n");
            builder.AddMarkupContent(1, @"<style>
    .blog .carousel-indicators {
        left: 0;
        top: auto;
        bottom: -40px;
    }

        /* The colour of the indicators */
        .blog .carousel-indicators li {
            background: #a3a3a3;
            border-radius: 50%;
            width: 8px;
            height: 8px;
        }

        .blog .carousel-indicators .active {
            background: #707070;
        }
</style>

");
            builder.AddMarkupContent(2, "<div class=\"container\">\n    <div class=\"row blog\">\n        <div class=\"col-md-12\">\n            <div id=\"blogCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\n                <ol class=\"carousel-indicators\">\n                    <li data-target=\"#blogCarousel\" data-slide-to=\"0\" class=\"active\"></li>\n                    <li data-target=\"#blogCarousel\" data-slide-to=\"1\"></li>\n                </ol>\n                \n                <div class=\"carousel-inner\">\n                    <div class=\"carousel-item active\">\n                        <div class=\"row\">\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <span>Mike and Denis</span>\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a>\n                                    Mike and Denis\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                        </div>\n                        \n                    </div>\n                    \n                    <div class=\"carousel-item\">\n                        <div class=\"row\">\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                            <div class=\"col-md-3\">\n                                <a href=\"#\">\n                                    <img src=\"http://placehold.it/250x250\" alt=\"Image\" style=\"max-width:100%;\">\n                                </a>\n                            </div>\n                        </div>\n                        \n                    </div>\n                    \n                </div>\n                \n            </div>\n            \n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
