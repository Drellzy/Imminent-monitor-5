// Decompiled with JetBrains decompiler
// Type: GClass46
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

public sealed class GClass46
{
  public static CookieContainer cookieContainer_0 = new CookieContainer();

  public string method_0(string string_0, string string_1, string string_2)
  {
    byte[] bytes = new ASCIIEncoding().GetBytes(string_0);
    HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(string_1);
    httpWebRequest.Method = "POST";
    httpWebRequest.KeepAlive = true;
    httpWebRequest.CookieContainer = GClass46.cookieContainer_0;
    httpWebRequest.ContentType = "application/x-www-form-urlencoded";
    httpWebRequest.Referer = string_2;
    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
    httpWebRequest.Proxy = (IWebProxy) null;
    httpWebRequest.ContentLength = (long) bytes.Length;
    Stream requestStream = httpWebRequest.GetRequestStream();
    requestStream.Write(bytes, 0, bytes.Length);
    requestStream.Close();
    StreamReader streamReader = new StreamReader(((HttpWebResponse) httpWebRequest.GetResponse()).GetResponseStream());
    string end = streamReader.ReadToEnd();
    streamReader.Close();
    return end;
  }

  public string method_1(string string_0)
  {
    HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(string_0);
    httpWebRequest.CookieContainer = GClass46.cookieContainer_0;
    httpWebRequest.KeepAlive = true;
    httpWebRequest.Method = "GET";
    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36";
    httpWebRequest.Proxy = (IWebProxy) null;
    StreamReader streamReader = new StreamReader(((HttpWebResponse) httpWebRequest.GetResponse()).GetResponseStream());
    string end = streamReader.ReadToEnd();
    streamReader.Close();
    return end;
  }

  public MatchCollection method_2(string string_0, string string_1) => new Regex(string_1).Matches(string_0.Trim());
}
