namespace Specification.Program.Models
{
    public class Mobile
    {
        public BrandName BrandName { get; set; }
        public Type Type { get; set; }

        public Mobile(BrandName brandName, Type type)
        {
            BrandName = brandName;
            Type = type;
        }
    }
}