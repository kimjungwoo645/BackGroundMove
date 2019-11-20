using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float startPos;
    [SerializeField] float endPos;


    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        if(transform.position.x <= endPos)
        {
            transform.Translate(-1 * (endPos - startPos), 0, 0);

            SendMessage("ChangeHeight", SendMessageOptions.DontRequireReceiver);
        }
    }
}
