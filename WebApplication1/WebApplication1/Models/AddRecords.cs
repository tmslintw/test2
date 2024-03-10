using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AddRecordModel
    {
        public Record records {  get; set; }
        public List<Wallet> walletlist {  get; set; }
    }
}