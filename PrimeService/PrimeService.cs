﻿using System;

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
            if (candidate == 2){
                return true;
            }
            throw new NotImplementedException("Please do it first");
        }
    }
}
