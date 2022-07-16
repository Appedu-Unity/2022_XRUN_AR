using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] [Header("��ܵe��")] GameObject choosePage;
    [SerializeField] [Header("�}��ܫ��s")] Button choosePage_Btn;

    [SerializeField] [Header("�������q�������s")] Button goToCompany_Btn;
    [SerializeField] [Header("�������q��������")] GameObject goToCompany_Page;

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
    /// ��l�Ƽƭ�
    /// </summary>
    void InitializeValue()
    {
        isChoosing = false;
    }

    /// <summary>
    /// ���sĲ�o
    /// </summary>
    void Onclick()
    {
        choosePage_Btn.onClick.AddListener(IsChoosing);
        goToCompany_Btn.onClick.AddListener(GotoCompany);
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
}
