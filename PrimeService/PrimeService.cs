using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            if (candidate == 2)
            {
                return true;
            }
            if (candidate == 3)
            {
                return true;
            }
            if (candidate == 4)
            {
                return false;
            }
            if (candidate == 5)
            {
                return true;
            }
            throw new NotImplementedException("Please do it first");
        }
    }
}
