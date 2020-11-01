using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Library
{
    class Customer
    {
        // fields (alanlar) //  public tanımlanmaz
        string _name; // global değişken
        // string _surname;
        //int _age;
        //public string country;

        // properties -- prop tab tab
        public string Surname { get; set; } // otomatic kapsülleme yaptı
        public int Age { get; set; }
        public string City { get; set; }
        public int Id { get; set; }

        // behaviors

        public void SetName(string name)
        {
            //int a; .... değişken sadece bu alan için

            this._name = name;
        }

        public string GetName()
        {
            return _name;
        }

        // encapsulation bütün ALnlR İÇİN YAPILIR

    }
}
