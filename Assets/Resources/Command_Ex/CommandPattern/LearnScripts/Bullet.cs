using UnityEngine;

namespace Resources.Command_Ex.CommandPattern.LearnScripts
{
    public class Bullet : MonoBehaviour
    {
        public float Speed;

        private void Start()
        {
            Destroy(gameObject, 5f);
        }

        private void Update()
        {
            var transform1 = transform;
            transform1.position +=(transform1.forward * (Speed * Time.deltaTime));
        }
    }
}