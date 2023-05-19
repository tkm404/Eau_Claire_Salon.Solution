using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}