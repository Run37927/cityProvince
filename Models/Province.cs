using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cityProvinceMVC.Models
{
  public class Province
{
    [Key]
    public string ProvinceCode { get; set; }
    public string ProvinceName { get; set; }

    // Navigation property for related cities
    public ICollection<City> Cities { get; set; }

    public Province()
    {
        Cities = new HashSet<City>();
    }
}
}