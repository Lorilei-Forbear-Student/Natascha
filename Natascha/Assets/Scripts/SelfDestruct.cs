using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Natascha
{
    public class SelfDestruct : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(Destroy());
        }
        
        public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
        {
            if(collision.gameObject.CompareTag("Player") == false)
            {
                Destroy(gameObject);
            }
        }
        IEnumerator Destroy()
        {
            yield return new WaitForSeconds(1);
            Destroy(gameObject);
        }
    }
}
