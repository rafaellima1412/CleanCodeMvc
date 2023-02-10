
using Domain.Exceptions;

namespace Domain.Exceptions
{
    public class DomainExceptions : Exception
    {
        public DomainExceptions(string error) : base(error) { }
        public static void Valid(bool hasError, string name)
        {
            if (hasError)
                throw new DomainExceptions(name);
        }

    }
   

}
