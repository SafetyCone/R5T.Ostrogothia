using System;
using System.Threading.Tasks;


namespace R5T.Ostrogothia
{
    public interface IOrganizationProvider
    {
        Task<IOrganization> GetOrganization();
    }
}
