using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    class World
    {
        public void map()
        {
            

            for (int row = 0; row < 100; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    if ((row == column) || ((row + column) == 9))
                    {
                        DrawingTool.DrawOneStar();
                    }
                    else
                    {
                        DrawingTool.DrawOneSpace();
                    }
                }
            }

        }
    }
}
