using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPharma.Dtos.Post.Location;
public class CityPDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IdDepartFk { get; set; }
}
