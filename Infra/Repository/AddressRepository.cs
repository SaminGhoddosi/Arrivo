using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class AddressRepository(AppDbContext appContext) : RepositoryBase<Address>(appContext), IAddressRepository
    {
    }
}
