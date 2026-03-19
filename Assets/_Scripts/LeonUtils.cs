using System.Collections.Generic;
using UnityEngine;

namespace Leon
{
    public static class LeonUtils
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("Leon/Create Sphere")]
        public static void Test()
        {
            var o = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            o.transform.position = Vector3.zero;
            Debug.Log("Sphere Created");
        }

        [UnityEditor.MenuItem("Leon/Test2 &g")] // %x CTRL  |  #x SHIFT  |  &x ALT
        public static void Test2()
        {
            Debug.Log("Test2");
        }
#endif
        public static void Scale(this Transform t, float scale = 1.2f) // USE EXAMPLE: transform.Scale(2f);
        {
            t.localScale = Vector3.one * scale;
        }

        public static T GetRandom<T>(this List<T> list) // LIST OF ANYTHING
        {
            return list[Random.Range(0, list.Count)];
        }
        public static T GetRandom<T>(this T[] array) // ARRAY OF ANYTHING
        {
            if (array.Length == 0)
                return default;

            return array[Random.Range(0, array.Length)];
        }
    }
}
