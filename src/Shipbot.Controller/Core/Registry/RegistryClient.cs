using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shipbot.Controller.Core.Registry
{
    public interface IRegistryClient
    {
        Task<bool> IsKnownRepository(string repository);
        Task<List<(string tag, DateTime createdAt)>> GetRepositoryTags(string repository);
    }
}