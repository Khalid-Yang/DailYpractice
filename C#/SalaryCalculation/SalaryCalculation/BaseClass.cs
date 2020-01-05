using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseClass
{
    interface IThing
    {
        string Type{get;}
        //打印自生信息
        void TellAboutSelf();
    }



    public abstract class Employee:IThing
    {
        private string name;
        private float salary ;
        private DateTime bornDay;
        public float earnings;
        public abstract float Earnings();

        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTime BornDay
        {
            get { return bornDay; }
            set { bornDay = value; }
        }


        //定义构造函数
        public Employee(string name,int year,int m,int d)
        {
            this.Name = name;
            this.BornDay = new DateTime(year,m,d);
        }

        public abstract string Type { get; }

        public virtual void TellAboutSelf()
        {
            Console.WriteLine("姓名：{0}         出生日期：{1}", Name, bornDay);
            Console.WriteLine("职务：{0}         实发工资：￥{1}",Type ,earnings);
        }
    }

    //经理
    class Manager : Employee
    {
        private float basicSalary;
        private float bonus;      //奖金
        public Manager(string Name, int year,int m,int d,float BasicSalary, float Bonus)
            : base(Name,year,m,d)
        {
            this.Name = Name;
            this.BornDay = new DateTime(year, m, d);
            this.basicSalary = BasicSalary;
            this.bonus = Bonus;
        }

        public override string Type
        {
            get { return "经理"; }
        }

        public override float Earnings()
        {

            earnings = basicSalary + bonus;
            return earnings;
        }
        public new void TellAboutSelf()
        {
            Earnings();
            base.TellAboutSelf();
            Console.WriteLine("基本工资：￥{0}", basicSalary);
            Console.WriteLine("奖金：￥{0}", bonus);
            Console.WriteLine("---------------------------------------------------");
        }
    }




    //销售员
    class Salesperson : Employee
    {

                
            private float basicSalary{get;set;}
            private float sale{get;set;}      
            private float royaltyRate{get;set;}

            public Salesperson(string Name, int year,int m,int d,float BasicSalary, float Sale,float RoyaltyRate)
                :  base(Name,year,m,d)
            {
                this.basicSalary = BasicSalary;
                this.sale = Sale;
                this.royaltyRate = RoyaltyRate;

            }

            public override string Type
            {
                get { return "销售员"; }
            }
        public override float Earnings()
        {
            earnings=0;
            earnings=basicSalary+sale*royaltyRate;
            return earnings;
        }
        public override void TellAboutSelf()
        {
            Earnings();
            base.TellAboutSelf();
            Console.WriteLine("基本工资：￥{0}", basicSalary);
            Console.WriteLine("销售额：￥{0}", sale);
            Console.WriteLine("提成率：{0}", royaltyRate);
            Console.WriteLine("---------------------------------------------------");
        }
  


    }

    //计时工人
    class Timeworker : Employee
    {
            private float hourPrice{get;set;}
            private float workTime { get; set; }      

            public Timeworker(string Name, int year,int m,int d,float HourPrice, float WorkTime)
                : base(Name, year, m, d)
            {
                this.hourPrice = HourPrice;
                this.workTime= WorkTime;
            }
            public override string Type
            {
                get { return "计时工人"; }
            }
        public override float Earnings()
        {
            if (workTime>40)
            {
                earnings = (float)(hourPrice * workTime + (workTime - 40) * 1.50);
                return earnings;
            } 
            else
            {
                earnings= hourPrice*workTime;
                return earnings;
            }
            
        }
        public override void TellAboutSelf()
        {
            Earnings();
            base.TellAboutSelf();
            Console.WriteLine("每小时工资：￥{0}", hourPrice);
            Console.WriteLine("工作小时数：{0}",  workTime);
            Console.WriteLine("---------------------------------------------------");
        }

    }

    //计件工人
    class PieceWorker : Employee
    {
        private float pcPrice{get;set;}
        private int piece{get;set;}      

        public PieceWorker(string Name, int year,int m,int d,float PcPrice, int Price)
            : base(Name, year, m, d)
        {
                this.pcPrice = PcPrice;
                this.piece= Price;
        }

        public override string Type
        {
            get { return "计件工人"; }
        }
        public override float Earnings()
        {
            earnings=pcPrice*piece;
            return earnings;
        }
        public override void TellAboutSelf()
        {
            Earnings();
            base.TellAboutSelf();

            Console.WriteLine("每件工资：￥{0}", pcPrice);
            Console.WriteLine("生产产品件数：{0}", piece);
            Console.WriteLine("---------------------------------------------------");
        }

    }

}
