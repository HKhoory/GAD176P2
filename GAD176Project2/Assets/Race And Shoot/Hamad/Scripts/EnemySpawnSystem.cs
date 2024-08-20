using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GAD176.Hamad.Enemy
{
    public class EnemySpawnSystem : MonoBehaviour
    {

        [SerializeField] private GameObject[] enemies;
        [SerializeField] private float spawnRadius;

        public UnityEvent spawnEvent = new UnityEvent();
        public delegate void HitEnemy();
        public HitEnemy EnemyIsHit;

        //each enemy has to find the enemyspawner in the scene

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float randX, randY;

            randX = Random.Range(-spawnRadius, spawnRadius);
            randY = Random.Range(-spawnRadius, spawnRadius);

            //if an event is executed
            //spawn the enemy

        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireCube(transform.position, new Vector2(spawnRadius, spawnRadius));
        }

    }

}