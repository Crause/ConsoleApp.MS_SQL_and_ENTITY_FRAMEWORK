using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.MS_SQL_and_ENTITY_FRAMEWORK
{
  class Program
  {
    static void Main(string[] args)
    {
      using(var context = new MyDbContext())
      {
        var group = new Group()
        {
          GroupName = "Rammstein",
          Year = 1994,

        };

        var group2 = new Group()
        {
          GroupName = "Linkin park",

        };

        context.Groups.Add(group);
        context.Groups.Add(group2);
        context.SaveChanges();

        var songs = new List<Song>
        {
          new Song() { SongName = "Mutter", GroupId = group.GroupId},
          new Song() { SongName = "In The End", GroupId = group2.GroupId},
          new Song() { SongName = "Numb", GroupId = group2.GroupId}
        };
        context.Songs.AddRange(songs);
        context.SaveChanges();

        var s = context.Groups.Single(x => x.GroupId == group.GroupId);
        s.GroupName = "ggggggg";
        context.SaveChanges();
        
        foreach(var song in songs)
        {
          Console.WriteLine($"Song name: {song.SongName} Group name: {song.Group.GroupName}");
        }

        //Console.WriteLine($"id: {group.GroupId} name: {group.GroupName} year: {group.Year}");
        Console.ReadLine();
      }
    }
  }
}
