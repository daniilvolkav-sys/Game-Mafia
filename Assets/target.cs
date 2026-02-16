using UnityEngine;

public class target : MonoBehaviour
{

    public bool isTargetPractice;
    public float health = 10f;
    public float defaulthealth;

    private void Staart()
    {
        defaulthealth = health;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }


        void Die()
        {
            if (isTargetPractice)
            {
                health = defaulthealth;
                
            }
            else
            {
                Destroy(gameObject);
            }
                
            Debug.Log("Target Broken");
        }



    }
}
