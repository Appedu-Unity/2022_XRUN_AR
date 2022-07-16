using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] [Header("前一個按鈕")] Button pre_Btn;
    [SerializeField] [Header("下一個按鈕")] Button next_Btn;
    [SerializeField] [Header("圖片")] Image item_Img;

    [SerializeField] [Header("全部設備圖")] Sprite[] item_Sprite;
    [SerializeField] [Header("預設照片")] int itemID;

    void Awake()
    {
        pre_Btn = gameObject.transform.GetChild(0).GetComponent<Button>();
        item_Img = gameObject.transform.GetChild(1).GetComponent<Image>();
        next_Btn = gameObject.transform.GetChild(2).GetComponent<Button>();

        InitializeValue();
        Onclick();
    }

    /// <summary>
    /// 初始化數值
    /// </summary>
    void InitializeValue()
    {
        itemID = 0;
       // item_Img.sprite = item_Sprite[itemID - 1];
    }

    /// <summary>
    /// 按鈕點擊
    /// </summary>
    void Onclick()
    {
        pre_Btn.onClick.AddListener(PreItem);
        next_Btn.onClick.AddListener(NextItem);
    }

    /// <summary>
    /// 前一物品
    /// </summary>
    void PreItem()
    {
        if (itemID == 0) itemID = item_Sprite.Length - 1;

        else itemID -= 1;

        item_Img.sprite = item_Sprite[itemID];
    }

    /// <summary>
    /// 後一物品
    /// </summary>
    void NextItem()
    {
        if (itemID == item_Sprite.Length - 1) itemID = 0;

        else itemID += 1;

        item_Img.sprite = item_Sprite[itemID];
    }
}
