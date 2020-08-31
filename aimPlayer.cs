using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimPlayer : MonoBehaviour//火の玉がプレイヤーに向かって飛んでいくプログラム
{
    public Transform hinotamaTf;
    Transform playerTf;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("HinotamaTarget").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(hinotamaTf.position.z > playerTf.position.z)
        {
            hinotamaTf.LookAt(playerTf);
        }
        if(Vector3.SqrMagnitude(playerTf.position - hinotamaTf.position) < 10)
        {
            hinotamaTf.Translate(0, 0, 0.1f);
            hinotamaTf.Translate(0, 0, 0.3f, Space.World);
        }
        else
        {
            hinotamaTf.Translate(0, 0, 0.25f);
            hinotamaTf.Translate(0, 0, 0.5f, Space.World);
        }
        
        if(hinotamaTf.position.z + 100 < playerTf.position.z)
        {
            Destroy(gameObject);
        }
    }
}
