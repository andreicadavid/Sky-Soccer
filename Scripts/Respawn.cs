using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public Transform spawn;
    [SerializeField] public float spawnValue;
    private void OnTriggerEnter()
    {
        RespawnPoint();
    }

void RespawnPoint()
    {
        player.transform.position = spawn.position;
    }
}
