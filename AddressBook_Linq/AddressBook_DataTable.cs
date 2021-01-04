using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace AddressBook_Linq
{
    class AddressBook_DataTable
    {
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

            return dataTable;
        }
    }
}
