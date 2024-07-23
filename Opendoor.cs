using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///OPEN or CLOSE THE DOOR
/// <summary>

public class Opendoor : MonoBehaviour
{
    private string animName = "Door";
    public bool doorState = false;
    private Animation anim;
    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    //点击物体时执行
   private void OnMouseDown()
   {
     if(doorState)
     {
            //用于检测是否在关门（关到一半可以反向开门，开到一半可以反向关门）
            if (anim.isPlaying == false)
            {
                anim[animName].time = anim[animName].length;//设置当前动画时间为创建动画的最后一帧的时间（动画总时长）
            }
            anim[animName].speed = -1;
       }
     else
      {
            anim[animName].speed = 1;
      }
        anim.Play(animName);
        //改变开门状态
        doorState = !doorState;
   }
    
}
