using System.Collections.Generic;
using System.Linq;
using Builders.StringBuilders;
using Data.Helpers;

namespace Builders.HelperBuilders
{
    public class IdentityBuilder
    {
        private readonly string _identityNumber ;

        public IdentityBuilder()
        {
            _identityNumber = IdNumberBuilder.BuildAnIdNumber();
        }

        public IdentityBuilder(string idNumber)
        {
            _identityNumber = idNumber;
        }

        public SysIdentity Build()
        {
            return new SysIdentity(_identityNumber);
        }

        public static SysIdentity BuildAnIdentity()
        {
            return new IdentityBuilder().Build();
        }

        public static IList<SysIdentity> BuildIdentities(int numberOfIdentities)
        {
            var iDNumbers = IdNumberBuilder.BuildIdNumbers(numberOfIdentities);

            return iDNumbers
                .Select(
                    iDNumber => new IdentityBuilder(iDNumber)
                    .Build()
                 )
                 .ToList();
        } 
    }
}
