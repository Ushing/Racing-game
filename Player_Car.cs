using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Car : MonoBehaviour
{

    public bool CarChangingLine;

    public float moveSpeed = 1f;
    public float TargetPos;

    public Road road;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CarChangingLine = true;
            TargetPos = -7f;    
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CarChangingLine = true;
            TargetPos = 7f;     
        }

        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            CarChangingLine = false;
        }
        ChangingCarLine();
    }
    private void ChangingCarLine()
    {
        if (CarChangingLine)
        {

            //Vector2 currentPos = transform.position;

           // float xPos = Mathf.Lerp(currentPos.x, TargetPos, Time.deltaTime * moveSpeed);

            // this.transform.position = new Vector2(xPos, transform.position.y);

           // if(Mathf.Abs(currentPos.x - TargetPos) < 0.05f)
           // {
              //  CarChangingLine = false;
            //}
        }
}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ObstracleCar")
        {
            Destroy(other.gameObject);
            road.speed = 0f;
            this.gameObject.SetActive(false);
        }
    }
}
