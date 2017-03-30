using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberspaceInvader
{
    public class Lasers : List<Laser>
    {
        public void Move()
        {
            for (int i = 0; i < Count; i++)
            {
                this[i].Move();
            }
        }

        public void CheckHit(Alien alien)
        {
            for (int i = 0; i < this.Count; i++)
            {
                this[i].CheckHit(alien);
            }
        }
    }
}
