using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SigmaMenu.Mods
{
    class Noclip
    {
        public static void NoClipMod()
        {
            bool disableColliders2 = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                (collider.enabled) = !disableColliders2;
            }
        }
    }
}
