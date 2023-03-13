
using Specification.Program.Models;

namespace Specification.Program.Specifications
{
    public class TypeSmartSpec<T> : Specification<T> where T : Mobile
    {
        public override bool IsSatisfiedBy(T mobile)
        {
            return mobile.Type == Models.Type.Smart;
        }
    }
}