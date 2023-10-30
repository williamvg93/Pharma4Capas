using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPharma.Dtos.Get.Person;

public class PersonDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime RegistreDate { get; set; }
}
