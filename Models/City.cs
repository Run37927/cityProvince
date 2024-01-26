using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cityProvinceMVC.Models
{
 public class City
{
    [Key]
    public int CityId { get; set; }
    public string CityName { get; set; }
    public int Population { get; set; }

    // Foreign key for Province
    public string ProvinceCode { get; set; }

    [ForeignKey("ProvinceCode")]
    public Province Province { get; set; }
}
}