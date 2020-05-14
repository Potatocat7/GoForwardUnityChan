using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    AudioSource audioSource;


    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter2D(Collision2D other)
    {
        // タグによって音を出す
        if (other.gameObject.CompareTag("Unitychan" ))
        {
            //Unitychanの時だけ鳴らさない
        }
        else
        {
            audioSource.Play();
        }
    }
}
