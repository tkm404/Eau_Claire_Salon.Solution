using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientsId { get; set; }
    public string ClientName { get; set; }
    public int StylistsId { get; set; }
    public Stylist Stylist { get; set; }
  }
}