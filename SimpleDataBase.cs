using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_103022330036
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;
        
        public SimpleDataBase()
        {
            storedData = new List<T>(); 
            inputDate = new List<DateTime>();
        }

        public void addNewData(T data)
        {
           storedData.Add(data);
           inputDate.Add(DateTime.Now);
        }

        public void showAllListData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Dat: {0}, Data: {1}", storedData[i], inputDate[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.addNewData(1);
            db.addNewData(2);
            db.addNewData(3);
            db.showAllListData();
        }
    }
}
