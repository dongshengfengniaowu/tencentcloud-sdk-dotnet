/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogData : AbstractModel
    {
        
        /// <summary>
        /// 语句校验和，用于查询详情
        /// </summary>
        [JsonProperty("CheckSum")]
        public string CheckSum{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("Db")]
        public string Db{ get; set; }

        /// <summary>
        /// 抽象的SQL语句
        /// </summary>
        [JsonProperty("FingerPrint")]
        public string FingerPrint{ get; set; }

        /// <summary>
        /// 平均的锁时间
        /// </summary>
        [JsonProperty("LockTimeAvg")]
        public float? LockTimeAvg{ get; set; }

        /// <summary>
        /// 最大锁时间
        /// </summary>
        [JsonProperty("LockTimeMax")]
        public float? LockTimeMax{ get; set; }

        /// <summary>
        /// 最小锁时间
        /// </summary>
        [JsonProperty("LockTimeMin")]
        public float? LockTimeMin{ get; set; }

        /// <summary>
        /// 锁时间总和
        /// </summary>
        [JsonProperty("LockTimeSum")]
        public float? LockTimeSum{ get; set; }

        /// <summary>
        /// 查询次数
        /// </summary>
        [JsonProperty("QueryCount")]
        public long? QueryCount{ get; set; }

        /// <summary>
        /// 平均查询时间
        /// </summary>
        [JsonProperty("QueryTimeAvg")]
        public float? QueryTimeAvg{ get; set; }

        /// <summary>
        /// 最大查询时间
        /// </summary>
        [JsonProperty("QueryTimeMax")]
        public float? QueryTimeMax{ get; set; }

        /// <summary>
        /// 最小查询时间
        /// </summary>
        [JsonProperty("QueryTimeMin")]
        public float? QueryTimeMin{ get; set; }

        /// <summary>
        /// 查询时间总和
        /// </summary>
        [JsonProperty("QueryTimeSum")]
        public float? QueryTimeSum{ get; set; }

        /// <summary>
        /// 扫描行数
        /// </summary>
        [JsonProperty("RowsExaminedSum")]
        public ulong? RowsExaminedSum{ get; set; }

        /// <summary>
        /// 发送行数
        /// </summary>
        [JsonProperty("RowsSentSum")]
        public ulong? RowsSentSum{ get; set; }

        /// <summary>
        /// 最后执行时间
        /// </summary>
        [JsonProperty("TsMax")]
        public string TsMax{ get; set; }

        /// <summary>
        /// 首次执行时间
        /// </summary>
        [JsonProperty("TsMin")]
        public string TsMin{ get; set; }

        /// <summary>
        /// 帐号
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckSum", this.CheckSum);
            this.SetParamSimple(map, prefix + "Db", this.Db);
            this.SetParamSimple(map, prefix + "FingerPrint", this.FingerPrint);
            this.SetParamSimple(map, prefix + "LockTimeAvg", this.LockTimeAvg);
            this.SetParamSimple(map, prefix + "LockTimeMax", this.LockTimeMax);
            this.SetParamSimple(map, prefix + "LockTimeMin", this.LockTimeMin);
            this.SetParamSimple(map, prefix + "LockTimeSum", this.LockTimeSum);
            this.SetParamSimple(map, prefix + "QueryCount", this.QueryCount);
            this.SetParamSimple(map, prefix + "QueryTimeAvg", this.QueryTimeAvg);
            this.SetParamSimple(map, prefix + "QueryTimeMax", this.QueryTimeMax);
            this.SetParamSimple(map, prefix + "QueryTimeMin", this.QueryTimeMin);
            this.SetParamSimple(map, prefix + "QueryTimeSum", this.QueryTimeSum);
            this.SetParamSimple(map, prefix + "RowsExaminedSum", this.RowsExaminedSum);
            this.SetParamSimple(map, prefix + "RowsSentSum", this.RowsSentSum);
            this.SetParamSimple(map, prefix + "TsMax", this.TsMax);
            this.SetParamSimple(map, prefix + "TsMin", this.TsMin);
            this.SetParamSimple(map, prefix + "User", this.User);
        }
    }
}

