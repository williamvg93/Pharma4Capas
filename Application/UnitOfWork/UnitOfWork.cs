using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository.Inventory;
using Application.Repository.Location;
using Application.Repository.Management;
using Application.Repository.Person;
using Application.Repository.Product;
using Application.Repository.UserAuthen;
using Domain.Interfaces;
using Domain.Interfaces.Inventory;
using Domain.Interfaces.Location;
using Domain.Interfaces.Management;
using Domain.Interfaces.Person;
using Domain.Interfaces.Product;
using Domain.Interfaces.UserAuthen;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly PharmaContext _context;
    private IInventoryManagRepo _invenManags;
    private IInventoryRepo _inventories;
    private ICityRepo _cities;
    private ICountryRepo _countries;
    private IDepartRepo _departms;
    private IInvoiceRepo _invoices;
    private IMoveDetailRepo _moveDetails;
    private IMoveTypeRepo _moveTypes;
    private IPayMethRepo _payMethods;
    private IAddressRepo _addresses;
    private IDocuTypeRepo _docuTypes;
    private IPersContRepo _persContacts;
    private IPersonRepo _people;
    private IRolePersRepo _rolePeople;
    private ITypeContRepo _typeContacts;
    private ITypePersRepo _typePeople;
    private IPresenTypeRepo _presenTypes;
    private IProdBrandRepo _prodBrands;
    private IProductRepo _products;
    private IRefreshTokenRepo _refreshTokens;
    private IRolRepo _rol;
    private IUserRepo _users;
    private IUserRolRepo _userRoles;


    public UnitOfWork(PharmaContext context)
    {
        _context = context;
    }

    public IInventoryManagRepo InvenManags
    {
        get
        {
            if (_invenManags == null)
            {
                _invenManags = new InvenManaRepo(_context);
            }
            return _invenManags;
        }
    }
    public IInventoryRepo Inventories
    {
        get
        {
            if (_inventories == null)
            {
                _inventories = new InventoryRepo(_context);
            }
            return _inventories;
        }
    }
    public ICityRepo Cities
    {
        get
        {
            if (_cities == null)
            {
                _cities = new CityRepo(_context);
            }
            return _cities;
        }
    }
    public ICountryRepo Countries
    {
        get
        {
            if (_countries == null)
            {
                _countries = new CountryRepo(_context);
            }
            return _countries;
        }
    }
    public IDepartRepo Departms
    {
        get
        {
            if (_departms == null)
            {
                _departms = new DepartRepo(_context);
            }
            return _departms;
        }
    }
    public IInvoiceRepo Invoices
    {
        get
        {
            if (_invoices == null)
            {
                _invoices = new InvoiceRepo(_context);
            }
            return _invoices;
        }
    }
    public IMoveDetailRepo MoveDetails
    {
        get
        {
            if (_moveDetails == null)
            {
                _moveDetails = new MoveDetailRepo(_context);
            }
            return _moveDetails;
        }
    }
    public IMoveTypeRepo MoveTypes
    {
        get
        {
            if (_moveTypes == null)
            {
                _moveTypes = new MoveTypeRepo(_context);
            }
            return _moveTypes;
        }
    }
    public IPayMethRepo PayMethods
    {
        get
        {
            if (_payMethods == null)
            {
                _payMethods = new PayMethRepo(_context);
            }
            return _payMethods;
        }
    }
    public IAddressRepo Addresses
    {
        get
        {
            if (_addresses == null)
            {
                _addresses = new AddressRepo(_context);
            }
            return _addresses;
        }
    }
    public IDocuTypeRepo DocuTypes
    {
        get
        {
            if (_docuTypes == null)
            {
                _docuTypes = new DocuTypeRepo(_context);
            }
            return _docuTypes;
        }
    }
    public IPersContRepo PerContacts
    {
        get
        {
            if (_persContacts == null)
            {
                _persContacts = new PersContRepo(_context);
            }
            return _persContacts;
        }
    }
    public IPersonRepo People
    {
        get
        {
            if (_people == null)
            {
                _people = new PersonRepo(_context);
            }
            return _people;
        }
    }
    public IRolePersRepo RolePeople
    {
        get
        {
            if (_rolePeople == null)
            {
                _rolePeople = new RolePersRepo(_context);
            }
            return _rolePeople;
        }
    }
    public ITypeContRepo TypeContacts
    {
        get
        {
            if (_typeContacts == null)
            {
                _typeContacts = new TypeContRepo(_context);
            }
            return _typeContacts;
        }
    }
    public ITypePersRepo TypePeople
    {
        get
        {
            if (_typePeople == null)
            {
                _typePeople = new TypePersRepo(_context);
            }
            return _typePeople;
        }
    }
    public IPresenTypeRepo PresenTypes
    {
        get
        {
            if (_presenTypes == null)
            {
                _presenTypes = new PresenTypeRepo(_context);
            }
            return _presenTypes;
        }
    }
    public IProdBrandRepo ProdBrands
    {
        get
        {
            if (_prodBrands == null)
            {
                _prodBrands = new ProdBrandRepo(_context);
            }
            return _prodBrands;
        }
    }
    public IProductRepo Products
    {
        get
        {
            if (_products == null)
            {
                _products = new ProductRepo(_context);
            }
            return _products;
        }
    }
    public IRefreshTokenRepo RefreshTokens
    {
        get
        {
            if (_refreshTokens == null)
            {
                _refreshTokens = new RefreshTokenRepo(_context);
            }
            return _refreshTokens;
        }
    }
    public IRolRepo Roles
    {
        get
        {
            if (_rol == null)
            {
                _rol = new RolRepo(_context);
            }
            return _rol;
        }
    }
    public IUserRepo Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepo(_context);
            }
            return _users;
        }
    }

    public IUserRolRepo UserRoles
    {
        get
        {
            if (_userRoles == null)
            {
                _userRoles = new UserRolRepo(_context);
            }
            return _userRoles;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

}