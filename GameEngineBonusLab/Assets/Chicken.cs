using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Chicken : MonoBehaviour
{


    public int ChickenCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.back * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pen")
        {
            ChickenCount++;
            Destroy(gameObject);
        }
    }
}
