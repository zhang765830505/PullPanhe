
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying
{
    /// <summary>
    /// 用户表
    /// </summary>
    [SugarTable("travel_user")]
    public class TravelUserModel 
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int idenid { get; set; }

        public long Userid { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string? User_name { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string? Realname { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string? User_phone { get; set; }


        /// <summary>
        /// 联系邮箱
        /// </summary>
        public string? User_email { get; set; }



        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Create_time { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Update_time { get; set; }



        /// <summary>
        /// 头像
        /// </summary>
        public string? Avatar { get; set; }



        /// <summary>
        /// 获赞量
        /// </summary>
        public int Getlikes { get; set; }

        /// <summary>
        /// 收藏数量
        /// </summary>
        public int Favorites { get; set; }

        /// <summary>
        /// 关注数量
        /// </summary>
        public int Follows { get; set; }


        /// <summary>
        /// 所在地
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public string? Birthday { get; set; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public string? Signature { get; set; }

        /// <summary>
        /// 自我介绍
        /// </summary>
        public string? Oneself { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string? Idcard { get; set; }

        /// <summary>
        /// 是否完善信息
        /// </summary>
        public string? Isupdateuser { get; set; }

        /// <summary>
        /// 是否实名认证
        /// </summary>
        public string? Isauthname { get; set; }

        /// <summary>
        /// 紧急联系方式
        /// </summary>
        public string? Emergency_phone { get; set; }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string? Emergency_contact { get; set; }

        /// <summary>
        /// 想要去的地方
        /// </summary>
        public string wantto { get; set; }
    }
}
