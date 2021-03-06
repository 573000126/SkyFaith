﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPDModel.Models
{
    public class SFITrackNum
    {
        private int _int_mappingid;
        private string _vchar_sfinum;
        private string _vchar_agnum;
        private int _int_agid;
        private string _vchar_updateuser;
        private DateTime? _dttm_updatedttm;
        private DateTime? _dttm_ag_lastsyn;
        private int _int_ag_syn = 0;
        private string _char_isstop = "N";
        private string _char_ag_syn_sign;
        /// <summary>
        /// 数据编号
        /// </summary>
        [DisplayName("数据编号")]
        public int int_Mappingid
        {
            set { _int_mappingid = value; }
            get { return _int_mappingid; }
        }
        /// <summary>
        /// SFI单号
        /// </summary>
        [DisplayName("SFI单号")]
        public string vchar_SFInum
        {
            set { _vchar_sfinum = value; }
            get { return _vchar_sfinum; }
        }
        /// <summary>
        /// 代理单号
        /// </summary>
        [DisplayName("代理单号")]
        public string vchar_AGnum
        {
            set { _vchar_agnum = value; }
            get { return _vchar_agnum; }
        }
        /// <summary>
        /// 代理Id
        /// </summary
        [Browsable(false)]

        [DisplayName("代理Id")]

        public int int_AGid
        {
            set { _int_agid = value; }
            get { return _int_agid; }
        }
        /// <summary>
        /// 操作用户
        /// </summary>
        [Browsable(false)]

        [DisplayName("操作用户")]
        public string vchar_updateUser
        {
            set { _vchar_updateuser = value; }
            get { return _vchar_updateuser; }
        }
        /// <summary>
        /// 数据导入时间
        /// </summary>
        [DisplayName("数据导入时间")]
        public DateTime? dttm_updateDttm
        {
            set { _dttm_updatedttm = value; }
            get { return _dttm_updatedttm; }
        }
        /// <summary>
        /// 最后同步时间
        /// </summary>
        [DisplayName("最后同步时间")]

        public DateTime? dttm_AG_LastSyn
        {
            set { _dttm_ag_lastsyn = value; }
            get { return _dttm_ag_lastsyn; }
        }
        [Browsable(false)]

        public int int_AG_Syn
        {
            set { _int_ag_syn = value; }
            get { return _int_ag_syn; }
        }
        /// <summary>
        /// 运输服务完毕
        /// </summary>
        [DisplayName("运输服务完毕")]

        public string char_IsStop
        {
            set { _char_isstop = value; }
            get { return _char_isstop; }
        }
        [Browsable(false)]
        public string char_AG_Syn_sign
        {
            set { _char_ag_syn_sign = value; }
            get { return _char_ag_syn_sign; }
        }
    }
}
