using UnityEngine;

public class ActiveTest : MonoBehaviour
{
    private bool isUpdate = false;
    private bool isFixedUpdate = false;
    private bool isLateUpdate = false;
    
    private float timer = 0f;
    
    private void Awake()
    {
        Debug.Log(gameObject.name + "Awake");
    }
    
    private void OnEnable()
    {
        Debug.Log(gameObject.name + "OnEnable");
    }
    
    private void Start()
    {
        Debug.Log(gameObject.name + "Start");
        
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            Material mat = renderer.material;

            if (mat != null)
            {
                //mat.enableInstancing = true;
                Debug.Log($"{mat.name} 머티리얼의 GPU Instancing이 활성화되었습니다.");
            }
            else
            {
                Debug.LogWarning("머티리얼이 없습니다.");
            }
        }
        else
        {
            Debug.LogWarning("Renderer 컴포넌트를 찾을 수 없습니다.");
        }
    }
    
    private void FixedUpdate()
    {
        if (!isFixedUpdate)
        {
            isFixedUpdate = true;
            
            Debug.Log(gameObject.name + "FixedUpdate");
        }
    }
    
    private void Update()
    {
        if (!isUpdate)
        {
            isUpdate = true;
            
            Debug.Log(gameObject.name + "Update");
        }
        /*
        timer += Time.deltaTime;
        if(timer > 3f)
            Destroy(gameObject);
        */
    }

    private void LateUpdate()
    {
        if (!isLateUpdate)
        {
            isLateUpdate = true;
            
            Debug.Log(gameObject.name + "LateUpdate");
        }
    }
    
    private void OnDisable()
    {
        Debug.Log(gameObject.name + "OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log(gameObject.name + "OnDestroy");
    }
}