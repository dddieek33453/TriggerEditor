using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
namespace Triggers {
    [System.Serializable, CreateAssetMenu(fileName = "Enabled Mono", menuName = "Trigger/Normal/Enabled Mono", order = 1)]
    public class AcEnabledMonoBehaviour : TriggerAction {
        [SerializeField] MonoBehaviour mono = null;
        [SerializeField] bool enabled = false;
        public override bool Action() {
            if (mono != null)
                mono.enabled = enabled;
            return true;
        }
        public override TriggerAction GetCopyTrigger() {
            AcEnabledMonoBehaviour copy = CreateInstance<AcEnabledMonoBehaviour>();
            copy.mono = mono;
            copy.enabled = enabled;
            return copy;
        }
    }
}
