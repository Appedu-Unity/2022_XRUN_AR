using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] [Header("�e�@�ӫ��s")] Button pre_Btn;
    [SerializeField] [Header("�U�@�ӫ��s")] Button next_Btn;
    [SerializeField] [Header("�Ϥ�")] Image item_Img;

    [SerializeField] [Header("�����]�ƹ�")] Sprite[] item_Sprite;
    [SerializeField] [Header("�w�]�Ӥ�")] int itemID;

    void Awake()
    {
        pre_Btn = gameObject.transform.GetChild(0).GetComponent<Button>();
        item_Img = gameObject.transform.GetChild(1).GetComponent<Image>();
        next_Btn = gameObject.transform.GetChild(2).GetComponent<Button>();

        InitializeValue();
        Onclick();
    }

    /// <summary>
    /// ��l�Ƽƭ�
    /// </summary>
    void InitializeValue()
    {
        itemID = 0;
       // item_Img.sprite = item_Sprite[itemID - 1];
    }

    /// <summary>
    /// ���s�I��
    /// </summary>
    void Onclick()
    {
        pre_Btn.onClick.AddListener(PreItem);
        next_Btn.onClick.AddListener(NextItem);
    }

    /// <summary>
    /// �e�@���~
    /// </summary>
    void PreItem()
    {
        if (itemID == 0) itemID = item_Sprite.Length - 1;

        else itemID -= 1;

        item_Img.sprite = item_Sprite[itemID];
    }

    /// <summary>
    /// ��@���~
    /// </summary>
    void NextItem()
    {
        if (itemID == item_Sprite.Length - 1) itemID = 0;

        else itemID += 1;

        item_Img.sprite = item_Sprite[itemID];
    }
}
