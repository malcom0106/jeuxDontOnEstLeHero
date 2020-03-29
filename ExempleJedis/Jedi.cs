﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExempleJedis
{
    public class Jedi
    {
        public int PointsDeVie { get; set; }
        public void Attaquer(Droide droide)
        {
            if(droide != null)
            {
                droide.PointsDeVie -= 30;
            }
        }
    }
}
