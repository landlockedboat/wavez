using UnityEngine;

public class DisplayCongrats : MonoBehaviour {

    void Kill()
    {
        WinTextActivator.Instance.Activate();
        BossIndicator.Instance.Deactivate();
    }
}
