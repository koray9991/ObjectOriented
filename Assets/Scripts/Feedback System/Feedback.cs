using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SVS.FeedbackSystem
{
    public class Feedback : MonoBehaviour
    {
        [SerializeField]
        GameObject feedbackObject;

        public void CreateFeedback()
            => Instantiate(feedbackObject, transform.position + new Vector3(0,0,-1), Quaternion.identity);
    }
}