using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverButtonEffectImage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("��������� �����������")]
    public Image targetImage;

    [Header("������� ���������")]
    public Sprite normalSprite;
    public Color normalColorImage = Color.black;

    [Header("��������� ��� ���������")]
    public Sprite hoverSprite;
    public Color hoverColorImage = Color.white;

    private void Start()
    {
        // ������������� ���������� ���������
        if (targetImage != null)
        {
            targetImage.sprite = normalSprite;
            targetImage.color = normalColorImage;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (targetImage == null) return;

        // ������ � ������, � ����
        targetImage.sprite = hoverSprite;
        targetImage.color = hoverColorImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (targetImage == null) return;

        // ���������� �������� ��������
        targetImage.sprite = normalSprite;
        targetImage.color = normalColorImage;
    }
}