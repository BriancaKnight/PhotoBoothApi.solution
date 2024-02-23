using System.ComponentModel.DataAnnotations;

namespace PhotoBoothApi.Models
{
  public class Booth
  {
    public int BoothId { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string Neighborhood { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
  }
}