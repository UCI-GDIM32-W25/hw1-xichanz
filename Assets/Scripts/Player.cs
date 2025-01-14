using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private Rigidbody2D rb;


    private void Start ()
    {

        rb = GetComponent<Rigidbody2D>();
        // get rigid body 2d component

        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
        // call UpdateUI method
        
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = new Vector2(moveX, moveY). normalized;

        rb.velocity = moveDirection*_speed;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(_numSeedsLeft>0)
            {
                PlantSeed();
            }

            else
            {
                Debug.Log("there are no more seeds to plant");

            }
        }
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab,transform.position,Quaternion.identity);
        
    }
}
