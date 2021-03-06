#pragma checksum "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchJourney1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71acfbc8aee0c3f798bcee823a8fdd9d68142e69"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchjourney1")]
    public class FetchJourney1 : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<style>\n    .header {\n        text-align: center;\n        background: #1abc9c;\n        color: white;\n        font-size: 14px;\n    }\n</style>\n\n");
            builder.AddMarkupContent(1, "<h1>Call Journey Through Telecom Touchpoints</h1>\n\n");
            builder.AddMarkupContent(2, "<p>This component demonstrates a vertical slice of contact data flowing through the various Telecom Systemsr.</p>\n");
            builder.OpenElement(3, "span");
            builder.AddAttribute(4, "style", "color:red");
            builder.AddContent(5, notificationMessage);
            builder.CloseElement();
            builder.AddContent(6, "\n\n");
#line 18 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchJourney1.cshtml"
 if (contacts == null)
{

#line default
#line hidden
            builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\n");
#line 21 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchJourney1.cshtml"
}
else
{

#line default
#line hidden
            builder.AddMarkupContent(8, @"<div class=""row page-header header"">
    <div class=""col-lg-12"">
            <div class=""col-lg-2 text-left"">
                Contact Attributes
            </div>
            <div class=""row"">
                <div class=""col-lg-2 text-left"">
                    Web/Mobile
                </div>
                <div class=""col-lg-2 text-left"">
                    IVR/TAD
                </div>
                <div class=""col-lg-4 text-left"">
                    CONNECT CSR1
                </div>
                <div class=""col-lg-4 text-left"">
                    CONNECT CSR2
                </div>
                <div class=""col-lg-1 text-left"">
                    ASI External
                </div>
            </div>
    </div>
</div>
");
#line 48 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchJourney1.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 51 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchJourney1.cshtml"
            
    string notificationMessage;
    IList<ContactContext> contacts;

    protected override async Task OnInitAsync()
    {
        try
        {
            contacts = await Http.GetJsonAsync<IList<ContactContext>>("sample-data/journey.json");
        }
        catch (Exception exception)
        {
            notificationMessage = $"Exception Message: {exception.Message}";
        }
    }

    class ContactContext
    {
        public string ContactAttribute { get; set; }
        public string WebMobile { get; set; }
        public string IvrTad { get; set; }
        public string ConnectCsr1 { get; set; }
        public string ConnectCsr2 { get; set; }
        public string AsiExternal { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
