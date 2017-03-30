using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberspaceInvader
{
    public class Bombs : List<Bomb>
    {
        public void Move()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].Move();
            }
        }

        public void CheckHit(User user)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].CheckHit(user);
            }
        }
    }
}
