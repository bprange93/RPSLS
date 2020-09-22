using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public override void ChooseGesture()
        {
            Random rnd = new Random();
            int index = rnd.Next(gesturesList.Count);
            gesture = gesturesList[index];

          
        }
    }
}
