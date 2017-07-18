using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataTable dt = new DataTable("Test"))
            {
                //add columns
                dt.Columns.Add("ID", typeof(int));
                dt.PrimaryKey = new DataColumn[] {dt.Columns["ID"]};
                dt.Columns.Add("Dosage", typeof(int));
                dt.Columns.Add("Drug", typeof(string));
                dt.Columns.Add("Patient", typeof(string));
                dt.Columns.Add("Date", typeof(DateTime));

                //add data to rows
                dt.Rows.Add(1,1, "Indocin", "David", DateTime.Now);
                dt.Rows.Add(2, 2, "Panadol", "Sam", DateTime.Now);
                dt.Rows.Add(3, 3, "Amalar", "Victor", DateTime.Now);
                dt.Rows.Add(4, 4, "Lumartem", "Ada", DateTime.Now);
                dt.Rows.Add(5, 5, "Cofta", "Emmanuel", DateTime.Now);

                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine("ID={4}, Dosage - {0}, Drug - {1}, Patient - {2}, Date - {3}", dr["Dosage"], dr["Drug"], dr["Patient"], dr["Date"], dr["ID"]);
                }
            }
            Console.ReadKey();
        }
    }
}
