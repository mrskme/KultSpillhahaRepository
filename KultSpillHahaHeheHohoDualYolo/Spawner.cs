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
        private static List<EnemyRectangle> enemyList = new List<EnemyRectangle>();
        static EnemyRectangle enemy0 = new EnemyRectangle(2, "right");
        static EnemyRectangle enemy1 = new EnemyRectangle(1, "up");
        static EnemyRectangle enemy2 = new EnemyRectangle(4, "up");
        static EnemyRectangle enemy3 = new EnemyRectangle(4, "down");
        static EnemyRectangle enemy4 = new EnemyRectangle(8, "down");

        public void CreateEnemies(Form1 formInstance)
        {
            enemy0.SpawnRectangle(formInstance, 100, 50, Color.Aqua);
            enemy1.SpawnRectangle(formInstance, 100, 101, Color.Coral);
            enemy2.SpawnRectangle(formInstance, 100, 152, Color.Crimson);
            enemy3.SpawnRectangle(formInstance, 100, 203, Color.BlueViolet);
            enemy4.SpawnRectangle(formInstance, 100, 254, Color.Chartreuse);
            enemyList.Add(enemy0);
            enemyList.Add(enemy1);
            enemyList.Add(enemy2);
            enemyList.Add(enemy3);
            enemyList.Add(enemy4);
        }
        public static List<EnemyRectangle> GetList()
        {
            return enemyList;
        }
        //static for å lage objekt av klassen
    }
}
