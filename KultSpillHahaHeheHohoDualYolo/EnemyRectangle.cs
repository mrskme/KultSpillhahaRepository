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
        private bool _isColliding;
        static readonly List<EnemyRectangle> _enemyList = Spawner.GetList();
        public EnemyRectangle(int speed, string direction) : base("Enemy", 50, 50)
        {
            _speed = speed;
            _direction = direction;
        }
        public void MoveDirection()
        {
            if (!_isColliding)
            {
                if (_direction == "down")
                {
                    newRectangle.Top += _speed;
                }
            }
            if (!_isColliding)
            {
                if (_direction == "up")
                {
                    newRectangle.Top -= _speed;
                }
            }
            if (!_isColliding)
            {
                if (_direction == "left")
                {
                    newRectangle.Left -= _speed;
                }
            }
            if (!_isColliding)
            {
                if (_direction == "right")
                {
                    newRectangle.Left += _speed;
                }
            }
        }
        public void EnemyColliderino(EnemyRectangle enemy2)
        {
            if (newRectangle.Bounds.IntersectsWith(enemy2.newRectangle.Bounds))
            {
                _isColliding = true;
            }
            _isColliding = false;
        }
        public static void IsEnemyColliding()
        {
            foreach (EnemyRectangle enemy in _enemyList)
            {
                foreach (EnemyRectangle enemy2 in _enemyList)
                {
                    if (enemy != enemy2)
                    {
                        enemy.EnemyColliderino(enemy2);
                    }
                }
            }
        }
    }
}
