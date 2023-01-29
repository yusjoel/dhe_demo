using UnityEngine;

[DefaultExecutionOrder(-100)]
[RequireComponent(typeof(SceneTag))]
public class SceneTagHandler : MonoBehaviour
{
#if UNITY_EDITOR
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("do something in editor mode");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("do something in editor mode");
    }
#endif
}
