using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //reference to LogicScript
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        AddComponentMenu 
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
        logic.addScore();
        
    }


}
