using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public string Speciality { get; set; }
    public int StylistsId { get; set; }
    public List<Client> Clients { get; set; }
  }
}