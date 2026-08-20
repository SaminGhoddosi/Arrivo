using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class PackageSpecification : Specification<Package>
    {
        public PackageSpecification(int id)
        {
            Query.Include(x => x.Carrier);
            Query.Where(x => x.Id == id);
        }
    }
}
