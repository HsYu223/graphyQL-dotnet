namespace Repositories.DataModel
{
    /// <summary>
    /// CombokindDataModel
    /// </summary>
    public class CombokindDataModel
    {
        /// <summary>
        /// 分類類別:01,02
        /// </summary>
        public string ComboKind { get; set; }

        /// <summary>
        /// 總類代號A,B,C
        /// </summary>
        public string ComboCode { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string ComboName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int? ComboSeq { get; set; }

        /// <summary>
        /// 分類說明
        /// </summary>
        public string KName { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// 所屬代號
        /// </summary>
        public string CodeFilter { get; set; }
    }
}
