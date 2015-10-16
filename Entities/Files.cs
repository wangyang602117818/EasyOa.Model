using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOa.Model
{
    /// <summary>
    /// 基本属性类
    /// </summary>
    public partial class Files : ModelBase<Files>
    {
        public int Id { get; set; }
        public string Scheme { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string LocalPath { get; set; }   //以/符号开始，以/符号结尾
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public string MD5 { get; set; }
        public DateTime LogDate { get; set; }
    }
    /// <summary>
    /// 额外属性类
    /// </summary>
    public partial class Files
    {
        public string FileAddress
        {
            get { return Scheme + "://" + Host + ":" + Port + LocalPath + FileName; }
        }
    }
    /// <summary>
    /// 方法类
    /// </summary>
    public partial class Files
    {
        public Files FindById(int id)
        {
            return mapper.QueryForObject<Files>(tablename + ".FindById", id);
        }
        public Files FindByMd5(string md5)
        {
            return mapper.QueryForObject<Files>(tablename + ".FindByMd5", md5);
        }
    }
}
