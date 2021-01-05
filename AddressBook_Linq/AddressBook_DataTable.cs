using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace AddressBook_Linq
{
    class AddressBook_DataTable
    {
        /// <summary>
        ///UC 1 Create data table
        /// </summary>
        public readonly DataTable dataTable = new DataTable();
        public void  CreateTable()
        {
            var taleColumn1 = new DataColumn("firstName",typeof(string));
            dataTable.Columns.Add(taleColumn1);
            var taleColumn2 = new DataColumn("lastName", typeof(string));
            dataTable.Columns.Add(taleColumn2);
            var taleColumn3 = new DataColumn("city", typeof(string));
            dataTable.Columns.Add(taleColumn3);
            var taleColumn4 = new DataColumn("state", typeof(string));
            dataTable.Columns.Add(taleColumn4);
            var taleColumn5 = new DataColumn("zip", typeof(string));
            dataTable.Columns.Add(taleColumn5);
            var taleColumn6 = new DataColumn("phoneNumber", typeof(string));
            dataTable.Columns.Add(taleColumn6);

            ///UC 2 Insert Record
            
            dataTable.Rows.Add("Imran", "Shaikh", "Pune", "Maha", "345678", "6567890999");
            dataTable.Rows.Add("Anis", "Sayad", "Mumbai", "Maha", "345666", "9000998889");
            dataTable.Rows.Add("Arbaj", "Shaikh", "NCR", "Delhi", "345678", "6567890999");
            dataTable.Rows.Add("Nijam", "Sayad", "NCR", "Delhi", "345666", "9000998889");
            dataTable.Rows.Add("Nijam", "Shaikh", "Pune", "Maha", "345678", "6567890999");
            dataTable.Rows.Add("Nijam", "Sayad", "Mumbai", "Maha", "345666", "9000998889");

            //return dataTable;
        }

        /// <summary>
        /// Add the contact.
        /// </summary>
        /// <param name="Model">The model.</param>
        public void AddContact(AddressModel Model)
        {
            dataTable.Rows.Add(Model.firstName, Model.lastName, Model.city, 
                Model.state, Model.zip, Model.phoneNumber);
            Console.WriteLine("Contact Added Succesfully...");
        }

        /// <summary>
        /// UC 3 Edits the contact.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContact(AddressModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("firstName") == model.firstName).First();
            if (recordData != null)
            {
                recordData.SetField("LastName", model.lastName);
                recordData.SetField("Address", model.address);
                recordData.SetField("City", model.city);
                recordData.SetField("State", model.state);
                recordData.SetField("ZipCode", model.zip);
                recordData.SetField("PhoneNumber", model.phoneNumber);
            }
        }

        /// <summary>
        /// UC 4 Deletes the name of the contact by.
        /// </summary>
        public void DeleteContact(AddressModel model)
        {
            var recordData = dataTable.AsEnumerable().Where(data => data.Field<string>("firstName") == model.firstName).First();
            if (recordData != null)
            {
                recordData.Delete();
                Console.WriteLine("....Deleted Success....");
            }
        }

        /// <summary>
        ///U5 Retrives the state of the data by city.
        /// </summary>
        /// <param name="model">The model.</param>
        public void RetriveData_By_CityState(AddressModel table)
        {

            var recordData = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("city") == table.city) select dataTable;
            foreach (var tables in recordData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + tables.Field<string>("firstName"));
                Console.WriteLine("LastName:-" + tables.Field<string>("lastName"));
                Console.WriteLine("City:-" + tables.Field<string>("city"));
                Console.WriteLine("State:-" + tables.Field<string>("state"));
                Console.WriteLine("ZipCode:-" + tables.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:-" + tables.Field<string>("phoneNumber"));
            }
        }

        /// <summary>
        /// UC 6 Retrive By State
        /// </summary>
        /// <param name="table"></param>
        public void RetriveData_By_State(AddressModel table)
        {

            var recordData = from dataTable in dataTable.AsEnumerable().Where(dataTable => dataTable.Field<string>("state") == table.state) select dataTable;
            foreach (var tables in recordData.AsEnumerable())
            {
                Console.WriteLine("\nFirstName:-" + tables.Field<string>("firstName"));
                Console.WriteLine("LastName:-" + tables.Field<string>("lastName"));
                Console.WriteLine("City:-" + tables.Field<string>("city"));
                Console.WriteLine("State:-" + tables.Field<string>("state"));
                Console.WriteLine("ZipCode:-" + tables.Field<string>("zip"));
                Console.WriteLine("PhoneNumber:-" + tables.Field<string>("phoneNumber"));
            }
        }

        /// <summary>
        /// UC 7 Count By City or State 
        /// </summary>
        /// <param name="table"></param>
        
        public void Count_BY_City_State()
        {
            var countBycityState = from row in dataTable.AsEnumerable()
                                   group row by new { City = row.Field<string>("city"),State = row.Field<string>("state") } into groups
                                   select new
                                   {
                                       City = groups.Key.City,
                                       State = groups.Key.State,
                                       count = groups.Count()
                                   };
            foreach (var data in countBycityState)
            {
                Console.WriteLine(data.City,"\n"+data.State,"\n"+data.count);
            }
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
