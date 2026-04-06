using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Image))]
public class myimagebehavor : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;
    private void Start()
    {
        imageObj = GetComponent<Image>();
    }

    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
        {
            SceneManager.LoadScene(SceneManager)
        }
    }
}