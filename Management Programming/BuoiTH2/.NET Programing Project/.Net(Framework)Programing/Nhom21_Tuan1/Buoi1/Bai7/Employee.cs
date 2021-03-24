using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Employee
    {
        private int Id;
        private String Name;
        private int YearOfBrith;
        private double SalaryLevel;
        public double BasicSalary;
        //cac phuong thuc
        public int GetId()
        {
            return Id;
        }
        public String GetName()
        {
            return Name;
        }

        public int GetYearOfBrith()
        {
            return YearOfBrith;
        }
        public double GetIncome()
        {
            return SalaryLevel * BasicSalary;
        }

        public void InPut()
        {
            Console.Write("\t- Nhập định danh: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t- Nhập tên nhân viên: ");
            Name = Console.ReadLine();
            Console.Write("\t- Nhập năm sinh: ");
            YearOfBrith = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t- Nhập lương cơ bản: "); //tự cho để nhập
            BasicSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t- Nhập bậc lương: "); //tự cho để nhập
            SalaryLevel = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("\t- Định danh:{0} ", Id);
            Console.WriteLine("\t- Tên nhân viên: {0}", Name);
            Console.WriteLine("\t- Năm sinh:{0} ", YearOfBrith);
            Console.WriteLine("\t- Lương cơ bản:{0} ", BasicSalary);
            Console.WriteLine("\t- Thu nhập: {0}", GetIncome());
        }
        public double GetSalaryLevel()
        {
            return SalaryLevel;
        }
        public void SetSalaryLevel(double salaryLevel)
        {
            SalaryLevel = salaryLevel;
        }

        public double GetBasicSalary()
        {
            return BasicSalary;
        }
        public void SetBasicSalary(double basicSalary)
        {
            BasicSalary = basicSalary;
        }
    }
}