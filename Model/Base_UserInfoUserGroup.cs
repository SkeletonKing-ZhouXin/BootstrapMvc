//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Base_UserInfoUserGroup
    {
        public string UserInfoUserGroup_ID { get; set; }
        public string User_ID { get; set; }
        public string UserGroup_ID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
    
        public virtual Base_UserGroup Base_UserGroup { get; set; }
        public virtual Base_UserInfo Base_UserInfo { get; set; }
    }
}
