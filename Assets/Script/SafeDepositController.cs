using UnityEngine;

public class SafeDepositController : MonoBehaviour
{
    public GameObject OpenSafeScene;
    public void openSafe()
    {
        OpenSafeScene.SetActive(true);
        gameObject.SetActive(false);
    }
}
