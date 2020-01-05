using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseClass;

namespace SalaryCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("张华",1987,8,11,1000,500);
            Salesperson s=new Salesperson("王菲",1981,3,8,800,2000,30);
            Timeworker t=new Timeworker("李立",1978,9,20,13,50);
            PieceWorker p = new PieceWorker("吴浩", 1981, 3, 8, 2, 200);

            m.TellAboutSelf();
            s.TellAboutSelf();
            t.TellAboutSelf();
            p.TellAboutSelf();
        }
    }

    
}

