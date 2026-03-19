using DG.Tweening;
using Leon;
using NaughtyAttributes;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Screens
{
    public enum ScreenType
    {
        Main,
        Panel,
        Info_Panel,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> objectsList;
        public List<Typer> phraseList;

        public bool startHided = false;

        [Header("Animation")]
        public float animationDuration = 0.3f;
        public float delayBetweenObjects = 0.05f;


        private void Start()
        {
            if (startHided)
            {
                HideObjects();
            }
            else if (screenType == ScreenType.Main)
            {
                ShowObjects();
            }
        }

        [Button]
        protected virtual void Show()
        {
            if (!EditorApplication.isPlaying) return;
            ShowObjects();
        }

        [Button]
        protected virtual void Hide()
        {
            if (!EditorApplication.isPlaying) return;
            HideObjects();
        }


        public void ShowObjects()
        {
            for (int i = 0; i < objectsList.Count; i++)
            {
                var obj = objectsList[i];

                obj.gameObject.SetActive(true);
                obj.DOKill(true);
                obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }
            Invoke(nameof(StartType), delayBetweenObjects * objectsList.Count);

        }
        private void ForceShowObjects()
        {
            objectsList.ForEach(i => i.gameObject.SetActive(true));
        }
        public void HideObjects()
        {
            objectsList.ForEach(i => i.gameObject.SetActive(false));
        }


        private void StartType()
        {
            for (int i = 0; i < phraseList.Count; i++)
            {
                phraseList[i].StartTyping();
            }
        }

    }
}