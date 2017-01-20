﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAuth.Domain
{
    /// <summary>
	/// 
	/// </summary>
    public partial class WFProcessInstance :Entity
    {
        public WFProcessInstance()
        {
          this.Code= string.Empty;
          this.CustomName= string.Empty;
          this.ActivityId= string.Empty;
          this.ActivityType= 0;
          this.ActivityName= string.Empty;
          this.PreviousId= string.Empty;
          this.ProcessSchemeId=Guid.Empty;
          this.SchemeType= string.Empty;
          this.EnabledMark= 0;
          this.CreateDate= DateTime.Now;
          this.CreateUserId= string.Empty;
          this.CreateUserName= string.Empty;
          this.Description= string.Empty;
          this.MakerList= string.Empty;
        }

        /// <summary>
	    /// 
	    /// </summary>
        public string Code { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CustomName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ActivityId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int ActivityType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string PreviousId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public Guid ProcessSchemeId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string SchemeType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? FrmType { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int EnabledMark { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? WfLevel { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string Description { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public int? IsFinish { get; set; }
        /// <summary>
	    /// 
	    /// </summary>
        public string MakerList { get; set; }

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.CreateDate = DateTime.Now;
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public void Modify(Guid keyValue)
        {
            this.Id = keyValue;
        }
        #endregion
    }
}