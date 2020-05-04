using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpYun.NETCore.SDK;

namespace TimeManager_CSharp
{
    class UpCloudCon
    {
        /// <summary>
        /// 服务名称
        /// </summary>
        private static string bucketName = "sancloud";
        /// <summary>
        /// 操作员账号
        /// </summary>
        private static string username = "sanappcloud";
        /// <summary>
        /// 操作员密码
        /// </summary>
        private static string password = "tCkmqfzbdhrZJPYKlNamXgirHgF7I0W8";
        /// <summary>
        /// 上传文件保存目录
        /// </summary>
        private static string uploaddir = "/AppJson/";
        /// <summary>
        /// 文件访问密码
        /// </summary>

        static UpYunConfig fig = new UpYunConfig() { Url = "", IsWebPlossless = true, IsWebPlossy = true, IsHttpResponseMessage = true };
        static UpYunClient upyunfig = new UpYunClient(bucketName, username, password, fig);

        /// <summary>
        /// 上传文件
        /// </summary>
        public void WriteFileAsync(String idName)
        {
            string filepatn = @"./talk.json";
            string uploadpath = uploaddir + idName + "talk.json";
            upyunfig.WriteFileAsync(uploadpath, filepatn.ReadFile(), true);
        }
    }
}
