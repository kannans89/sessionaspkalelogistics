using MVCWithEFApp.Domain;

namespace MVCWithEFApp.Repository
{
    public interface IOrganizationRepostiory
    {
        void AddOrganization(Organization organisation);
        List<Organization> GetOrganizations();

        Organization GetOrganizationById(int id);
        void UpdateOrganization(Organization newOrg);
        void Remove(int organizaitonId);
    }
}
