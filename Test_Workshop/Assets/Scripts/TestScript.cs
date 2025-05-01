using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private float speed;
    private Material material;
    private float startFaceDilate = -0.15f, endFaceDilate = 0.25f;
    private float startOutlineWidth = 0f, endOutlineWidth = 0.035f;

    private float targetFaceDilate, targetOutlineWidth;
    
    void Start()
    {
        targetFaceDilate = endFaceDilate;
        targetOutlineWidth = endOutlineWidth;
        material = textMeshPro.fontMaterial;
<<<<<<< HEAD
=======
        //lets test some shit.
        //maybe you want this change.
>>>>>>> 92f0ccba2498d22bb62a18c551aef1a57efb7bab
    }

    void Update()
    {
        float faceDilate = Mathf.Lerp(material.GetFloat("_FaceDilate"), targetFaceDilate, speed * Time.deltaTime);
        float outlineWidth = Mathf.Lerp(material.GetFloat("_OutlineWidth"), targetOutlineWidth, speed * Time.deltaTime);
        material.SetFloat("_FaceDilate", faceDilate);
        material.SetFloat("_UnderlayDilate", faceDilate);
        material.SetFloat("_OutlineWidth", outlineWidth);
        material.SetFloat("_UnderlayOffsetX", faceDilate);
        material.SetFloat("_UnderlayOffsetY", faceDilate);

        if(Mathf.Abs(faceDilate - targetFaceDilate) <= 0.01f)
        {
            targetFaceDilate = (targetFaceDilate == endFaceDilate) ? startFaceDilate : endFaceDilate;
        }

        if (Mathf.Abs(outlineWidth - targetOutlineWidth) <= 0.001f)
        {
            targetOutlineWidth = (targetOutlineWidth == endOutlineWidth) ? startOutlineWidth : endOutlineWidth;
        }
    }
}
