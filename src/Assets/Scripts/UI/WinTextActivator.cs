using UnityEngine;

public class WinTextActivator : Singleton<WinTextActivator> {

	public void Activate()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
