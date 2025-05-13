using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class clsCalculator
    {
        private int _Reselt=0;
        private int _listReselt=0;
        
        private void ListReselt()
        {

             _listReselt = _Reselt;
        }
        public void Add(int num)
        {
            ListReselt();
            _Reselt += num;
        }

        public void Subtract(int num)
        {
            ListReselt();
             _Reselt -= num;
        }

        private bool numis1(int num)
        {
            return num == 0;
        }
        public void Divide(int num)
        {
            ListReselt();
            if (numis1(num))
            {
                 _Reselt /= 1;
            }else 
             _Reselt /= num;

        }

        public void Multiply(int num)
        {
            ListReselt();
            _Reselt *= num;
        }

        public void Clear()
        {
            ListReselt();
            _Reselt = 0;
        }

        public void PrintResult()
        {
            Console.Write(_Reselt.ToString()+"\n");
        }
        public void PrintListReselt()
        {
            Console.Write(_listReselt.ToString()+"\n");

        }
       
    }
}
