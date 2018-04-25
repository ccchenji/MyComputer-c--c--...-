using System;
using System.Windows.Forms;
using System.Text;

namespace EncodeOrDecode
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载所有字符集列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Load(object sender, EventArgs e)
        {
            //foreach (EncodingInfo ei in Encoding.GetEncodings())
            //{
            //    Encoding en = ei.GetEncoding();
            //    this.cmb_EncodeType.Items.Add(string.Format("{0}[{1}]", en.HeaderName, en.EncodingName));
            //}
            Encoding.GetEncodings().ForAll<EncodingInfo>(ei => this.cmb_EncodeType.Items.Add(string.Format("{0}[{1}]", ei.GetEncoding().HeaderName, ei.GetEncoding().EncodingName)));

            //添加默认选项
            this.cmb_EncodeType.SelectedIndex = this.cmb_EncodeType.FindString("GB18030");

            this.txt_EncodeBefore.Text = string.Format("{0,-8}{1,-9}{2}", 666666, "晴天猪","http://www.cnblogs.com/IPrograming/");
        }

        private void btn_EncodeOrDecode_Click(object sender, EventArgs e)
        {
            //获取选择的编码类型
            String codeType = this.cmb_EncodeType.SelectedItem.ToString();
            codeType = codeType.Substring(0, codeType.IndexOf('['));

            #region 编码

            //字节数组转换为它的等效十六进制字符串。
            byte[] bytes = GetEncodeBeforeBuffer(codeType, this.txt_EncodeBefore.Text);

            ////byte数组转换为 Base64 数字编码的等效字符串
            string str = Convert.ToBase64String(bytes);   //byte[] bu =Convert.FromBase64String(str); //互转
           
             txt_EncodeAfter.Text = BitConverter.ToString(bytes);

            #endregion

            #region 解码

            this.txt_DecodeAfter.Text = GetDecodeBeforeText(codeType, bytes);

            #endregion
        }

        /// <summary>
        /// 获取字符串编码之后的bytes数组
        /// </summary>
        /// <param name="codeType">编码类型名称</param>
        /// <param name="strCode">将被编码的字符串</param>
        /// <returns></returns>
        private byte[] GetEncodeBeforeBuffer(string codeType,string strCode)
        {
            //根据编码类型构造该类型编码的编码器的实例
            Encoder encoder = Encoding.GetEncoding(codeType).GetEncoder();

            char[] chars = strCode.ToCharArray();
            //根据获取对字符进行编码所产生的字节数来创建一个byte数组
            byte[] bytes = new byte[encoder.GetByteCount(chars, 0, chars.Length, true)];

            //将字符写入到byte数组中
            encoder.GetBytes(chars, 0, chars.Length, bytes, 0, true);

            return bytes;
        }

        /// <summary>
        ///获取字符串解码之后的字符串
        /// </summary>
        /// <param name="codeType">编码格式</param>
        /// <param name="byteCode">编码的字节数组</param>
        /// <returns></returns>
        private string GetDecodeBeforeText(string codeType, byte[] byteCode)
        {
            //根据编码类型构造该类型编码的解码器的实例
            Decoder decoder = Encoding.GetEncoding(codeType).GetDecoder();
            
            //计算对字节序列（从指定字节数组开始）进行解码所产生的字符数
            char[] chars = new char[decoder.GetCharCount(byteCode, 0, byteCode.Length,true)];

            //根据获取的解码所产生的字节数来创建一个char数组
            int charLen = decoder.GetChars(byteCode, 0, byteCode.Length, chars, 0);

            StringBuilder strResult = new StringBuilder();
            
            foreach (char c in chars)
            {
                strResult = strResult.Append(c.ToString());
            }
            return strResult.ToString();
        }

    }
}
