using System.Linq.Expressions;

namespace Specification
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _specification;

        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            var expression = _specification.ToExpression();
            var notExpression = Expression.Not(expression.Body);

            return (Expression<Func<T, bool>>)Expression.Lambda(notExpression, expression.Parameters.Single());
        }
    }
}