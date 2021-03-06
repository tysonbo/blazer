#pragma checksum "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3bd567b8ae791167d30a248416df6bcd9d6499"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\n");
            builder.OpenElement(2, "span");
            builder.AddAttribute(3, "style", "color:red");
            builder.AddContent(4, notificationMessage);
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
#line 9 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(6, "    ");
            builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\n");
#line 12 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(8, "    ");
            builder.OpenElement(9, "table");
            builder.AddAttribute(10, "class", "table");
            builder.AddContent(11, "\n        ");
            builder.AddMarkupContent(12, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(13, "tbody");
            builder.AddContent(14, "\n");
#line 25 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
             foreach (var forecast in forecasts)
                {

#line default
#line hidden
            builder.AddContent(15, "                    ");
            builder.OpenElement(16, "tr");
            builder.AddContent(17, "\n                        ");
            builder.OpenElement(18, "td");
            builder.AddContent(19, forecast.Date.ToShortDateString());
            builder.CloseElement();
            builder.AddContent(20, "\n                        ");
            builder.OpenElement(21, "td");
            builder.AddContent(22, forecast.TemperatureC);
            builder.CloseElement();
            builder.AddContent(23, "\n                        ");
            builder.OpenElement(24, "td");
            builder.AddContent(25, forecast.TemperatureF);
            builder.CloseElement();
            builder.AddContent(26, "\n                        ");
            builder.OpenElement(27, "td");
            builder.AddContent(28, forecast.Summary);
            builder.CloseElement();
            builder.AddContent(29, "\n                    ");
            builder.CloseElement();
            builder.AddContent(30, "\n");
#line 33 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
                }

#line default
#line hidden
            builder.AddContent(31, "        ");
            builder.CloseElement();
            builder.AddContent(32, "\n    ");
            builder.CloseElement();
            builder.AddContent(33, "\n");
#line 36 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "C:\Users\doconnel\Documents\Visual Studio 2017\Projects\BlazorDash\BlazorDash\Pages\FetchData.cshtml"
            
    string notificationMessage;
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
