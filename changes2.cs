 /*public class findmaskcolor : MonoBehaviour
{
    public CambiarFondo idBackground;
    // Start is called before the first frame update
    void Start()
    {
        idBackground = GameObject.FindObjectOfType<CambiarFondo>();
        gameObject.GetComponent<Renderer>().material.color = new Color(1,1,1);
        StartCoroutine(lookatthebackground());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator lookatthebackground()
    {
        while (true)
        {
            if (CambiarFondo.layer == 1)
            {

            }

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DlibFaceLandmarkDetector;
using OpenCVForUnity.RectangleTrack;
using OpenCVForUnity.UnityUtils.Helper;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;
using OpenCVForUnity.ImgprocModule;
using Rect = OpenCVForUnity.CoreModule.Rect;

namespace FaceMaskExample
{
    [RequireComponent(typeof(WebCamTextureToMatHelper), typeof(TrackedMeshOverlay))]
    public class WebCamTextureAditionalExample : MonoBehaviour
    {
        [HeaderAttribute("opciones adicionales de facemask")]

        /// <summary>
        /// Determines if make both eyes transparent.
        /// </summary>
        public bool makeBothEyesTransparent = true;//ojos transprentes

        /// <summary>
        /// Determines if make the mouth transparent.
        /// </summary>
        public bool makeMouthTransparent = true;//boca  transprentes


        /// <summary>
        /// Determines if extend the forehead.
        /// </summary>
        public bool extendForehead = true;//boca  transprentes
                                          // Start is called before the first frame update

        public List<FaceMaskData> faceMaskDatas;


        public bool useDlibFaceDetecter = false;
        public bool enableNoiseFilter = true;
        public bool enableColorCorrection = true;
        public bool filterNonFrontalFaces = false;

        [Range(0.0f, 1.0f)]
        public float frontalFaceRateLowerLimit = 0.85f;
                public bool displayFaceRects = false;
        public bool displayDebugFacePoints = false;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
*/
