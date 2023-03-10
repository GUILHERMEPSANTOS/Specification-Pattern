namespace Specification;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract bool IsSatisfiedBy(T o);
    public ISpecification<T> And(ISpecification<T> specification)
    {
        throw new NotImplementedException();
    }

    public ISpecification<T> Or(ISpecification<T> specification)
    {
        throw new NotImplementedException();
    }
    public ISpecification<T> Not(ISpecification<T> specification)
    {
        throw new NotImplementedException();
    }
}
