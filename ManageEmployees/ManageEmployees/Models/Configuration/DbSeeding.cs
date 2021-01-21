using ManageEmployees.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployees.Models.Configuration
{
    public static class DbSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(
                new Employees()
                {
                    ID = 1,
                    Name = "Đổ Thị Chan Hòa",
                    Department = "Phòng Kế toán",
                    Phone = "012369856",
                    Image= "Do-thi-chan-hoa.jpg"
                },
                new Employees()
                {
                    ID = 2,
                    Name = "Phạm Tuân",
                    Department = "Phòng bảo vệ",
                    Phone = "012369856",
                    Image= "Tuan.jpg",
                },
                new Employees()
                {
                    ID = 3,
                    Name = "Vũ Quang Huy",
                    Department = "Phòng bảo vệ",
                    Phone = "012369856",
                    Image= "Vu-quang-huy.jpg",

                },
                new Employees()
                {
                    ID = 4,
                    Name = "Nguyễn Đình Hiếu",
                    Department = "Phòng công nghệ thông tin",
                    Phone = "012369856",
                    Image = "Hieu-icetea.jpg"
                },
                new Employees()
                {
                    ID = 5,
                    Name = "Trương Thanh Tú",
                    Department = "Phòng quản lý",
                    Phone = "012369856",
                    Image= "truong-thanh-tu.jpg",
                }

                );
        }
    }
}
