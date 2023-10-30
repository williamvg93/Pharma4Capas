using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPharma.Helpers;

public class Authorization
{
    public enum Roles
    {
        Administrador,
        Manager,
        Employee
    }

    public const Roles rol_default = Roles.Employee;

}
