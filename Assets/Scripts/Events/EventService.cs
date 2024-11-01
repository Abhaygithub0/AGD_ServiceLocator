using UnityEngine;



namespace ServiceLocator.Events
{
    public class EventService : MonoBehaviour
    {
        public GameEventController<int> OnMapSelected { get; private set; }

        private void Awake()
        {
            OnMapSelected = new GameEventController<int>();
        }
        
    }
}