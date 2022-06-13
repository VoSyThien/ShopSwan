using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace MoHinh.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MoHinhDbContext context =
           app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < MoHinhDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Hinhs.Any())
            {
                context.Hinhs.AddRange(
                new Hinh
                {
                    TenMoHinh = "Goku Black Rose",
                    MoTa = "Kích thước : 40x25x21cm - Mô hình tĩnh, giá trên đã bao gồm phí bảo hành 1-1",
               
                TheLoai = "Thể loại: ANIME",
                    Gia = 183.19m
                },
                new Hinh
                {
                    TenMoHinh = "Luffy Gear 5 Sun God Nika",
                    MoTa = "Kích thước: 49x45x40cm - Mô hình tĩnh, giá trên đã bao gồm phí bảo hành 1-1",


                TheLoai = "Thể loại: ANIME",
                    Gia = 466.30m
                },
                new Hinh
                {
                    TenMoHinh = "Kisame",
                    MoTa = "Kích thước : 36cm - Mô hình tĩnh, giá trên đã bao gồm phí bảo hành 1-1",
               
                TheLoai = "Thể loại: ANIME",
                    Gia = 270.39m
                },
                new Hinh
                {
                    TenMoHinh = "RG SINANJU MSN 06S GUNDAM",
                    MoTa = "Kích thước: 7x10x15cm - Phân loại: Lắp ráp",

                    TheLoai = "Thể loại: GUNDAM",
                    Gia = 88.56m
                },
                new Hinh
                {
                    TenMoHinh = "RG STRIKE FREEDOM ZGMF-X20A",
                    MoTa = "Kích thước: 13-16cm - Phân loại: Lắp ráp",
               
                TheLoai = "Thể loại: GUNDAM",
                    Gia = 35.80m
                }
                );
                context.SaveChanges();
            }
        }
    }
}

