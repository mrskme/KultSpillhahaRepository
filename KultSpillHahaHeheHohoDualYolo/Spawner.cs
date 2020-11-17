using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Spawner
    {
        public static List<EnemyRectangle> EnemyList { get; } = new List<EnemyRectangle>
        {
            new EnemyRectangle(2, "down", Color.Aqua),
            new EnemyRectangle(1, "up", Color.Coral),
            new EnemyRectangle(4, "down", Color.Crimson),
            new EnemyRectangle(4, "up", Color.BlueViolet),
            new EnemyRectangle(8, "left", Color.Chartreuse)
        };

        public static List<Ground> GroundList { get; } = new List<Ground>
        {
            new Ground("grassBiome", 700, 40, true, Color.GreenYellow),
        };
        
        public void CreateEnemies(Form1 formInstance)
        {
            EnemyList[0].SpawnRectangle(formInstance, 100, 50);
            EnemyList[1].SpawnRectangle(formInstance, 100, 250);
            EnemyList[2].SpawnRectangle(formInstance, 200, 50);
            EnemyList[3].SpawnRectangle(formInstance, 200, 250);
            EnemyList[4].SpawnRectangle(formInstance, 500, 150);
        }

        public void CreateGroundi(Form1 formInstance)
        {
            GroundList[0].SpawnRectangle(formInstance, 0, 335);
        }
        //static for å lage objekt av klassen
    }
}
