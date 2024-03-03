using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class SphereProjectile : Shape
    {
        public override float CalculateVolume()
        {
            // Volume formula for sphere: v = 4/3 x pi x r^3
            volume = (4 / 3) * Mathf.PI * radius * radius * radius;
            return volume;
        }
        public override Vector3 GetScale()
        {
            //sphere model has default of 0.5m radius when scale is all set to 1
            //therefore the object has to scale by the radius (in metres) times 2 to get correct scale for desired radius
            float newScale = 2.0f * radius;
            return new Vector3(newScale, newScale, newScale);
        }
    }
}

