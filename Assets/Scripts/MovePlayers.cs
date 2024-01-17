using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Tooltip("Speed movement of the player")]
    [SerializeField] private float speed;

    [Tooltip("Add the hand of the player")]
    [SerializeField] private GameObject handRightTransform;

    [Tooltip("Add the hand of the player")]
    [SerializeField] private GameObject handLeftTransform;

    [SerializeField] private GameObject borderLeft;
    [SerializeField] private GameObject borderRight;

    [Tooltip("add Key code in order ")]
    [SerializeField] private KeyCode[] keyCode;
    private enum keyMovement {left,right};
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyCode[(int)keyMovement.right]) && borderRight.transform.position.x > transform.position.x)
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
            if(!handRightTransform.activeSelf)
            {
                handRightTransform.SetActive(true);
                handLeftTransform.SetActive(false);
            }
        } else if (Input.GetKey(keyCode[(int)keyMovement.left]) && borderLeft.transform.position.x < transform.position.x)
        {
            transform.position += new Vector3(Time.deltaTime * -speed, 0, 0);
            if(!handLeftTransform.activeSelf)
            {
                handRightTransform.SetActive(false);
                handLeftTransform.SetActive(true);
            }
            
        }

       


        

    }







}
