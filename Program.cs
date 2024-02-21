using CSharpFundamental;

HospitalRepository repo = new HospitalRepository();
 while (true)
{
HospitalBirth birth = new HospitalBirth();
Console.WriteLine("First Name: ");
birth.FirstName = Console.ReadLine();
Console.WriteLine("Middle Name: ");
birth.LastName = Console.ReadLine();
Console.WriteLine("Middle Name: ");
birth.LastName = Console.ReadLine();
Console.WriteLine("Sex: ");
birth.Sex = Console.ReadLine();
Console.WriteLine("DateOfBirth: ");
birth.DateOfBirth =DateTime.Parse(Console.ReadLine());
 Console.WriteLine("Hospital: ");
 birth.Hostpital = Console.ReadLine();
 repo.AddBirth(birth);
foreach (var item in repo.Births)
{
    Console.WriteLine(repo.DisplayInfo(item));
}
}

