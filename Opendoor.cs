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
    //�������ʱִ��
   private void OnMouseDown()
   {
     if(doorState)
     {
            //���ڼ���Ƿ��ڹ��ţ��ص�һ����Է����ţ�����һ����Է�����ţ�
            if (anim.isPlaying == false)
            {
                anim[animName].time = anim[animName].length;//���õ�ǰ����ʱ��Ϊ�������������һ֡��ʱ�䣨������ʱ����
            }
            anim[animName].speed = -1;
       }
     else
      {
            anim[animName].speed = 1;
      }
        anim.Play(animName);
        //�ı俪��״̬
        doorState = !doorState;
   }
    
}
