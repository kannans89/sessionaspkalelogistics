using MVCWithEFApp.Data;
using MVCWithEFApp.Domain;

namespace MVCWithEFApp.Repository
{
    public class OrganizationEFRepository : IOrganizationRepostiory
    {
        private readonly OrganizationDbContext _db;
        public OrganizationEFRepository(OrganizationDbContext db) { 
          _db= db;
        }
        public void AddOrganization(Organization organisation)
        {
            _db.Organizations.Add(organisation);
            _db.SaveChanges();
        }

        public Organization GetOrganizationById(int id)
        {
            return _db.Organizations.Where(o => o.Id == id).FirstOrDefault();
        }

        public List<Organization> GetOrganizations()
        {
            return _db.Organizations.ToList();
        }

        public void Remove(int organizaitonId)
        {
            //find object to remove
            //remove
            //savechanges
            var orgnization = GetOrganizationById(organizaitonId);
            _db.Organizations.Remove(orgnization);
            _db.SaveChanges();
        }

        public void UpdateOrganization(Organization newOrg)
        {

            _db.Organizations.Update(newOrg);
            _db.SaveChanges();
        }
    }
}
