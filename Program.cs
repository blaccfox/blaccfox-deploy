using Core;

namespace Core
{
    internal static class Program
    {
        internal static Programcontext? ProgramcontextElement;

        static Program()
        {
            return;
        }

        internal static void Main(params String[] Argument_ARRAY)
        {
            WebApplicationBuilder webApplicationBuilder;

            webApplicationBuilder = WebApplication.CreateBuilder(Argument_ARRAY);

            WebApplication webApplication;
            
            webApplication = webApplicationBuilder.Build();

            Programcontext programcontext;

            programcontext = new Programcontext(webApplicationBuilder, webApplication);

            ProgramcontextElement = programcontext;

            ProgramcontextElement.WebApplicationElement.MapGet("/", () => "Hello World!");

            ProgramcontextElement.WebApplicationElement.Run();

            return;
        }
    }
}