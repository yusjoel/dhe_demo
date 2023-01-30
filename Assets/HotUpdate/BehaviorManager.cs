using UnityEngine;

//[AddComponentMenu("Add Behavior Manager")]
public class BehaviorManager : MonoBehaviour
{
    static public BehaviorManager instance;

    //private static MethodInfo playMakerStopMethod = null;
    //private static MethodInfo PlayMakerStopMethod => playMakerStopMethod;

    /// <summary>
    /// Reset the static variables for domain reloading.
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    private static void DomainReset()
    {
        // 这句必须有，注掉不会崩溃
        instance = null;

        Debug.Log("Are U OK?");
    }
}
