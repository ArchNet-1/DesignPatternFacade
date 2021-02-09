using System;

namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade SubSystem
    /// author : LOUIS PAKEL
    /// </summary>
    public class SubSystem2Model
    {
        /// <summary>
        /// Description : Entity has a good  sub system 2
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        public bool HasGoodSubSytem2(Entity pEntity)
        {
            Console.WriteLine("Check sub system 2 for " + pEntity.Name);
            return true;
        }
    }
}
