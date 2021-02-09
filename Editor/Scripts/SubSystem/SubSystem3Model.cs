using System;

namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade SubSystem
    /// author : LOUIS PAKEL
    /// </summary>
    public class SubSystem3Model
    {
        /// <summary>
        /// Description : Entity has a sub system 3
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        public bool HasSubSytem3(Entity pEntity)
        {
            Console.WriteLine("Check sub system 3 for " + pEntity.Name);
            return true;
        }
    }
}
