
using SingleTonPatternApp;

//CaseStudy1();

CaseStudy2();

static void CaseStudy2()
{

    Task.Run(() => {

        ServiceRegsitry.GetInstance().DoProcessing();
    });
    Task.Run(() => {

        ServiceRegsitry.GetInstance().DoProcessing();
    });
    Task.Run(() => {

        ServiceRegsitry.GetInstance().DoProcessing();
    });

    Console.WriteLine("end of CaseStudy2");

    Console.ReadLine();
}
    static void CaseStudy1()
{
    var s1 = ServiceRegsitry.GetInstance();
    var s2 = ServiceRegsitry.GetInstance();

    s1.DoProcessing();
    s2.DoProcessing();

    Console.WriteLine(s1.GetHashCode());
    Console.WriteLine(s2.GetHashCode());
}