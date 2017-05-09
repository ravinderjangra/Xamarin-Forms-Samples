using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using XamarinFormsSQLite.Model;

namespace XamarinFormsSQLite
{
    public class PersonRepository
	{
		public string StatusMessage { get; set; }
        private SQLiteConnection conn;

		public PersonRepository(string dbPath)
		{
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();
		}

		public void AddNewPerson(string name)
		{
			int result = 0;
			try
			{
				//basic validation to ensure a name was entered
				if (string.IsNullOrEmpty(name))
					throw new Exception("Valid name required");

                // Inserting new person into the Person table
                result = conn.Insert(new Person { Name = name });

				StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
			}
			catch (Exception ex)
			{
				StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
			}

		}

        public Person GetByName(string name)
        {

            //Using linq for filtering and searching in sqlite
            var person = from p in conn.Table<Person>() where p.Name == name select p;
            return person.SingleOrDefault();
        }

		public List<Person> GetAllPeople()
		{
            return conn.Table<Person>().ToList();
        }
	}
}