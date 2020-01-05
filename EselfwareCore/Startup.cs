using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EselfwareCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }


        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             
            app.UseStaticFiles();
             

            app.UseMvc(routes =>
            {
                routes.MapRoute("anasayfa", "", new { controller = "Home", action = "Home" }); 
                routes.MapRoute("anasayfaReplica", "anasayfa", new { controller = "Home", action = "Index" }); 

                routes.MapRoute("hakkimizda", "hakkimizda", new { controller = "About", action = "About" });
                routes.MapRoute("ürün", "urunler", new { controller = "Products", action = "Products" });
                routes.MapRoute("erp", "eselfware-erp", new { controller = "EselfERP", action = "EselfERP" });
                routes.MapRoute("iot", "eselfware-IoT", new { controller = "EselfIOT", action = "EselfIOT" });
                routes.MapRoute("kütüphane", "kutuphane", new { controller = "Library", action = "Library" });
                routes.MapRoute("fiyatlandýrma", "fiyatlandirma", new { controller = "PricingForm", action = "PricingForm" });
                routes.MapRoute("customerReg", "customerReg", new { controller = "PricingForm", action = "customerRequest" });
                routes.MapRoute("dealers", "bayi-fiyatlandirma", new { controller = "DealersForm", action = "DealersForm" });
                routes.MapRoute("dealersReg", "bayi", new { controller = "DealersForm", action = "DealersCode" });
                routes.MapRoute("referans", "referans", new { controller = "Reference", action = "Reference" });
                routes.MapRoute("iletisim", "iletisim", new { controller = "Contact", action = "Contact" });
                routes.MapRoute("iletisimReg", "iletisimReg", new { controller = "Contact", action = "sendContact" });

                routes.MapRoute("SiteMap", "site-map", new { controller = "Sitemap", action = "Sitemap" });
                 
            });




        }
    }
}
