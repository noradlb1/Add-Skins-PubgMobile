using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ModPubg
{
	// Token: 0x02000012 RID: 18
	public class api
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public api(string name, string ownerid, string secret, string version)
		{
			if (ownerid.Length != 10 || secret.Length != 64)
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003C5C File Offset: 0x00001E5C
		public void init()
		{
			string text = encryption.iv_key();
			api.enckey = text + "-" + this.secret;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "init";
			nameValueCollection["ver"] = this.version;
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = text;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_app_data(response_structure.appinfo);
				api.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003D7C File Offset: 0x00001F7C
		public void register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "register";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["key"] = key;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003E5C File Offset: 0x0000205C
		public void login(string username, string pass)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = username;
			nameValueCollection["pass"] = pass;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003F30 File Offset: 0x00002130
		public void web_login()
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			HttpListener httpListener;
			HttpListenerRequest request;
			HttpListenerResponse httpListenerResponse;
			for (;;)
			{
				httpListener = new HttpListener();
				string text = "handshake";
				text = "http://localhost:1337/" + text + "/";
				httpListener.Prefixes.Add(text);
				httpListener.Start();
				HttpListenerContext context = httpListener.GetContext();
				request = context.Request;
				httpListenerResponse = context.Response;
				httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
				httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
				httpListenerResponse.AddHeader("Via", "hugzho's big brain");
				httpListenerResponse.AddHeader("Location", "your kernel ;)");
				httpListenerResponse.AddHeader("Retry-After", "never lmao");
				httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
				if (!(request.HttpMethod == "OPTIONS"))
				{
					break;
				}
				httpListenerResponse.StatusCode = 200;
				Thread.Sleep(1);
				httpListener.Stop();
			}
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			string rawUrl = request.RawUrl;
			string text2 = rawUrl.Replace("/handshake?user=", "");
			text2 = text2.Replace("&token=", " ");
			string text3 = text2;
			string value2 = text3.Split(Array.Empty<char>())[0];
			string value3 = text3.Split(new char[]
			{
				' '
			})[1];
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = value2;
			nameValueCollection["token"] = value3;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			bool flag = true;
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
				httpListenerResponse.StatusCode = 420;
				httpListenerResponse.StatusDescription = "SHEESH";
			}
			else
			{
				Console.WriteLine(response_structure.message);
				httpListenerResponse.StatusCode = 200;
				httpListenerResponse.StatusDescription = response_structure.message;
				flag = false;
			}
			byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
			httpListenerResponse.ContentLength64 = (long)bytes.Length;
			Stream outputStream = httpListenerResponse.OutputStream;
			outputStream.Write(bytes, 0, bytes.Length);
			Thread.Sleep(1);
			httpListener.Stop();
			if (!flag)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000041F4 File Offset: 0x000023F4
		public void button(string button)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			HttpListener httpListener = new HttpListener();
			string uriPrefix = "http://localhost:1337/" + button + "/";
			httpListener.Prefixes.Add(uriPrefix);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			HttpListenerRequest request = context.Request;
			HttpListenerResponse httpListenerResponse = context.Response;
			httpListenerResponse.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			httpListenerResponse.AddHeader("Access-Control-Allow-Origin", "*");
			httpListenerResponse.AddHeader("Via", "hugzho's big brain");
			httpListenerResponse.AddHeader("Location", "your kernel ;)");
			httpListenerResponse.AddHeader("Retry-After", "never lmao");
			httpListenerResponse.Headers.Add("Server", "\r\n\r\n");
			httpListenerResponse.StatusCode = 420;
			httpListenerResponse.StatusDescription = "SHEESH";
			httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
			httpListener.UnsafeConnectionNtlmAuthentication = true;
			httpListener.IgnoreWriteExceptions = true;
			httpListener.Stop();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000042FC File Offset: 0x000024FC
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "upgrade";
			nameValueCollection["username"] = username;
			nameValueCollection["key"] = key;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000043A8 File Offset: 0x000025A8
		public void license(string key)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "license";
			nameValueCollection["key"] = key;
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			if (response_structure.success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004470 File Offset: 0x00002670
		public void check()
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "check";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000044FC File Offset: 0x000026FC
		public void setvar(string var, string data)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "setvar";
			nameValueCollection["var"] = var;
			nameValueCollection["data"] = data;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000045A0 File Offset: 0x000027A0
		public string getvar(string var)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "getvar";
			nameValueCollection["var"] = var;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			string result;
			if (!response_structure.success)
			{
				result = null;
			}
			else
			{
				result = response_structure.response;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004650 File Offset: 0x00002850
		public void ban(string reason = null)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "ban";
			nameValueCollection["reason"] = reason;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000046E8 File Offset: 0x000028E8
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "var";
			nameValueCollection["varid"] = varid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			string result;
			if (!response_structure.success)
			{
				result = null;
			}
			else
			{
				result = response_structure.message;
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004798 File Offset: 0x00002998
		public List<api.users> fetchOnline()
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "fetchOnline";
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			List<api.users> result;
			if (!response_structure.success)
			{
				result = null;
			}
			else
			{
				result = response_structure.users;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000483C File Offset: 0x00002A3C
		public List<api.msg> chatget(string channelname)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatget";
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000048EC File Offset: 0x00002AEC
		public bool chatsend(string msg, string channelname)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "chatsend";
			nameValueCollection["message"] = msg;
			nameValueCollection["channel"] = channelname;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000049A4 File Offset: 0x00002BA4
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "checkblacklist";
			nameValueCollection["hwid"] = value;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004A60 File Offset: 0x00002C60
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			string result;
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
				result = null;
			}
			else
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "webhook";
				nameValueCollection["webid"] = webid;
				nameValueCollection["params"] = param;
				nameValueCollection["body"] = body;
				nameValueCollection["conttype"] = conttype;
				nameValueCollection["sessionid"] = api.sessionid;
				nameValueCollection["name"] = this.name;
				nameValueCollection["ownerid"] = this.ownerid;
				NameValueCollection post_data = nameValueCollection;
				string json = api.req(post_data);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
				this.load_response_struct(response_structure);
				if (!response_structure.success)
				{
					result = null;
				}
				else
				{
					result = response_structure.response;
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004B3C File Offset: 0x00002D3C
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "file";
			nameValueCollection["fileid"] = fileid;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public void log(string message)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "log";
			nameValueCollection["pcuser"] = Environment.UserName;
			nameValueCollection["message"] = message;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004C84 File Offset: 0x00002E84
		public void changeUsername(string username)
		{
			if (!this.initzalized)
			{
				api.error("You must run the function KeyAuthApp.init(); first");
				Environment.Exit(0);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "changeUsername";
			nameValueCollection["newUsername"] = username;
			nameValueCollection["sessionid"] = api.sessionid;
			nameValueCollection["name"] = this.name;
			nameValueCollection["ownerid"] = this.ownerid;
			NameValueCollection post_data = nameValueCollection;
			string json = api.req(post_data);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(json);
			this.load_response_struct(data);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004D1C File Offset: 0x00002F1C
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004D94 File Offset: 0x00002F94
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Proxy = null;
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(api.assertSSL));
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.2/", post_data);
					ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
					api.sigCheck(Encoding.Default.GetString(bytes), webClient.ResponseHeaders["signature"], post_data.Get(0));
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004F00 File Offset: 0x00003100
		private static bool assertSSL(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			bool result;
			if (certificate.Issuer.Contains("Cloudflare Inc") && sslPolicyErrors <= SslPolicyErrors.None)
			{
				result = true;
			}
			else
			{
				api.error("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
				result = false;
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004F38 File Offset: 0x00003138
		private static void sigCheck(string resp, string signature, string type)
		{
			try
			{
				string a = encryption.HashHMAC((type == "init") ? api.enckey.Substring(17, 64) : api.enckey, resp);
				if (a != signature)
				{
					api.error("Signaure check fail. Try to run the program again, your session may have expired.");
					Environment.Exit(0);
				}
			}
			catch
			{
				api.error("Signaure check fail. Try to run the program again, your session may have expired.");
				Environment.Exit(0);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004FB0 File Offset: 0x000031B0
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005014 File Offset: 0x00003214
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005088 File Offset: 0x00003288
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x0400003E RID: 62
		public string name;

		// Token: 0x0400003F RID: 63
		public string ownerid;

		// Token: 0x04000040 RID: 64
		public string secret;

		// Token: 0x04000041 RID: 65
		public string version;

		// Token: 0x04000042 RID: 66
		private static string sessionid;

		// Token: 0x04000043 RID: 67
		private static string enckey;

		// Token: 0x04000044 RID: 68
		private bool initzalized;

		// Token: 0x04000045 RID: 69
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000046 RID: 70
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000047 RID: 71
		public api.response_class response = new api.response_class();

		// Token: 0x04000048 RID: 72
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000013 RID: 19
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600005F RID: 95 RVA: 0x000050B8 File Offset: 0x000032B8
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000050CC File Offset: 0x000032CC
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000061 RID: 97 RVA: 0x000050E0 File Offset: 0x000032E0
			// (set) Token: 0x06000062 RID: 98 RVA: 0x000050F4 File Offset: 0x000032F4
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00005108 File Offset: 0x00003308
			// (set) Token: 0x06000064 RID: 100 RVA: 0x0000511C File Offset: 0x0000331C
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00005130 File Offset: 0x00003330
			// (set) Token: 0x06000066 RID: 102 RVA: 0x00005144 File Offset: 0x00003344
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00005158 File Offset: 0x00003358
			// (set) Token: 0x06000068 RID: 104 RVA: 0x0000516C File Offset: 0x0000336C
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00005180 File Offset: 0x00003380
			// (set) Token: 0x0600006A RID: 106 RVA: 0x00005194 File Offset: 0x00003394
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600006B RID: 107 RVA: 0x000051A8 File Offset: 0x000033A8
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000051BC File Offset: 0x000033BC
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600006D RID: 109 RVA: 0x000051D0 File Offset: 0x000033D0
			// (set) Token: 0x0600006E RID: 110 RVA: 0x000051E4 File Offset: 0x000033E4
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600006F RID: 111 RVA: 0x000051F8 File Offset: 0x000033F8
			// (set) Token: 0x06000070 RID: 112 RVA: 0x0000520C File Offset: 0x0000340C
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00005220 File Offset: 0x00003420
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00005234 File Offset: 0x00003434
			[DataMember]
			public List<api.users> users { get; set; }
		}

		// Token: 0x02000014 RID: 20
		public class msg
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00005248 File Offset: 0x00003448
			// (set) Token: 0x06000075 RID: 117 RVA: 0x0000525C File Offset: 0x0000345C
			public string message { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00005270 File Offset: 0x00003470
			// (set) Token: 0x06000077 RID: 119 RVA: 0x00005284 File Offset: 0x00003484
			public string author { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00005298 File Offset: 0x00003498
			// (set) Token: 0x06000079 RID: 121 RVA: 0x000052AC File Offset: 0x000034AC
			public string timestamp { get; set; }
		}

		// Token: 0x02000015 RID: 21
		public class users
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000052C0 File Offset: 0x000034C0
			// (set) Token: 0x0600007C RID: 124 RVA: 0x000052D4 File Offset: 0x000034D4
			public string credential { get; set; }
		}

		// Token: 0x02000016 RID: 22
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600007E RID: 126 RVA: 0x000052E8 File Offset: 0x000034E8
			// (set) Token: 0x0600007F RID: 127 RVA: 0x000052FC File Offset: 0x000034FC
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00005310 File Offset: 0x00003510
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00005324 File Offset: 0x00003524
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00005338 File Offset: 0x00003538
			// (set) Token: 0x06000083 RID: 131 RVA: 0x0000534C File Offset: 0x0000354C
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00005360 File Offset: 0x00003560
			// (set) Token: 0x06000085 RID: 133 RVA: 0x00005374 File Offset: 0x00003574
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00005388 File Offset: 0x00003588
			// (set) Token: 0x06000087 RID: 135 RVA: 0x0000539C File Offset: 0x0000359C
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000088 RID: 136 RVA: 0x000053B0 File Offset: 0x000035B0
			// (set) Token: 0x06000089 RID: 137 RVA: 0x000053C4 File Offset: 0x000035C4
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000053D8 File Offset: 0x000035D8
			// (set) Token: 0x0600008C RID: 140 RVA: 0x000053EC File Offset: 0x000035EC
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00005400 File Offset: 0x00003600
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00005414 File Offset: 0x00003614
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00005428 File Offset: 0x00003628
			// (set) Token: 0x06000090 RID: 144 RVA: 0x0000543C File Offset: 0x0000363C
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000091 RID: 145 RVA: 0x00005450 File Offset: 0x00003650
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00005464 File Offset: 0x00003664
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00005478 File Offset: 0x00003678
			// (set) Token: 0x06000094 RID: 148 RVA: 0x0000548C File Offset: 0x0000368C
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000095 RID: 149 RVA: 0x000054A0 File Offset: 0x000036A0
			// (set) Token: 0x06000096 RID: 150 RVA: 0x000054B4 File Offset: 0x000036B4
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000018 RID: 24
		public class app_data_class
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000098 RID: 152 RVA: 0x000054C8 File Offset: 0x000036C8
			// (set) Token: 0x06000099 RID: 153 RVA: 0x000054DC File Offset: 0x000036DC
			public string numUsers { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600009A RID: 154 RVA: 0x000054F0 File Offset: 0x000036F0
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00005504 File Offset: 0x00003704
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00005518 File Offset: 0x00003718
			// (set) Token: 0x0600009D RID: 157 RVA: 0x0000552C File Offset: 0x0000372C
			public string numKeys { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00005540 File Offset: 0x00003740
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00005554 File Offset: 0x00003754
			public string version { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005568 File Offset: 0x00003768
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000557C File Offset: 0x0000377C
			public string customerPanelLink { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005590 File Offset: 0x00003790
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x000055A4 File Offset: 0x000037A4
			public string downloadLink { get; set; }
		}

		// Token: 0x02000019 RID: 25
		public class user_data_class
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x000055B8 File Offset: 0x000037B8
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x000055CC File Offset: 0x000037CC
			public string username { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x000055E0 File Offset: 0x000037E0
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x000055F4 File Offset: 0x000037F4
			public string ip { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005608 File Offset: 0x00003808
			// (set) Token: 0x060000AA RID: 170 RVA: 0x0000561C File Offset: 0x0000381C
			public string hwid { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00005630 File Offset: 0x00003830
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00005644 File Offset: 0x00003844
			public string createdate { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00005658 File Offset: 0x00003858
			// (set) Token: 0x060000AE RID: 174 RVA: 0x0000566C File Offset: 0x0000386C
			public string lastlogin { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00005680 File Offset: 0x00003880
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x00005694 File Offset: 0x00003894
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200001A RID: 26
		public class Data
		{
			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x000056A8 File Offset: 0x000038A8
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x000056BC File Offset: 0x000038BC
			public string subscription { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x000056D0 File Offset: 0x000038D0
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x000056E4 File Offset: 0x000038E4
			public string expiry { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x000056F8 File Offset: 0x000038F8
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000570C File Offset: 0x0000390C
			public string timeleft { get; set; }
		}

		// Token: 0x0200001B RID: 27
		public class response_class
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005720 File Offset: 0x00003920
			// (set) Token: 0x060000BA RID: 186 RVA: 0x00005734 File Offset: 0x00003934
			public bool success { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000BB RID: 187 RVA: 0x00005748 File Offset: 0x00003948
			// (set) Token: 0x060000BC RID: 188 RVA: 0x0000575C File Offset: 0x0000395C
			public string message { get; set; }
		}
	}
}
