using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts
{
    public class WaveAnimation : MonoBehaviour
    {
        [SerializeField] private int width;
        [SerializeField] private int length;
        [SerializeField] private float spaceBetween;
        [SerializeField] private GameObject prefabToSpawn;
        public bool shouldPause;

        private const float MaxHeight = 1.6f;
        
        
        private void Start()
        {
            SpawnObjects();
        }

        private void SpawnObjects()
        {
            var objects = CreateObjectGrid(prefabToSpawn);
            StartCoroutine(ManipulateObjects(objects));
        }

        private List<GameObject> CreateObjectGrid(GameObject objectToSpawn)
        {
            List<GameObject> objectList = new();
            
            for (int x = 0; x <= width; x++)
            {
                for (int y = 0; y <= length; y++)
                {
                    var gridObject = Instantiate(objectToSpawn, new Vector3(spaceBetween * x, 0, spaceBetween * y), Quaternion.identity, transform);
                    objectList.Add(gridObject);
                }
            }
        
            return objectList;
        }
        
        private IEnumerator ManipulateObjects(List<GameObject> list)
        {
            while (!shouldPause)
            {
                foreach (var obj in list)
                {
                    MoveUpAndDown(obj, 2);
                    RotateX(obj, 2);
                }
                yield return null;
            }
        }
        
        private static void MoveUpAndDown(GameObject obj, float speed)
        {
            var position = obj.transform.position;
            float newYPosition = SineFunction(MaxHeight, Time.time + position.z / 3, speed);
            
            obj.transform.position = new Vector3(position.x, newYPosition, position.z);
        }
        
        private static void RotateX(GameObject obj, float speed)
        {
            var position = obj.transform.position;
            float rotationVal = SineToDegrees(SineFunction(1f, Time.time + position.x/10, speed), 1) * MathF.PI / 2000;

            obj.transform.Rotate(rotationVal, 0, 0, Space.World);
        }
        
        
        private static float SineToDegrees(float inputValue, float amplitude)
        {
            float GetRange(float minVal, float maxVal)
            {
                return minVal - maxVal;
            }
            
            float inputRange = GetRange(-amplitude, amplitude); 
            float degreesRange = GetRange(0, 360);

            return (inputValue + amplitude) * degreesRange / inputRange;
        }
        
        private static float SineFunction(float amplitude, float time, float frequency)
        {
            return amplitude * Mathf.Sin(frequency * time);
        }
    }
}
