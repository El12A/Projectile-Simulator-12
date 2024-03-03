using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class PhysicsSimulator : SceneController
    {
        public bool reset;
        public bool inMotion;
        public bool isPaused;

        private Rigidbody projectileRb;
        private Vector3 velocityToReapply;

        // Start is called before the first frame update
        void Start()
        {
            projectileRb = projectile.projectileRb;
            projectileRb.isKinematic = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && reset == true)
            {
                inMotion = true;
                reset = false;
                projectile.projectileRb.isKinematic = false;
                // GET INITIAL VELOCITY FROM CALCULATED INPUTS ASWELL AS ACCELERATION
                // THEN APPLY INITIAL VELOCITY projectile.projectileRb.velocity = initialVelocity;
            }

            // when R is pressed the projectile is reset.
            if (Input.GetKeyDown(KeyCode.R) && reset == false)
            {
                ResetProjectile();
            }

            if (inMotion == true)
            {
                // GET ACCELERATION THEN CAN DO THIS projectileRb.AddForce(acceleration * projectileRb.mass, ForceMode.Force);
            }
        }

        private void ResetProjectile()
        {
            projectileRb.velocity = Vector3.zero;
            projectileRb.angularVelocity = Vector3.zero;
            projectileRb.isKinematic = true;
            projectileRb.transform.position = projectile.initialPosition;
            reset = true;
            inMotion = false;
        }

        // when the pause/play button is clicked then depending on the state it will either pause the projectile motion or allow it to contiue moving
        public void OnPausePlayButtonClick()
        {
            // if the simulation is not paused save the current velocity for the unpause and then set the rigidbogy to kinematic so it cannot move
            if (isPaused == false)
            {
                velocityToReapply = projectileRb.GetPointVelocity(projectileRb.position);
                projectileRb.isKinematic = true;
                isPaused = true;
                inMotion = false;
            }
            //else set kinematic to false so it can move and apply teh previous velocity saved in velocityToReapply
            else
            {
                projectileRb.isKinematic = false;
                projectileRb.velocity = velocityToReapply;
                isPaused = false;
                inMotion = true;
            }
        }
    }
}

