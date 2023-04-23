using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler {
  class Crawler {
        //停止爬行事件
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;
        //待下载队列
        Queue<string> pending = new Queue<string>();
        //已下载网页
        public Dictionary<string, bool> Downloaded { get; } = new Dictionary<string, bool>();

        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; }
        //起始网址
        public string StartURL { get; set; }
        //网页编码
        public Encoding HtmlEncoding { get; set; }


        //爬虫属性
        public Crawler() {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        //开始爬行
        public void Start() {
            //将待下载队列、已下载网页清空
            Downloaded.Clear();
            pending.Clear();
            //将起始网址添加到待下载队列结尾处
            pending.Enqueue(StartURL);

            while (Downloaded.Count < MaxPage && pending.Count > 0) {
                //将待下载队列中的首个网址作为返回值并移除它
                string url = pending.Dequeue();
                try {
                    string html = DownLoad(url); // 下载
                    Downloaded[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                } catch (Exception ex) {
                    Downloaded[url] = false;
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            //停止爬行
            CrawlerStopped(this);
        }

        //下载函数
        private string DownLoad(string url) {
            WebClient webClient = new WebClient();
            //编码模式为UTF8
            webClient.Encoding = Encoding.UTF8;
            //根据网址url以string的形式下载请求的资源html
            string html = webClient.DownloadString(url);
            string fileName = Downloaded.Count.ToString();
            //创建一个新文件写入编码类型为UTF8的html
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }

        //解析内容，用正则表达式得到其中的超级链接
        private void Parse(string html, string pageUrl) {
            //在输入字符串中搜索正则表达式的所有匹配项
            var matches = new Regex(UrlDetectRegex).Matches(html);
            //遍历所有的匹配项
            foreach (Match match in matches) {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径
                //解析出host和file两个部分，进行过滤
                //在linkUrl中查找URL解析表达式，并返回第一个匹配项
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !Downloaded.ContainsKey(linkUrl) && !pending.Contains(linkUrl)) {
                    pending.Enqueue(linkUrl);
                }
            }
        }

        //将非完整路径转为完整路径
        static private string FixUrl(string url, string pageUrl) {
            if (url.Contains("://")) { //完整路径
                return url;
            }
            if (url.StartsWith("//")) {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/")) {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../")) {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./")) {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }

    }
}
