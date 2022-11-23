﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;

    private void Awake()\
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update()
    {
        // 방향 키를 눌러 이동 방향 설정
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vartical");
        
        movement2D.MoveTo(new Vector3(x, y, 0)));
    }
}


/*
 * File : PlayerController.cs
 * Desc
 *  : 플레이어 캐릭터에 부착해서 사용
 *  
 *  Functions
 *  
 */