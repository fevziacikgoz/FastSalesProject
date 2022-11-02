using BL.Abstract;
using BL.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using DAL.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Datafark
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
           // services.AddDbContext<DatafarkContext>(options => options.UseSqlServer(@"Server=DATAFARK-2;Database=DataFarkDB;Integrated Security=true"));
            services.AddDbContext<DatafarkContext>(options => options.UseSqlServer(@"Server=DATAFARKDEV01;Database=DataFarkDB;Integrated Security=true").UseLazyLoadingProxies().EnableSensitiveDataLogging());
         
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .AddNewtonsoftJson(options =>options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddTransient<IAccountTransaction,EFAccountTransactionRepository>();
            services.AddTransient<IAccountTransactionService, AccountTransactionManager>();
            services.AddTransient<IBasketDetail,EFBasketDetailRepository>();
            services.AddTransient<IBasketDetailService,BasketDetailManager>();
            services.AddTransient<IBasket,EFBasketRepository>();
            services.AddTransient<IBasketService,BasketManager>();
            services.AddTransient<ICategory,EFCategoryRepository>();
            services.AddTransient<ICategoryService,CategoryManager>();
            services.AddTransient<ICustomer,EFCustomerRepository>();
            services.AddTransient<ICustomerService,CustomerManager>();
            services.AddTransient<IOrder,EFOrderRepository>();
            services.AddTransient<IOrderService,OrderManager>();
            services.AddTransient<IProductSku, EFProductSkuRepository>();
            services.AddTransient<IProductSkuService,ProductManager>();
            services.AddTransient<IReturnOrder,EFReturnOrderRepository>();
            services.AddTransient<IReturnOrderService,ReturnOrderManager>();
            services.AddTransient<IProduct, EFProductRepository>();
            services.AddTransient<IProductSkuPrice, EFProductSkuPriceRepository>();
            services.AddTransient<IOrderDetail, EFOrderDetailRepository>();
            services.AddTransient<IReturnOrderDetail, EFReturnOrderDetailRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
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
        }
    }
}
