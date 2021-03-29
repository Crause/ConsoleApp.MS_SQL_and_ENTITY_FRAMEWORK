namespace ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK
{
  public class Song
  {
    public int SongId { get; set; }
    public string SongName { get; set; }
    public int GroupId { get; set; }

    public virtual Group Group { get; set; } // связь с таблицей Group
  }
}
