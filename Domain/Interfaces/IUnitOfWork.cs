using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Inventory;
using Domain.Interfaces.Location;
using Domain.Interfaces.Management;
using Domain.Interfaces.Person;
using Domain.Interfaces.Product;
using Domain.Interfaces.UserAuthen;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IInventoryRepo Inventories { get; }
    IInventoryManagRepo InvenManags { get; }
    ICityRepo Cities { get; }
    ICountryRepo Countries { get; }
    IDepartRepo Departms { get; }
    IInvoiceRepo Invoices { get; }
    IMoveDetailRepo MoveDetails { get; }
    IMoveTypeRepo MoveTypes { get; }
    IPayMethRepo PayMethods { get; }
    IAddressRepo Addresses { get; }
    IDocuTypeRepo DocuTypes { get; }
    IPersContRepo PerContacts { get; }
    IPersonRepo People { get; }
    IRolePersRepo RolePeople { get; }
    ITypeContRepo TypeContacts { get; }
    ITypePersRepo TypePeople { get; }
    IPresenTypeRepo PresenTypes { get; }
    IProdBrandRepo ProdBrands { get; }
    IProductRepo Products { get; }
    IRefreshTokenRepo RefreshTokens { get; }
    IRolRepo Roles { get; }
    IUserRepo Users { get; }
    IUserRolRepo UserRoles { get; }
    Task<int> SaveAsync();
}
