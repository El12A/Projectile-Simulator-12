using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public abstract class Shape : Projectile
    {
        public float volume;
        public float mass;

        public float radius;
        public float Length;
        public float width;
        public float height;

        public abstract float CalculateVolume();
        public abstract Vector3 GetScale();
        public virtual float CalculateMass()
        {
            mass = density * volume;
            return mass;
        }
    }
}

