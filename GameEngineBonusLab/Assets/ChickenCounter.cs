using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChickenCounter : MonoBehaviour
{
    Chicken count;
    
    [SerializeField] TextMeshProUGUI ChickenCountText;
    [SerializeField] GameObject Chickens;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ChickenCountText.text = $"Chicken + {count.ChickenCount}";
    }

   

}
