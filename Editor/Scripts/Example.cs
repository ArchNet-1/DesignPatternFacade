using UnityEngine;

namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade Entity
    /// author : LOUIS PAKEL
    /// </summary>
    public class Example : MonoBehaviour
    {
        // Facade
        private Facade facade = new Facade();

        public void Start()
        {
            Entity entity = new Entity("John Doe");

            bool eligible = facade.IsEligible(entity);
        }
    }
}
