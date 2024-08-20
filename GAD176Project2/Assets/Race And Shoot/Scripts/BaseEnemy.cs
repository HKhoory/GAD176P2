using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.Hamad.Enemy
{
    public class BaseEnemy : MonoBehaviour
    {
        /// <summary>
        /// Has the basic functions for an enemy
        /// </summary>


        public virtual void Move() //responsible for moving the enemy
        {
            Debug.Log("Enemy is moving");
        }

        protected virtual void Shoot() //responsible for making the enemy shoot
        {
            Debug.Log("Enemy is shooting");
        }

        protected virtual void DestroyEnemy() //responsible for destroying the enemy
        {
            Destroy(gameObject);
        }

    }
}