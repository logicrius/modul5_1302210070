using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210070
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData= new List<T>();
            this.inputDates= new List<DateTime>();
        }

        public void addNewData(T data, DateTime time)
        {
            this.storedData.Add(data);
            this.inputDates.Add(time);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i+1) + " berisi: " + this.storedData[i] +  ", yang disimpan pada waktu " + this.inputDates[i]);
            }
        }

    }
}
