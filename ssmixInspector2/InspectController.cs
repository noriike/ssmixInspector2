using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
namespace ssmixInspector2
{
    class InspectController
    {
        /// <summary>
        /// 検証の実行
        /// </summary>
        public void Execute()
        {
            condition c = new condition();

            this.ShowReleaseFileInputForm(c);

            this.ShowHPName(c);
        }

        /// <summary>
        /// リリースするファイルの選択フォームを表示し、選択条件を保持する
        /// </summary>
        /// <param name="c">選択条件の保持</param>
        private void ShowReleaseFileInputForm(condition c)
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() != DialogResult.Cancel)
            {
                c.releaseFiles = ofd.FileNames;
            }
        }

        /// <summary>
        /// リリースする検証環境の病院選択画面を表示する
        /// </summary>
        /// <param name="c"></param>
        private void ShowHPName(condition c)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();

            fd.Description = "リリースする病院を選択してください";
            fd.SelectedPath = @"C:\Datas\ssmix";
            fd.ShowNewFolderButton = false;

            if (fd.ShowDialog() == DialogResult.OK)
                c.releaseHPPath = fd.SelectedPath;

        }
    }
}
