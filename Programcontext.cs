using Core;

namespace Core
{
    public partial class Programcontext
    {
        public WebApplicationBuilder WebApplicationBuilderElement;

        public WebApplication WebApplicationElement;

        public Programcontext(WebApplicationBuilder webApplicationBuilderElement, WebApplication webApplicationElement)
        {
            this.WebApplicationBuilderElement = webApplicationBuilderElement;

            this.WebApplicationElement = webApplicationElement;

            return;
        }

        ~Programcontext()
        {
            return;
        }
    }
}
