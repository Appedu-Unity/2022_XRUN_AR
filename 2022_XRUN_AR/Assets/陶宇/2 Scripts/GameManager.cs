using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] [Header("選擇畫面")] GameObject choosePage;
    [SerializeField] [Header("開選擇按鈕")] Button choosePage_Btn;

    [SerializeField] [Header("跳往公司網頁按鈕")] Button goToCompany_Btn;
    [SerializeField] [Header("跳往公司網頁頁面")] GameObject goToCompany_Page;

    bool isChoosing;

    void Awake()
    {
        InitializeValue();
        Onclick();
    }

    void Update()
    {
        ShowChoosePage();
    }

    /// <summary>
    /// 初始化數值
    /// </summary>
    void InitializeValue()
    {
        isChoosing = false;
    }

    /// <summary>
    /// 按鈕觸發
    /// </summary>
    void Onclick()
    {
        choosePage_Btn.onClick.AddListener(IsChoosing);
        goToCompany_Btn.onClick.AddListener(GotoCompany);
    }

    /// <summary>
    /// 是否在選擇功能
    /// </summary>
    void IsChoosing()
    {
        isChoosing = !isChoosing;
    }

    /// <summary>
    /// 顯示選擇畫面
    /// </summary>
    void ShowChoosePage()
    {
        if (isChoosing) choosePage.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;

        else choosePage.GetComponent<RectTransform>().anchoredPosition = new Vector3(300, 0, 0);
    }

    /// <summary>
    /// 前往公司頁面
    /// </summary>
    void GotoCompany()
    {
        goToCompany_Page.SetActive(true);
    }
}
