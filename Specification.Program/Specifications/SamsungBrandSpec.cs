using Specification.Program.Models;

namespace Specification.Program.Specifications; 
public class SamsungBrandSpec<T> : Specification<T> where T : Mobile
{
    public override bool IsSatisfiedBy(T mobile)
    {
        return mobile.BrandName == BrandName.Samsung;
    }
}
