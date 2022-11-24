﻿using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 운석에 부딪힌 오브젝트의 태그가 "Player"이면
        if ( collision.CompareTag("Player") )
        {
            // 운석 사망
            Destroy(gameObject);
        }
    }
}
