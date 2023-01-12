using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// 對話資料
    /// </summary>
    [CreateAssetMenu(menuName = "Ritsuki/Dialouge Data", fileName = "New Dialouge Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialougeName;
        [Header("對話者內容"), TextArea(2, 5)]
        public string[] dialougeContents;
    }
}