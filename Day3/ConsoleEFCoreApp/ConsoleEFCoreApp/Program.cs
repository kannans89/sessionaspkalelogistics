


using ConsoleEFCoreApp.Data;
using ConsoleEFCoreApp.Domain;
using Microsoft.EntityFrameworkCore;


//CaseStudy1();

//CaseStudy2();

//CaseStudy3();

//CaseStudy4();

CaseStudy5();
void CaseStudy5()
{

    var db = new OrganizationDbContext();
    var organization = db.Organizations
                         .Where(o => o.Id == 1)
                         .Include(o => o.Departments).ToList();
    //.ThenInclude(d => d.Employees);

    foreach (var o in organization)
    {
        Console.WriteLine(o.Name);
        foreach (var d in o.Departments)
        {
            Console.WriteLine(d.Name);
        }

    }

    Console.WriteLine("end of casestudy5");

}
void CaseStudy4()
{
    var db = new OrganizationDbContext();
    var org1 = db.Organizations
                .Where(o => o.Id == 1).FirstOrDefault();

    foreach (var dept in org1.Departments)
    {
        Console.WriteLine(dept.Name);
    }

    Console.WriteLine("end of caseStudy4");
}

void CaseStudy3()
{
    var db = new OrganizationDbContext();
    var org1 = db.Organizations
                .Where(o => o.Id == 1).FirstOrDefault();

    org1.Departments = new List<Department>();
    org1.Departments.Add(new Department { Name = "Development" });
    org1.Departments.Add(new Department { Name = "Training" });


    db.SaveChanges();

    Console.WriteLine("end of CaseStudy3");

}

static void CaseStudy2()
{


    //List<Organization> list=new List<Organization>();
    //IEnumerable<Organization> query2 = list.Where(x => x.Id == 1);

    var db = new OrganizationDbContext();
    var query1 = db.Organizations
                   .Where(x => x.Name.Contains("K"))
                   .ToList();

    ;//sql grammar

    //var query1 = db.Organizations
    //               .Where(o => o.Name.Split()[0].Contains("K"))
    ;//sql grammar
    var organization = query1.FirstOrDefault();
    Console.WriteLine(organization.Name);
    Console.WriteLine("end of CaseStudy2");

}
static void CaseStudy1()
{

    var org1 = new Organization
    {
        Name = "KaleLogistics"
    };


    var org2 = new Organization
    {
        Name = "Koenig Solutions"
    };

    var db = new OrganizationDbContext();

    db.Organizations.Add(org1);
    db.Organizations.Add(org2);
    db.SaveChanges();

    Console.WriteLine("end of case1");

}