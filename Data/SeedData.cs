using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cityProvinceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace cityProvinceMVC.Data
{
 public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<Province> GetProvinces()
    {
        List<Province> provinces = new List<Province>()
        {
            new Province() {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province() {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province() {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            },
        };

        return provinces;
    }

    public static List<City> GetCities()
    {
        List<City> cities = new List<City>()
        {
            new City() {
                CityId = 1,
                CityName = "Vancouver",
                Population = 631486,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 2,
                CityName = "Victoria",
                Population = 85792,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 3,
                CityName = "Kelowna",
                Population = 127380,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 4,
                CityName = "Edmonton",
                Population = 932546,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 5,
                CityName = "Calgary",
                Population = 1239220,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 6,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 7,
                CityName = "Toronto",
                Population = 2731571,
                ProvinceCode = "ON"
            },
            new City() {
                CityId = 8,
                CityName = "Ottawa",
                Population = 934243,
                ProvinceCode = "ON"
            },
            new City() {
                CityId = 9,
                CityName = "Hamilton",
                Population = 536917,
                ProvinceCode = "ON"
            },
        };

        return cities;
    }
}
}