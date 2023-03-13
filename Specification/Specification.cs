namespace Specification;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T o);

    public ISpecification<T> And(ISpecification<T> specification)
    {
        return new AndSpecification<T>(this, specification);
    }

    public ISpecification<T> Or(ISpecification<T> specification)
    {
        return new OrSpecification<T>(this, specification);
    }
    public ISpecification<T> Not(ISpecification<T> specification)
    {
        throw new NotImplementedException();
    }
}
