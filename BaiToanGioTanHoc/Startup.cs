using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaiToanGioTanHoc.Startup))]
namespace BaiToanGioTanHoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
