using Specification;
using Specification.Program.Models;
using Specification.Program.Specifications;


List<Mobile> mobiles = new List<Mobile> {
            new Mobile(BrandName.Samsung, Specification.Program.Models.Type.Smart),
            new Mobile(BrandName.Apple, Specification.Program.Models.Type.Smart),
            new Mobile(BrandName.Htc, Specification.Program.Models.Type.Basic),
            new Mobile(BrandName.Samsung, Specification.Program.Models.Type.Basic)
    };

Specification<Mobile> specificationBrandSpec = new SamsungBrandSpec();


// True  -- É Samsung e Smart
System.Console.WriteLine(specificationBrandSpec.And(new TypeSmartSpec()).IsSatisfiedBy(mobiles[0]));
// False -- É Samsung e Smart
System.Console.WriteLine(specificationBrandSpec.And(new TypeSmartSpec().Not()).IsSatisfiedBy(mobiles[0]));
// True  -- É Samsung e Basic
System.Console.WriteLine(specificationBrandSpec.Or(new TypeSmartSpec().Not()).IsSatisfiedBy(mobiles[3]));
