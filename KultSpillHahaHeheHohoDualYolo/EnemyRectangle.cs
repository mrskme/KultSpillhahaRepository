using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KultSpillHahaHeheHohoDualYolo
{
    class EnemyRectangle : Rectangle1
    {
        private int _speed;
        private string _direction;
        //private List<EnemyRectangle> enemyList = new List<EnemyRectangle>();
        List<EnemyRectangle> enemyList = new Spawner().GetList();
        public EnemyRectangle(int speed, string direction) : base("Enemy", 50, 50)
        {
            _speed = speed;
            _direction = direction;
        }
        public void MoveDirection()
        {
            if (_direction == "down")
            {
                if (!IsColliding())
                {
                    newRectangle.Top += _speed;
                }
            }
            if (!IsColliding()) 
            {
                if (_direction == "up")
                {
                    newRectangle.Top -= _speed;
                }
            }
            if (!IsColliding()) 
            {
                if (_direction == "left")
                {
                    newRectangle.Left -= _speed;
                }
            }
            if (!IsColliding()) 
            {
                if (_direction == "right")
                {
                    newRectangle.Left += _speed;
                }
            }
        }
        //public void Colliderino(EnemyRectangle enemy2)
        //{
        //    if (!newRectangle.Bounds.IntersectsWith(enemy2.newRectangle.Bounds))
        //    {
        //        return true;
        //        //newRectangle.Top -= _speed;
        //        //enemy2.newRectangle.Top += enemy2._speed;
        //    }
        //}
        public bool IsColliding()
        {
            foreach (EnemyRectangle enemy in enemyList)
            {
                foreach (EnemyRectangle enemy2 in enemyList)
                {
                    if (enemy != enemy2)
                    {
                        //return enemy.Colliderino(enemy2);
                        if (enemy.newRectangle.Bounds.IntersectsWith(enemy2.newRectangle.Bounds))
                        {
                            return true;
                            //newRectangle.Top -= _speed;
                            //enemy2.newRectangle.Top += enemy2._speed;
                        }
                    }
                }
            }
            return false;
        }
    }
}
