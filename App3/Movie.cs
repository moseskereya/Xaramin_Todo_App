using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace App3
{
  public  class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
