using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.IService;
using RazorSample.Services.Service;
using ApplicationCore.Interfaces;
namespace RazorSample
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
            services.AddRazorPages();
            services.AddDbContext<HeThongQuanLyVPGTContext>(options =>
                options.UseSqlite("Data Source=HeThongQLVPGT.db", x => x.MigrationsAssembly("RazorSample"))
            );
            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(cfg =>
            {                    // Đăng ký dịch vụ Session
                                 // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(0, 60, 0);    // Thời gian tồn tại của Session
            });
            services.AddScoped<IBienBanRepository, BienBanRepository>();
            services.AddScoped<INguoiDieuKhienRepository, NguoiDieuKhienRepository>();
            services.AddScoped<IPhuongTienRepository, PhuongTienRepository>();
            services.AddScoped<IBangLaiRepository, BangLaiRepository>();
            services.AddScoped<ICapBacRepository, CapBacRepository>();
            services.AddScoped<ICanBoRepository, CanBoRepository>();
            services.AddScoped<IChucVuRepository, ChucVuRepository>();
            services.AddScoped<IChuyenDeRepository, ChuyenDeRepository>();
            services.AddScoped<IDieuLuatRepository, DieuLuatRepository>();
            services.AddScoped<IDoiRepository, DoiRepository>();
            services.AddScoped<IQuyenRepository, QuyenRepository>();
            services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
            services.AddScoped<ITuyenDuongRepository, TuyenDuongRepository>();
            services.AddScoped<IKhuVucRepository, KhuVucRepository>();
            services.AddScoped<ITheLoaiPhuongTienRepository, TheLoaiPhuongTienRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBienBanService, BienBanService>();
            services.AddScoped<IPhuongTienService, PhuongTienService>();
            services.AddScoped<INguoiDieuKhienService, NguoiDieuKhienService>();
            services.AddScoped<ICanBoService, CanBoService>();
            services.AddScoped<ICapBacService, CapBacService>();
            services.AddScoped<IChucVuService, ChucVuService>();
            services.AddScoped<IChuyenDeService, ChuyenDeService>();
            services.AddScoped<IDieuLuatService, DieuLuatService>();
            services.AddScoped<IDoiService, DoiService>();
            services.AddScoped<IQuyenService, QuyenService>();
            services.AddScoped<ITaiKhoanService, TaiKhoanService>();
            services.AddScoped<IBangLaiService, BangLaiService>();
            services.AddScoped<ITuyenDuongService, TuyenDuongService>();
            services.AddScoped<IKhuVucService, KhuVucService>();
            services.AddScoped<ITheLoaiPhuongTienService, TheLoaiPhuongTienService>();
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
                app.UseExceptionHandler("/Error");
            }
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
