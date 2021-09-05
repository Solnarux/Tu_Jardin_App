using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu_Jardin_App.Shared.Models
{
    public class Plant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Seeddate { get; set; }

        public string Img { get; set; }

        public string Owner { get; set; }

        public string Email { get; set; }

        public Achieve Achievements { get; set; }

        public int AchievementsId { get; set; }


    }

}
