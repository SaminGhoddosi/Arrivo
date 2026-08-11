using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PackageDomainService(IPackageRepository repository) : DomainService<Package>(repository), IPackageService
    {
    }
}
