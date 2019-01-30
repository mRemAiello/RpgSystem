/*using UnityEngine;
using System.Collections;
using System.Linq;
using RPGSystem;

namespace Nanergame
{
    [RequireComponent(typeof(Actor))]
    public class DamageableObject : MonoBehaviour
    {
        protected Animator animator;
        protected Actor actor;

        [Header("Prefabs")]
        public GameObject deathPrefab;
        public GameObject healingPrefab;

        [Header("Text")]
        public GameObject textGameObject;

        private RPGAttribute health;
        public int Health
        {
            get
            {
                return (int)health.CurrentValue;
            }
        }

        public virtual bool Death
        {
            get
            {
                return (health.CurrentValue <= 0);
            }

            set
            {
                if (!value)
                    return;

                animator.SetTrigger("Death");
                Invoke("OnDespawn", animator.GetCurrentAnimatorStateInfo(0).length);
            }
        }

        public void OnEnable()
        {
            actor = GetComponent<Actor>();
            health = actor.Attributes.FirstOrDefault(x => x.Name.Equals("Health"));
            animator = GetComponent<Animator>();

            Debug.Log(actor);
            foreach (RPGAttribute attribute in actor.Attributes)
                Debug.Log(attribute.Name);

        }

        public void OnDisable()
        {
            StopAllCoroutines();
        }

        public void OnDespawn()
        {
            if (deathPrefab != null)
                Instantiate(deathPrefab, transform.position, transform.rotation);

            //PoolsManager.Despawn(gameObject);
        }

        public void TakeDamage(int amount, bool isCrit = false)
        {
            if (Death)
                return;

            Blink();
            //health.CurrentValue -= amount;
            if (health.CurrentValue <= 0)
                Death = true;
        }

        public void Heal(int amount)
        {
            if (Death)
                return;

            //health.CurrentValue += amount;

            if (healingPrefab != null)
                Instantiate(healingPrefab, transform.position, transform.rotation);
        }

        private void Blink()
        {
            StopCoroutine("C_Blink");
            StartCoroutine("C_Blink");
        }

        private IEnumerator C_Blink()
        {
            if (Death)
                yield break;

            float blinkTime = 0.4f;
            Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers)
                r.material.color = Color.red;
            yield return new WaitForSeconds(blinkTime);
            foreach (Renderer r in renderers)
                r.material.color = Color.white;
        }
    }
}
*/