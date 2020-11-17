using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    public partial class Form1 : Form
    {
        private int position;
        Spawner enemySpawn = new Spawner();
        List<EnemyRectangle> enemyList = new Spawner().GetList();
        //private List<EnemyRectangle> enemyList = new List<EnemyRectangle>();
        public Form1()
        {
            InitializeComponent();
            LoadGame();
        }

        private void LoadGame()
        {
            enemySpawn.CreateEnemies(this);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Move()
        {
            enemyList[0].MoveDirection();
            enemyList[1].MoveDirection();
            enemyList[2].MoveDirection();
            enemyList[3].MoveDirection();
        }

        //public void CollisionCheck()
        //{
        //    foreach (EnemyRectangle enemy in enemyList)
        //    {
        //        foreach (EnemyRectangle enemy2 in enemyList)
        //        {
        //            if (enemy != enemy2)
        //            {
        //                enemy.Colliderino(enemy2);
        //            }

        //        }
        //    }
        //}
    }
}
