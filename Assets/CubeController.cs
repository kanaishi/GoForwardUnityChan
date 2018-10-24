using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeController : MonoBehaviour
{
    public AudioClip block;
    private AudioSource audioSource;
    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    //public int a = 0;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        //a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);
        //Debug.Log(a);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
            //  a = 0;
        }
       

    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name != "UnityChan2D")
        {
            audioSource.PlayOneShot(block);
            Debug.Log("鳴った");
        
        }
    }
}