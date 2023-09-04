using UnityEngine;

namespace Resources.Command_Ex.CommandPattern.LearnScripts
{
    public abstract class BaseShooter : MonoBehaviour, IGameActor
    {
        protected ICommand moveForward;
        protected ICommand moveBack;
        protected ICommand moveLeft;
        protected ICommand moveRight;
        protected ICommand turnLeft;
        protected ICommand turnRight;
        protected ICommand fire;
        protected ICommand emptyCommand;

        [SerializeField] private float moveSpeed;
        [SerializeField] private float rotateSpeed;
        [SerializeField] private GameObject BulletPrefab;
        [SerializeField] private float BulletSpeed;
        [SerializeField] private Transform GunRoot;
        [SerializeField] private float ShootInterval;
        private float _lastShootTime;

        // Start is called before the first frame update
        void Start()
        {
            moveForward = CommandFactory.Create(KeyCode.W);
            moveBack = CommandFactory.Create(KeyCode.S);
            moveLeft = CommandFactory.Create(KeyCode.A);
            moveRight = CommandFactory.Create(KeyCode.D);
            turnLeft = CommandFactory.Create(KeyCode.Q);
            turnRight = CommandFactory.Create(KeyCode.E);
            fire = CommandFactory.Create(KeyCode.J);
            emptyCommand = CommandFactory.Create(default);
        }

        // Update is called once per frame
        void Update()
        {
            var command = HandleInput();
            command?.Execute(this);
        }

        protected abstract ICommand HandleInput();


        public void Fire()
        {
            if (Time.time - _lastShootTime < ShootInterval)
            {
                return;
            }

            _lastShootTime = Time.time;
            var bulletGo = GameObject.Instantiate(BulletPrefab);
            bulletGo.transform.position = GunRoot.position;
            bulletGo.transform.forward = GunRoot.forward;
            var bullet = bulletGo.AddComponent<Bullet>();
            bullet.Speed = BulletSpeed;
        }

        public void MoveBack()
        {
            transform.position -= (transform.forward * (moveSpeed * Time.deltaTime) );
        }

        public void MoveForward()
        {
            transform.position += (transform.forward * (moveSpeed * Time.deltaTime) );
        }

        public void MoveLeft()
        {
            transform.position += (-transform.right * (moveSpeed * Time.deltaTime) );
        }

        public void MoveRight()
        {
            transform.position += (transform.right * (moveSpeed * Time.deltaTime) );
        }

        public void TurnLeft()
        {
            var lastEuler = transform.localEulerAngles;
            transform.localEulerAngles = new Vector3(lastEuler.x, lastEuler.y - rotateSpeed* Time.deltaTime, lastEuler.z);
        }

        public void TurnRight()
        {
            var lastEuler = transform.localEulerAngles;
            transform.localEulerAngles = new Vector3(lastEuler.x, lastEuler.y + rotateSpeed* Time.deltaTime, lastEuler.z);
        }
    }
}
