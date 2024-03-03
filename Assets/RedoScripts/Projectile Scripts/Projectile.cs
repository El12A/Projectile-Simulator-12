using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class Projectile : GameComponent
    {
        public GameObject projectileObject;
        public SphereProjectile sphereProjectile;

        public Mesh mesh;
        public Rigidbody projectileRb;
        public MeshCollider projectileMC;
        public MeshFilter projectileMF;
        public MeshRenderer projectileMR;

        protected Dictionary<string, float> materials =
        new Dictionary<string, float>()
        {
        {"Wood", 800},
        {"Polystyrene", 30},
        {"Glass", 2600},
        {"Lead", 11343},
        {"Iron", 7870},
        {"Gold", 19320}
        };
        protected string materialName;
        public float density;
        public float restution;
        public float frictionalCoefficient;

        public Vector3 initialPosition;
        public Vector3 currentVelocity;
        public Vector3 currentAcceleration;
        public Vector3 displacement;
        public Vector3 timeIsMoving;

        private void Start()
        {
            initialPosition = transform.position;
        }
    }
}
