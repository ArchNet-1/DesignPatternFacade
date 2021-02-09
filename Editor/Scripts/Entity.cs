namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade Entity
    /// author : LOUIS PAKEL
    /// </summary>
    public class Entity
    {
        // Entity name
        private string _name = "";

        /// <summary>
        /// Description : Entity Constructor
        /// </summary>
        /// <param name="name"></param>
        public Entity(string name)
        {
            _name = name;
        }

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        #endregion
    }
}
