using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ssmixInspector2
{
    /// <summary>
    /// 実行条件を保持する
    /// </summary>
    class condition
    {
        /// <summary>
        /// リリースするファイル
        /// </summary>
        public IEnumerable<string> releaseFiles;

        /// <summary>
        /// リリースする検証環境のルートパス
        /// </summary>
        public String releaseHPPath;
    }
}
