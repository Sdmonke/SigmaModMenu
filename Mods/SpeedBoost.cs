﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 15f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 15f;
        }
      

    }
}
