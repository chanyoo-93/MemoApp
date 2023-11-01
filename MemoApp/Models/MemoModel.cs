using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoApp.Models
{
    public class MemoModel
    {
        public string MemoTitle { get; set; } = string.Empty;
        public string Memo { get; set; } = string.Empty;
        public DateTime SaveTime { get; set; }
    }
}
