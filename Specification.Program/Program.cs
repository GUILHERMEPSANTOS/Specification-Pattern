using Specification;
using Specification.Program.Models;
using Specification.Program.Specifications;


List<Mobile> mobiles = new List<Mobile> {
            new Mobile(BrandName.Samsung, Specification.Program.Models.Type.Smart),
            new Mobile(BrandName.Apple, Specification.Program.Models.Type.Smart),
            new Mobile(BrandName.Htc, Specification.Program.Models.Type.Basic),
            new Mobile(BrandName.Samsung, Specification.Program.Models.Type.Basic)
    };

ISpecification<Mobile> specificationBrandSpec = new SamsungBrandSpec<Mobile>();

var samsungPhones = mobiles.FindAll(specificationBrandSpec.And(new TypeSmartSpec<Mobile>()).IsSatisfiedBy);


foreach (var item in samsungPhones)
{
    System.Console.WriteLine(item.BrandName.ToString());
}