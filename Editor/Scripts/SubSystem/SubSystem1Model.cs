using System;

namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade SubSystem
    /// author : LOUIS PAKEL
    /// </summary>
    public class SubSystem1Model
    {
        /// <summary>
        /// Description : Entity has a bad  sub system 1
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        public bool HasNoBadSubSystem1(Entity pEntity)
        {
            Console.WriteLine("Check sub system 1 for " + pEntity.Name);
            return true;
        }
    }
}
