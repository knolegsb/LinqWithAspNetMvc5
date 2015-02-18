using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinqWithAsp.NetMvc5.Startup))]
namespace LinqWithAsp.NetMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
