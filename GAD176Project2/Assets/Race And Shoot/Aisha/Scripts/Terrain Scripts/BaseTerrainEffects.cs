using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aisha.GAD176.Terrain
{
    [RequireComponent(typeof(BoxCollider2D))]

    public class BaseTerrainEffects : MonoBehaviour
    {
        [SerializeField] protected string targetTag;
        protected Rigidbody2D targetObject;
        protected BoxCollider2D box;

        protected void Start()
        {
            box = GetComponent<BoxCollider2D>();
            box.isTrigger = true;

        }

        protected virtual void AddEffect()
        {
            //Add terrain effect
        }

        protected virtual void RemoveEffect()
        {
            //Remove terrain effct
        }

        protected void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(targetTag))
            {
                targetObject = other.GetComponent<Rigidbody2D>();
                if(targetObject != null)
                {
                    AddEffect();
                    Debug.Log("Object detected");
                }
            }
        }

        protected void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(targetTag))
            {
                RemoveEffect();
                Debug.Log("Object exited");
            }
        }
    }
}



