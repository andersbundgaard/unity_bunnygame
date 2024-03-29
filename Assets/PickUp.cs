using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private PointManager pm;
    public AudioClip PickUpAudioClip;

    // Start is called before the first frame update
    void Start(){
        pm = GameObject.Find("PointManager").GetComponent<PointManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            pm.AddPoint(1);
            AudioSource.PlayClipAtPoint(PickUpAudioClip, transform.position);
            Destroy(gameObject);
        }
    }
}
