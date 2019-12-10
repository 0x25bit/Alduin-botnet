using System.Collections.Generic;

namespace Alduin.Logic.DTOs
{
    public class ActionResult
    {
        public bool Suceeded { get; set; }

        public IList<string> ErrorMessages { get; set; } = new List<string>();
    }
}
