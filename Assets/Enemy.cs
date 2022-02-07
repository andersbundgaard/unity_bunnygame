using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{

    public GameObject SpawnPoint;
    public GameObject FireballPrefab;
    public float Speed = 10;
    public float SpawnInterval = 1f;

    IEnumerator Start(){
        GameObject spanw = Instantiate(FireballPrefab) as GameObject;
        spanw.transform.position = SpawnPoint.transform.position;
        spanw.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Speed);
        Destroy(spanw, 3);
        yield return new WaitForSeconds(SpawnInterval);

        StartCoroutine(Start());
    }

}
