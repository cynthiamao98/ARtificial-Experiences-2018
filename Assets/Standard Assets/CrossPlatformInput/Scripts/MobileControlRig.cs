using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


namespace UnityStandardAssets.CrossPlatformInput
{
    [ExecuteInEditMode]
    public class MobileControlRig : MonoBehaviour
<<<<<<< HEAD
#if UNITY_EDITOR
        , UnityEditor.Build.IActiveBuildTargetChanged
#endif
=======
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32
    {
        // this script enables or disables the child objects of a control rig
        // depending on whether the USE_MOBILE_INPUT define is declared.

        // This define is set or unset by a menu item that is included with
        // the Cross Platform Input package.

<<<<<<< HEAD

=======
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32
#if !UNITY_EDITOR
	void OnEnable()
	{
		CheckEnableControlRig();
	}
<<<<<<< HEAD
#else
        public int callbackOrder
        {
            get
            {
                return 1;
            }
        }
#endif
=======
	#endif
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32

        private void Start()
        {
#if UNITY_EDITOR
            if (Application.isPlaying) //if in the editor, need to check if we are playing, as start is also called just after exiting play
#endif
            {
                UnityEngine.EventSystems.EventSystem system = GameObject.FindObjectOfType<UnityEngine.EventSystems.EventSystem>();

                if (system == null)
                {//the scene have no event system, spawn one
                    GameObject o = new GameObject("EventSystem");

                    o.AddComponent<UnityEngine.EventSystems.EventSystem>();
                    o.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
                }
            }
        }

#if UNITY_EDITOR

        private void OnEnable()
        {
<<<<<<< HEAD
=======
            EditorUserBuildSettings.activeBuildTargetChanged += Update;
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32
            EditorApplication.update += Update;
        }


        private void OnDisable()
        {
<<<<<<< HEAD
=======
            EditorUserBuildSettings.activeBuildTargetChanged -= Update;
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32
            EditorApplication.update -= Update;
        }


        private void Update()
        {
            CheckEnableControlRig();
        }
#endif


        private void CheckEnableControlRig()
        {
#if MOBILE_INPUT
		EnableControlRig(true);
		#else
            EnableControlRig(false);
#endif
        }


        private void EnableControlRig(bool enabled)
        {
            foreach (Transform t in transform)
            {
                t.gameObject.SetActive(enabled);
            }
        }
<<<<<<< HEAD

#if UNITY_EDITOR
        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
        {
            CheckEnableControlRig();
        }
#endif
=======
>>>>>>> 12b0a4668dd80710aa3ab2feca134c6c308dbb32
    }
}