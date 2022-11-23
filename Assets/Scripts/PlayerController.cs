﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    private Movement2D movement2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update()
    {
        // 방향 키를 눌러 이동 방향 설정
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        movement2D.MoveTo(new Vector3(x, y, 0));
    }

    private void LateUpdate()
    {
        // 플레이어 캐릭터가 화면 범위 바깥으로 나가지 못하도록 함
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
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