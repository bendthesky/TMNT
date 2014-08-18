using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMNT.Data.Models;

namespace TMNT.Web.Adapters
{
    interface INinjaTurtles
    {
        NinjaTurtle GetTurtle(int id);
        List<NinjaTurtle> GetAllTurtles();
        int AddTurtle(string name, string weapon, string picture, string description);
        void DeleteTurtle(int id);
        void UpdateTurtle(int id, string name, string weapon, string picture, string description);
    }
}
