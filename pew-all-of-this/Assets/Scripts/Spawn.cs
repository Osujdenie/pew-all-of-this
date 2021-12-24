using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject circle;

    void Start()
    {
        StartCoroutine(SpawnCircle());
    }

    void Update()
    {
        if (GameObject.Find("Player") == null)
        {
            StopAllCoroutines();
        }
    }
    IEnumerator SpawnCircle()
    {
        Vector2 pos = spawnPos.position + new Vector3(Random.Range(-1.5f, 1.5f), 0, 0);
        Instantiate(circle, pos, Quaternion.identity);
        yield return new WaitForSeconds(3);
        if (GameObject.Find("Player") != null)
        {
            Repeat();
        }
    }

    void Repeat()
    {
        StartCoroutine(SpawnCircle());
    }
}
