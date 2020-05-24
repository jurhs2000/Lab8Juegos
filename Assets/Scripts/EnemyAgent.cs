using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAgent : MonoBehaviour
{
    private Vector3 startPos;
    public GameObject player;
    private bool isHunting = false;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHunting)
        {
            agent.SetDestination(player.transform.position);
        }
    }

    public void hunt()
    {
        isHunting = true;
    }

    public void setOrigin()
    {
        transform.position = startPos;
        isHunting = false;
    }
}
