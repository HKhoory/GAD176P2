using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha.GAD176.Terrain
{
    [RequireComponent(typeof(BoxCollider2D))]

    public class RotatePlayer : MonoBehaviour
    {
        #region Variables 
        [SerializeField] string otherColliderTag;
        [SerializeField] float rotationDuration;
        [SerializeField] float rotationSpeed;
        Player player;
        BoxCollider2D box;
        #endregion


        void Start()
        {
            box = GetComponent<BoxCollider2D>();
            box.isTrigger = true;
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == otherColliderTag)
            {
                Debug.Log("Player Entered");

                player = other.GetComponent<Player>();

                if (player != null)
                {
                    StartCoroutine(TriggerRotate());
                }
            }
        }

        IEnumerator TriggerRotate()
        {
            Debug.Log("Timer Started");

            float time = 0f;
            while (time < rotationDuration)
            {
                player.transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
                time += Time.deltaTime;
                yield return null;
            }

            Debug.Log("Timer Ended");
        }

    }
}