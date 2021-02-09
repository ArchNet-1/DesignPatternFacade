namespace ArchNet.Design.Pattern.Facade
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Facade
    /// author : LOUIS PAKEL
    /// </summary>
    public class Facade
    {
        #region Private Fields

        private SubSystem1Model _subSystem1 = new SubSystem1Model();
        private SubSystem2Model _subSystem2 = new SubSystem2Model();
        private SubSystem3Model _subSystem3 = new SubSystem3Model();

        #endregion

        /// <summary>
        /// Description : Check all entity's sub system
        /// </summary>
        /// <param name="pEntity"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool IsEligible(Entity pEntity)
        {
            bool eligible = true;

            if (!_subSystem1.HasNoBadSubSystem1(pEntity))
            {
                eligible = false;
            }
            else if (!_subSystem2.HasGoodSubSytem2(pEntity))
            {
                eligible = false;
            }
            else if (!_subSystem3.HasSubSytem3(pEntity))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
