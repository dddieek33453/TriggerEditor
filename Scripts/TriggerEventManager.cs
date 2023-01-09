using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventManager : Singleton<TriggerEventManager> {
    public System.Action<string> eventMessage = delegate{};
}
