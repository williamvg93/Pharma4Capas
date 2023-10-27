using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities.Inventory;
using Domain.Entities.Location;
using Domain.Entities.Management;
using Domain.Entities.Person;
using Domain.Entities.Product;
using Domain.Entities.UserAuthen;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

public class PharmaContext : DbContext
{
    public PharmaContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<CInventory> Inventories { get; set; }
    public DbSet<InventoryManagement> InvenManags { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departms { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<MovementDetail> MoveDetails { get; set; }
    public DbSet<MovementType> MoveTypes { get; set; }
    public DbSet<PaymentMethod> PayMethods { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<CPerson> People { get; set; }
    public DbSet<DocumentType> DocuTypes { get; set; }
    public DbSet<PersonContact> PersContacts { get; set; }
    public DbSet<RolePerson> RolePeople { get; set; }
    public DbSet<TypeContact> TypeContacts { get; set; }
    public DbSet<TypePerson> TypePeople { get; set; }
    public DbSet<CProduct> Products { get; set; }
    public DbSet<PresentationType> PresenTypes { get; set; }
    public DbSet<ProductBrand> ProdBrands { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRol> UserRoles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*modelBuilder.Entity<Cliente>()
       .HasOne(a => a.ClienteDireccion)
       .WithOne(b => b.Clientes)
       .HasForeignKey<ClienteDireccion>(b => b.IdCliente);*/

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
