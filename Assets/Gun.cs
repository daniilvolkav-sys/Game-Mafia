using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float impactForce = 100f;
    public float range = 100f;
    public float firingRate = 15f;

    public Camera FPSCam;
    private float nexTimetoFire = 0f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nexTimetoFire)
        {
            nexTimetoFire = Time.time + 1f / firingRate;
            Shoot();
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            target target = hit.transform.GetComponent<target>();
            if (target != null);
            {
                target.TakeDamage(damage);
            }
        }
    }
}
