using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : MonoBehaviour
{
    [SerializeField] int damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<TrailRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Animator>().SetTrigger("swing");         
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyHealth>() != null)
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }

    public void EnableCollider()
    {
        GetComponent<BoxCollider>().enabled = true;
    }

    public void DisAbleCollider()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    public void EnableTrail()
    {
        GetComponent<TrailRenderer>().enabled = true;
    }

    public void DisableTrail()
    {
        GetComponent<TrailRenderer>().enabled = false;
    }
}
