using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] [Header("選擇畫面")] GameObject choosePage;
    [SerializeField] [Header("開選擇按鈕")] Button choosePage_Btn;

    [SerializeField] [Header("跳往公司網頁按鈕")] Button goToCompany_Btn;
    [SerializeField] [Header("跳往公司網頁頁面")] GameObject goToCompany_Page;

    [SerializeField] [Header("商品資訊 按鈕")] Button info_Btn;
    [SerializeField] [Header("商品資訊 頁面")] GameObject info_Page;

    [SerializeField] [Header("浴缸物件")] public GameObject bathtubModel;
    [SerializeField] [Header("馬桶物件")] public GameObject toiletModel;


    bool isChoosing;
    bool isInfo;

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
        isInfo = false;
    }

    /// <summary>
    /// 按鈕觸發
    /// </summary>
    void Onclick()
    {
        choosePage_Btn.onClick.AddListener(IsChoosing);
        goToCompany_Btn.onClick.AddListener(GotoCompany);
        info_Btn.onClick.AddListener(ShowInfo);
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

    /// <summary>
    /// 顯示資訊
    /// </summary>
    void ShowInfo()
    {
        isInfo = !isInfo;
        info_Page.SetActive(isInfo);
    }
    public void bathtub_model()
    {
        Instantiate(bathtubModel, new Vector3(-2, 0, 0), gameObject.transform.rotation);
    }
    


    public void toilet_model()
    {
        Instantiate(toiletModel, new Vector3(-2, 0, 0), gameObject.transform.rotation);
        
    }
    public void toilet_model_URL()
    {
        Application.OpenURL("https://smarttoilet.twtoto.com.tw/?utm_source=yahoo&utm_medium=keyword&utm_campaign=smarttoilet&utm_content=8&utm_term=%E9%A6%AC%E6%A1%B6");
    }
}
