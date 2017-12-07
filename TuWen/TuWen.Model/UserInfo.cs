using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuWen.Model
{
    public class UserInfo
    {
        //userid	name	tel	qq	province	city	school	grade	password	regtime
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Tel { get; set; }
        public string QQ { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public DateTime Regtime { get; set; }

    }
}
