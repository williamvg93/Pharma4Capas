using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPharma.Dtos.Get.Inventory;
using ApiPharma.Dtos.Get.Location;
using ApiPharma.Dtos.Get.Management;
using ApiPharma.Dtos.Get.Person;
using ApiPharma.Dtos.Get.Product;
using ApiPharma.Dtos.Post.Inventory;
using ApiPharma.Dtos.Post.Location;
using ApiPharma.Dtos.Post.Management;
using ApiPharma.Dtos.Post.Person;
using ApiPharma.Dtos.Post.Product;
using AutoMapper;
using Domain.Entities.Inventory;
using Domain.Entities.Location;
using Domain.Entities.Management;
using Domain.Entities.Person;
using Domain.Entities.Product;

namespace ApiPharma.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CInventory, InventoryDto>()
        .ReverseMap();
        CreateMap<CInventory, InventoryPDto>()
        .ReverseMap();

        CreateMap<InventoryManagement, InventManagDto>()
        .ReverseMap();
        CreateMap<InventoryManagement, InventManagPDto>()
        .ReverseMap();

        CreateMap<City, CityDto>()
        .ReverseMap();
        CreateMap<City, CityPDto>()
        .ReverseMap();

        CreateMap<Country, CountryDto>()
        .ReverseMap();

        CreateMap<Department, DepartmentDto>()
        .ReverseMap();
        CreateMap<Department, DepartmentPDto>()
        .ReverseMap();

        CreateMap<Invoice, InvoiceDto>()
        .ReverseMap();

        CreateMap<MovementDetail, MoveDetailDto>()
        .ReverseMap();
        CreateMap<MovementDetail, MoveDetailPDto>()
        .ReverseMap();

        CreateMap<MovementType, MoveTypeDto>()
        .ReverseMap();

        CreateMap<PaymentMethod, PayMethodDto>()
        .ReverseMap();

        CreateMap<Address, AddressDto>()
        .ReverseMap();
        CreateMap<Address, AddressPDto>()
        .ReverseMap();

        CreateMap<DocumentType, DocuTypeDto>()
        .ReverseMap();

        CreateMap<CPerson, PersonDto>()
        .ReverseMap();
        CreateMap<CPerson, PersonPDto>()
        .ReverseMap();

        CreateMap<PersonContact, PersonContDto>()
        .ReverseMap();
        CreateMap<PersonContact, PersonContPDto>()
        .ReverseMap();

        CreateMap<RolePerson, RolePersonDto>()
        .ReverseMap();

        CreateMap<TypeContact, TypeContDto>()
        .ReverseMap();

        CreateMap<TypePerson, TypePersonDto>()
        .ReverseMap();

        CreateMap<PresentationType, PresenTypeDto>()
        .ReverseMap();

        CreateMap<ProductBrand, ProdBrandDto>()
        .ReverseMap();

        CreateMap<CProduct, ProductDto>()
        .ReverseMap();
        CreateMap<CProduct, ProductPDto>()
        .ReverseMap();
    }
}