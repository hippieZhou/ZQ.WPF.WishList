using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WishList.Models
{
    [Flags]
    public enum BillType
    {
        /// <summary>
        /// 收入
        /// </summary>
        Income = 0,
        /// <summary>
        /// 支出
        /// </summary>
        OutLay = 1
    };
    public class BillModel
    {
        public BillType Type { get; set; }

        public string Tag { get; private set; }

        public DateTime Time { get; set; }

        public ImageSource Image { get; set; }
    }
}
