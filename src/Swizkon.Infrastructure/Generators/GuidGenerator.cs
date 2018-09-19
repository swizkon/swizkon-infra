namespace Swizkon.Infrastructure.Generators
{
    using System;
    using Interfaces;

    public class GuidGenerator : IGenerator
    {
        public object Next()
        {
            return Guid.NewGuid();
        }
    }
}