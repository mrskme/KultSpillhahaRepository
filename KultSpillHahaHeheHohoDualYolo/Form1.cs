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
        List<EnemyRectangle> enemyList = Spawner.GetList();
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
            EnemyRectangle.IsEnemyColliding();
            Move();
        }
        public void Move()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].MoveDirection();
            }
        }
    }
}
