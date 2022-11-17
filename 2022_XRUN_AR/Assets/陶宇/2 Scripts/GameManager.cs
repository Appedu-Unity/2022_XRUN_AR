using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] [Header("��ܵe��")] GameObject choosePage;
    [SerializeField] [Header("�}��ܫ��s")] Button choosePage_Btn;

    [SerializeField] [Header("�������q�������s")] Button goToCompany_Btn;
    [SerializeField] [Header("�������q��������")] GameObject goToCompany_Page;

    [SerializeField] [Header("�ӫ~��T ���s")] Button info_Btn;
    [SerializeField] [Header("�ӫ~��T ����")] GameObject info_Page;

    [SerializeField] [Header("�D������")] public GameObject bathtubModel;
    [SerializeField] [Header("������")] public GameObject toiletModel;


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
    /// ��l�Ƽƭ�
    /// </summary>
    void InitializeValue()
    {
        isChoosing = false;
        isInfo = false;
    }

    /// <summary>
    /// ���sĲ�o
    /// </summary>
    void Onclick()
    {
        choosePage_Btn.onClick.AddListener(IsChoosing);
        goToCompany_Btn.onClick.AddListener(GotoCompany);
        info_Btn.onClick.AddListener(ShowInfo);
    }

    /// <summary>
    /// �O�_�b��ܥ\��
    /// </summary>
    void IsChoosing()
    {
        isChoosing = !isChoosing;
    }

    /// <summary>
    /// ��ܿ�ܵe��
    /// </summary>
    void ShowChoosePage()
    {
        if (isChoosing) choosePage.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;

        else choosePage.GetComponent<RectTransform>().anchoredPosition = new Vector3(300, 0, 0);
    }

    /// <summary>
    /// �e�����q����
    /// </summary>
    void GotoCompany()
    {
        goToCompany_Page.SetActive(true);
    }

    /// <summary>
    /// ��ܸ�T
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
