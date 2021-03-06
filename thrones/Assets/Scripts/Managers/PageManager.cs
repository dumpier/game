﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Thrones.Managers
{
    public class PageManager : MonoBehaviour
    {
        // 現在表示中のページ
        private static GameObject currentPage;

        // 該当ページの初期ポジション
        private Vector3 originalVector;

        // 現在表示中か
        private bool is_showing = false;


        void Start()
        {
            // 初期ポジションを記録
            this.originalVector = gameObject.transform.localPosition;

            Debug.Log($"# Start {gameObject.name} x:{this.originalVector.x}, y:{this.originalVector.y}");

            // デフォルトでHomeを表示する TODO シーン初期化に移動する
            if(gameObject.name.Equals("HomePage"))
            {
                this.Show();
            }
        }


        // 現在表示中のページを取得
        public static GameObject getCurrentPage()
        {
            return PageManager.currentPage;
        }


        // ページを表示する
        public void Show()
        {
            Debug.Log($"## Show {gameObject.name}");

            this.is_showing = true;
            gameObject.transform.localPosition = new Vector3(0, 0, 0);

            PageManager.currentPage = gameObject;
        }


        // ページを隠す
        public void Hide()
        {
            Debug.Log($"## Hide {gameObject.name}");

            if(gameObject.name.Equals("HomePage"))
            {
                return;
            }

            this.is_showing = false;
            gameObject.transform.localPosition = this.originalVector;
        }


        // 表示・非表示の切替
        public void Toggle()
        {
            if(this.is_showing)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

    }

}
