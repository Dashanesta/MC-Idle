using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    int currency;
    int grass_blocks;
    

    void Start()
    {
        currency = 0;
        grass_blocks = 0;
    }

    public void grass_block()
    {
        currency++;
    }

}
