using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerCollision : MonoBehaviour {
    [SerializeField] LayerMask layerMask;
    [SerializeField] string eventID;

    [SerializeField] bool enter;
    [SerializeField] bool exit;
    private void OnTriggerEnter(Collider collision) {
        if (enter) {
            int layerFlag = 1 << collision.gameObject.layer;
            if ((layerMask & layerFlag) == layerFlag) {
                TriggerEventManager.Instance.eventMessage(eventID);
            }
        }
    }
    private void OnTriggerExit(Collider collision) {
        if (exit) {
            int layerFlag = 1 << collision.gameObject.layer;
            if ((layerMask & layerFlag) == layerFlag) {
                TriggerEventManager.Instance.eventMessage(eventID);
            }
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (enter) {
            int layerFlag = 1 << collision.gameObject.layer;
            if ((layerMask & layerFlag) == layerFlag) {
                TriggerEventManager.Instance.eventMessage(eventID);
            }
        }
    }
    private void OnCollisionExit(Collision collision) {
        if (exit) {
            int layerFlag = 1 << collision.gameObject.layer;
            if ((layerMask & layerFlag) == layerFlag) {
                TriggerEventManager.Instance.eventMessage(eventID);
            }
        }
    }
}
