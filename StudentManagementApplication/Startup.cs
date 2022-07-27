using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentManagementApplication.Startup))]
namespace StudentManagementApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
