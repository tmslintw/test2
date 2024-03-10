using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ViewRecordsModel
    {
        public List<V_Records_With_Wallet> recordslist { get; set; }
        public Wallet walletid { get; set; }

    }
}