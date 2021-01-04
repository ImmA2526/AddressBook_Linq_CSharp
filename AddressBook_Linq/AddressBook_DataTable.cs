using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace AddressBook_Linq
{
    class AddressBook_DataTable
    {
        /// <summary>
        ///UC 1 Create data table
        /// </summary>
        public readonly DataTable dataTable = new DataTable();
        public DataTable CreateTable(AddressModel model)
        {
            var taleColumn1 = new DataColumn("firstName");
            dataTable.Columns.Add(taleColumn1);
            var taleColumn2 = new DataColumn("lastName");
            dataTable.Columns.Add(taleColumn2);
            var taleColumn3 = new DataColumn("city");
            dataTable.Columns.Add(taleColumn3);
            var taleColumn4 = new DataColumn("state");
            dataTable.Columns.Add(taleColumn4);
            var taleColumn5 = new DataColumn("zip");
            dataTable.Columns.Add(taleColumn5);
            var taleColumn6 = new DataColumn("phoneNumber");
            dataTable.Columns.Add(taleColumn6);

            ///UC 2 Insert Record
            
            dataTable.Rows.Add("Imran", "Shaikh", "Pune", "Maha", "345678", "6567890999");
            dataTable.Rows.Add("Anis", "Sayad", "Mumbai", "Maha", "345666", "9000998889");
            dataTable.Rows.Add("Arbaj", "Shaikh", "NCR", "Delhi", "345678", "6567890999");
            dataTable.Rows.Add("Nijam", "Sayad", "NCR", "Delhi", "345666", "9000998889");
            dataTable.Rows.Add("Nijam", "Shaikh", "Pune", "Maha", "345678", "6567890999");
            dataTable.Rows.Add("Nijam", "Sayad", "Mumbai", "Maha", "345666", "9000998889");

            return dataTable;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + table.Field<string>("firstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("lastName"));
                Console.WriteLine("City:-" + table.Field<string>("city"));
                Console.WriteLine("State:-" + table.Field<string>("state"));
                Console.WriteLine("ZipCode:-" + table.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:-" + table.Field<string>("phoneNumber"));
            }
        }
    }
}
