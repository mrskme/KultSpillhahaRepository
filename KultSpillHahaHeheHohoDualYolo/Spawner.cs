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
        private List<EnemyRectangle> enemyList = new List<EnemyRectangle>();
        EnemyRectangle enemy0 = new EnemyRectangle(2, "left");
        EnemyRectangle enemy1 = new EnemyRectangle(1, "up");
        EnemyRectangle enemy2 = new EnemyRectangle(4, "up");
        EnemyRectangle enemy3 = new EnemyRectangle(4, "down");

        public void CreateEnemies(Form1 formInstance)
        {
            enemy0.SpawnRectangle(formInstance, 100, 0, Color.Aqua);
            enemy1.SpawnRectangle(formInstance, 100, 300, Color.Coral);
            enemy2.SpawnRectangle(formInstance, 100, 400, Color.Crimson);
            enemy3.SpawnRectangle(formInstance, 100, 200, Color.BlueViolet);
        }
        public List<EnemyRectangle> GetList()
        {
            enemyList.Add(enemy0);
            enemyList.Add(enemy1);
            enemyList.Add(enemy2);
            enemyList.Add(enemy3);
            return enemyList;
        }
    }
}
