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
    public partial class WebFile : ModelBase<WebFile>
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
    public partial class WebFile
    {
        public string FileAddress
        {
            get { return Scheme + "://" + Host + ":" + Port + LocalPath + FileName; }
        }
    }
    /// <summary>
    /// 方法类
    /// </summary>
    public partial class WebFile
    {
        public WebFile GetById(int id)
        {
            return mapper.QueryForObject<WebFile>(tablename + ".FindById", id);
        }
        public WebFile GetByMd5(string md5)
        {
            //string sql = GetSql(tablename + ".FindByMd5", md5);
            return mapper.QueryForObject<WebFile>(tablename + ".FindByMd5", md5);
        }
    }
}
