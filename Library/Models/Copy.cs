using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Library.Models
{
  public class Copy
  {
    public int CopyId { get; set; }
    public int PublicationYear { get; set; }
    public string Edition { get; set; }
    public int BookId { get; set; }
  }

}