using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Car
    {
        public string _id="ABC-1234";
        string _color="gray";
        int _year = 1998;
        //欄位 private
        //屬性
        //

        public void SaySomething()
        {
            Console.WriteLine(this._id);
        }
    }
}
