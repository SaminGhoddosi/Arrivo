using Ardalis.Specification;
using Domain.Entities;

namespace Infra.Specification
{
    public class DoormanSpecification : Specification<Doorman>
    {
        public DoormanSpecification(int id)
        {
            Query.Include(x => x.Building);
            Query.Where(x => x.Id == id);
        }
    }
}
