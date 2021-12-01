using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.Ostrogothia
{
    [ServiceDefinitionMarker]
    public interface IOrganizationProvider : IServiceDefinition
    {
        Task<IOrganization> GetOrganization();
    }
}
