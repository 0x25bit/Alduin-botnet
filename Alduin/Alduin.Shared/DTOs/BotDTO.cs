using Alduin.Shared.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.Shared.DTOs
{
    public class BotDTO : DTOBase
    {
        public string UserName { get; set; }
        public string KeyUnique { get; set; }
        public string KeyCertified { get; set; }
        public string CountryCode { get; set; }
        public string Domain { get; set; }
        public string LastIPAddress { get; set; }
        public DateTime? LastLoggedInUTC { get; set; }
    }
}
