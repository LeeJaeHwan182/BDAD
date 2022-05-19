using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator ani;
    public GameObject enemys;

    private void Start()
    {
        ani = enemys.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            ani.SetBool("Pos", true);
        }
    }

}
