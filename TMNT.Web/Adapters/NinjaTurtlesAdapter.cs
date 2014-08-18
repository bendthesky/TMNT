using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMNT.Data;
using TMNT.Data.Models;

namespace TMNT.Web.Adapters
{
    public class NinjaTurtlesAdapter : INinjaTurtles
    {
        public NinjaTurtle GetTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = Db.NinjaTurtles.Where(t => t.Id == id).FirstOrDefault();
            return Turtle;
        }

        public List<NinjaTurtle> GetAllTurtles()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<NinjaTurtle> Turtles = Db.NinjaTurtles.ToList();
            return Turtles;
        }

        public int AddTurtle(string name, string weapon, string picture, string description)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = new NinjaTurtle { Name = name, Weapon = weapon, Picture = picture, Description = description };
            Db.NinjaTurtles.Add(Turtle);
            Db.SaveChanges();
            return Turtle.Id;
        }

        public void DeleteTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = Db.NinjaTurtles.Where(t => t.Id == id).FirstOrDefault();
            Db.NinjaTurtles.Remove(Turtle);
            Db.SaveChanges();
        }

        public void UpdateTurtle(int id, string name, string weapon, string picture, string description)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            NinjaTurtle Turtle = Db.NinjaTurtles.Where(t => t.Id == id).FirstOrDefault();
            Turtle.Name = name;
            Turtle.Picture = picture;
            Turtle.Weapon = weapon;
            Turtle.Description = description;
            Db.SaveChanges();
        }
    }
}