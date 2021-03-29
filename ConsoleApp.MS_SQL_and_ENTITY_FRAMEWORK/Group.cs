using System.Collections.Generic;

namespace ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK
{
  public class Group
  {
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public int? Year { get; set; }
    public string Type { get; set; }

    public virtual ICollection<Song> Songs { get; set; } // связь с таблицей Song
  }
}
