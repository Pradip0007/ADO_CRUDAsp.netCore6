using System;
namespace ADO_CRUD
{
	public  static class ConnectionString
	{
		private static string cs = "server=localhost;database=CrudADOdb;User Id=sa;Password=Pradip@2023";

		public static string dbcs { get => cs; }
    }
}

