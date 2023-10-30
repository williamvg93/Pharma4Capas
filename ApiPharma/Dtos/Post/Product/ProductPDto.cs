using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPharma.Dtos.Post.Product;

public class ProductPDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int IdProdBrandFk { get; set; }
}
