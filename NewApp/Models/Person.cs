using System.Security.AccessControl;
namespace NewApp.Models
{
    public class person
    {
        public string Fullname{get; set; }
        public string MSV {get; set; }
        public int Age{get; set; }
        public void Nhapthongtin()
        {
           System.Console.Write("Fullname = ");
           Fullname = Console.Readline();
          System.Console.Write("MSV =");
           MSV = Console.Readline();
           System.Console.Write("Age =");
           Age.Console.ReadLine();
        }
        public void HienThi()
        {
            SystemAcl.System.Console.WriteLine("{0}-{1}",Fullname,MSV,Age);}
           
        
        }

          
    }

