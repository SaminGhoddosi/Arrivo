using Application.AppModel;
using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class ApartmentSpecification : Specification<Apartment>
    {
        public ApartmentSpecification(int id)
        {
            Query.Include(x => x.Building).ThenInclude(x => x.Address);
            Query.Where(x => x.Id == id);
        }
    }
}
