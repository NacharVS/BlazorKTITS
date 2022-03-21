using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp5.Data
{
	public class HelloWorldModal : ModalTemplate
	{
        protected override RenderFragment Header()
        {
            return (builder) =>
            {
                builder.AddContent(1, "Hello world!");
            };
        }

        protected override RenderFragment Body()
        {
            return (builder) =>
            {
                builder.AddContent(1, "This is an example builder we have. ");
                    builder.AddContent(2, "Write down what you think about this:");
                        builder.OpenElement(3, "div");
                        builder.OpenElement(4, "input");
                    builder.CloseElement();
                builder.CloseElement();

            };
        }

        protected override RenderFragment Footer()
        {
            int seq = 0;
            return (builder) =>
            {
                builder.OpenElement(++seq, "button");
                builder.AddAttribute(++seq, "type", "button");
                builder.AddAttribute(++seq, "class", "btn btn-success");
                builder.AddAttribute(++seq, "data-dismiss", "modal");
                builder.AddAttribute(++seq, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, Close));
                builder.AddContent(++seq, "Ok");
                builder.CloseElement();
            };
        }
    }
}

