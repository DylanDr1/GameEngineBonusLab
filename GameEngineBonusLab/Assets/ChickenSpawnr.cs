using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawnr : MonoBehaviour
{
    float timer;
    float timerRest = 2;
    bool Cooldown = false; 
    public GameObject objToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerRest;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Cooldown == false)
        {

            var l = Instantiate(objToSpawn, transform.position, Quaternion.identity);
            Cooldown = true;

            //RUN TIMER WHEN 0 RESET TIMER TO THE ORIGINAL TIME(100) reset bool
           
            
        }
        CoolDown();
       
    }

    void CoolDown()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            timer = timerRest;
            Cooldown = false;
        }
    }
}
