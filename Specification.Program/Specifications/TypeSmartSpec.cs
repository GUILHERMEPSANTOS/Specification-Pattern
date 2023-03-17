
using System.Linq.Expressions;
using Specification.Program.Models;

namespace Specification.Program.Specifications
{
    public class TypeSmartSpec : Specification<Mobile>
    {
        public override Expression<Func<Mobile, bool>> ToExpression()
        {
            return mobile => mobile.Type == Models.Type.Smart;
        }
    }
}