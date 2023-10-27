using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Product;
using Domain.Interfaces.Product;
using Persistence.Data;

namespace Application.Repository.Product;

public class ProdBrandRepo : GenericRepository<ProductBrand>, IProdBrandRepo
{
    private readonly PharmaContext _context;

    public ProdBrandRepo(PharmaContext context) : base(context)
    {
        _context = context;
    }
}