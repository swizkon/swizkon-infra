namespace Swizkon.Infrastructure.Generators
{
    using System;
    using Interfaces;

    public class PincodeGenerator : IGenerator
    {
        public object Next()
        {
            return new Random().Next(1000, 10000);
        }
    }
}