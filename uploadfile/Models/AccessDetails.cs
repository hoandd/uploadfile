using System.Collections.Generic;

namespace uploadfile.Base
{
    public class AccessDetails
    {
        public AccessDetails() { }

        public string Role { get; set; }
        public IEnumerable<AccessRule> AccessRules { get; set; }
    }
}