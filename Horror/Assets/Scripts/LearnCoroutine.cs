using UnityEngine;
using System.Collections;

namespace Ritsuki
{
    /// <summary>
    /// 認識協同程序，簡稱協程 Coroutine
    /// 目的讓程式停留或等待
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        // 1. 引用命名空間 System.Collections
        // 2. 定義一個傳回 IEnumerator 的方法
        // 3. 方法內必須使用 yield return 時間 停留
        // 4. 使用 StratCoroution 啟動

        //字串是一個 char 陣列
        private string textDialogue = "這裡是哪裡？我怎麼會在這？";

        private void Awake()
        {
            //StartCoroutine(Test());

            //print("第三個字：" + textDialogue[2]);

            //StartCoroutine(ShowTxst());

            StartCoroutine(ShowTextUseFor());
        }

        private IEnumerator Test() 
        {
            print("<color=#ff3333>第一行</color>");
            yield return new WaitForSeconds(2);
            print("<color=#33ff33>第二行</color>");
            yield return new WaitForSeconds(3.5f);
            print("<color=#3333ff>第三行</color>");
        }

        private IEnumerator ShowTxst()
        {
            print(textDialogue[0]);
            yield return new WaitForSeconds(0.5f);
            print(textDialogue[1]);
            yield return new WaitForSeconds(0.5f);
            print(textDialogue[2]);
            yield return new WaitForSeconds(0.5f);
        }

        private IEnumerator ShowTextUseFor()
        {
            for (int i = 0; i < textDialogue.Length; i++)
            {
                print(textDialogue[i]);
                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
