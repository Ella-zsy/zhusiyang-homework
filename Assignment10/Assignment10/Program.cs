using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment7_Crawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.cnblogs.com/dstang2000/"; // 设置要爬取的起始页URL
            Crawler crawler = new Crawler(url); // 创建爬虫对象
            crawler.Start(); // 开始爬取
        }
    }

    class Crawler
    {
        // 设置 UserAgent
        static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3";

        // 待处理URL队列
        Queue<string> urlQueue = new Queue<string>();

        // 已经处理过的URL列表
        HashSet<string> visitedUrls = new HashSet<string>();

        // 要爬取的起始页URL
        string startUrl;

        public Crawler(string url)
        {
            this.startUrl = url;
        }

        public void Start()
        {
            // 将起始页URL添加到待处理URL队列中
            urlQueue.Enqueue(startUrl);

            // 逐个处理待处理URL队列中的URL
            while (urlQueue.Count > 0)
            {
                // 从队列中取出第一个URL并标记为已访问
                string url = urlQueue.Dequeue();
                visitedUrls.Add(url);

                // 输出当前正在处理的URL
                Console.WriteLine("正在处理网页 " + url);

                // 下载当前网页的HTML代码
                string html = DownloadHtml(url);

                // 如果下载不成功，则直接返回
                if (html == null)
                    continue;

                // 解析当前网页中的所有URL，将符合要求的URL加入待处理URL队列中
                ParseUrls(url, html);

            }
        }

        string DownloadHtml(string url)
        {
            try
            {
                // 创建一个HttpWebRequest对象用于向指定地址发送请求
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                // 设置UserAgent，模拟浏览器请求
                request.UserAgent = UserAgent;
                // 获取请求返回的HttpWebResponse对象
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                // 读取HttpWebResponse对象中的ResponseStream流
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                // 将ResponseStream流中的数据读取到一个字符串中
                string html = reader.ReadToEnd();
                // 关闭所有打开的流对象
                reader.Close();
                stream.Close();
                response.Close();
                // 返回从网页上下载到的HTML代码
                return html;
            }
            catch (Exception ex)
            {
                // 输出下载出错的原因
                Console.WriteLine("下载网页 {0} 失败，原因：{1}", url, ex.Message);
                return null;
            }
        }

        void ParseUrls(string baseUrl, string html)
        {
            // 解析当前网页中的所有超链接
            Regex regex = new Regex(@"<a[^>]*href=[""']?([^'"" >]+)", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(html);
            foreach (Match match in matches)
            {
                // 从超链接中提取出新的URL
                string newUrl = match.Groups[1].Value.Trim();

                // 将相对路径转成完整路径
                newUrl = GetAbsoluteUrl(baseUrl, newUrl);
                if (newUrl == null)
                    continue;

                // 如果新URL已经被处理过，则直接跳过
                if (visitedUrls.Contains(newUrl))
                    continue;

                // 如果新URL符合要求，那么就将它添加到待处理URL队列中
                if (IsHtmlPage(newUrl))
                {
                    urlQueue.Enqueue(newUrl);
                }
            }
        }

        bool IsHtmlPage(string url)
        {
            // 判断当前URL指向的网页是否是一个HTML网页
            return url.EndsWith(".html") || url.EndsWith(".htm") || url.EndsWith(".aspx") || url.EndsWith(".php") || url.EndsWith(".jsp");
        }

        string GetAbsoluteUrl(string baseUrl, string newUrl)
        {
            // 如果新链接是一个绝对路径，则直接返回
            if (newUrl.StartsWith("http://") || newUrl.StartsWith("https://"))
                return newUrl;

            // 如果新链接是一个相对路径
            Uri baseUri = new Uri(baseUrl);

            Uri uri;
            try
            {
                uri = new Uri(baseUri, newUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine("相对路径 {0} 转换为绝对路径失败，原因：{1}", newUrl, ex.Message);
                return null;
            }

            return uri.AbsoluteUri;
        }
    }
}





