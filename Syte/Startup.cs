using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syte.Interfaces;
//using Syte.Mocks;
using Syte.Repository;

namespace Syte
{
    public class Startup
    {

        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddTransient<IAllBooks, BookRepository>();
            services.AddTransient<ICategories, CategoryRepository>();
            services.AddTransient<IAuthors, AuthorsRepository>();
            services.AddTransient<IPublisher, PublisherRepository>();
            //services.AddTransient<ICompilations, Mock_Compilations>();
            //services.AddTransient<IMyBooks, Mock_MyBooks>();
            services.AddTransient<IReviews, ReviewsRepository>();
            services.AddTransient<ITags, TagsRepository>();
            //services.AddTransient<ITags, Mock_Tags>();
            //services.AddTransient<IUser, Mock_User>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContext content = scope.ServiceProvider.GetRequiredService<AppDBContext>();
                DBObjects.Initial(content);
            }
        }
    }
}
