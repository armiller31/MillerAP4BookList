using System;
using SQLite;

namespace MillerAP4BookList
{
	public class Book
	{
		public Book()
		{
		}
		[PrimaryKey, AutoIncrement]
		public int BookId { get; set; }
		public string BookTitle { get; set; }
		public string ISBN { get; set; }
	}
}
