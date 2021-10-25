using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_demo
{
    class CollectionDemo
    {
        static void Main(String[] args)
        {
            #region Array
            //int[] NumberArray = new int [3];
            //NumberArray[0] = 90;
            //NumberArray[1] = 900;
            //NumberArray[2] = 8000;

            //for(int i = 0; i < NumberArray.Length; i++)
            //{
            //    Console.WriteLine(NumberArray[i]);
            //}
            #endregion

            #region System.Collection Classes
            //ArrayList CountryList = new ArrayList();
            //CountryList.Add("India");
            //CountryList.Add("America");
            //CountryList.Add("US");
            //CountryList.Insert(1, "UK");
            ////can take values of any data type
            //CountryList.Insert(2,900);
            //CountryList.Add(true);

            //Person person = new Person() { FirstName = "harshada", LastName = "Joshi" };
            //Console.WriteLine("FirstName :" + person.FirstName + "Lastname:" + person.LastName);

            //CountryList.Add(person);


            //for (int i = 0; i < CountryList.Count; i++)
            //{
            //    Console.WriteLine(CountryList[i]);
            //}

            #endregion

            #region Generic Collection classes

            //List<string> countryList = new List<string>();
            //countryList.Add("India");

            //List<int> numberList = new List<int>();
            //numberList.Add(100);

            //List<Person> personList = new List<Person>();
            //personList.Add(new Person() { FirstName = "harsha", LastName = "Joshi" });
            #endregion

            #region Nullable type

            //Nullable<int> x = null;
            //x = 100;
            //x = null;



            //int? y = null;
            #endregion
        }

    }
}
