using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PiPerSpaw : MonoBehaviour
{
    public GameObject _PiPePrefabs;
    void Start()
    {
        StartCoroutine(SpawPipe());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawPipe()
    {
       while(true)
        {
            Vector2 Pospaw=new Vector2(4.14f, Random.Range(1.37f,-1.25f));
            Instantiate(_PiPePrefabs,Pospaw, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
            
            
        }
    }
   

}
