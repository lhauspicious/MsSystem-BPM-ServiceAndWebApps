﻿namespace MsSystem.Web.Areas.OA.ViewModel
{
    public class ChatUserViewModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string HeadImg { get; set; }

        /// <summary>
        /// 是否正在会话中
        /// </summary>
        public int IsChatting { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public int IsOnline { get; set; }

        /// <summary>
        /// 用户创建时间
        /// </summary>
        public long CreateTime { get; set; }
    }
}
