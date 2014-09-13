using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Text;
using System.IO;


namespace WebDAVWSConsumer
{
	/// <summary>
	/// 
	/// </summary>
	public class frmWebDAVClient : System.Windows.Forms.Form 
	{
		private System.Windows.Forms.Label lblWksp;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtWorkspace;
		private System.Windows.Forms.Label lblSearchRes;
		private System.Windows.Forms.TextBox txtWebDAVQuery;
		private System.Windows.Forms.TextBox txtWebDAVResult;
		private System.Windows.Forms.Button btnQuery;
		private System.Windows.Forms.Button btnClearResp;
		private System.Windows.Forms.Button btnClearReq;
		private System.Windows.Forms.CheckBox chkAuth;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPasswd;
		private System.Windows.Forms.Label lblRows;
		private System.Windows.Forms.TextBox txtRows;
		private System.Windows.Forms.Label lblCaption;
		private System.Windows.Forms.Label lblResponseTime;
		private System.Windows.Forms.CheckBox chkHeaders;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWebDAVClient()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
			txtWebDAVQuery.Text = getASPQuery();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private string getASPQuery()
		{
			return 
				"<?xml version='1.0' ?>" +
				"<D:searchrequest xmlns:D='DAV:'>" +
				"<D:sql>" +
				"SELECT " +
				" \"rank\", " +
				" \"DAV:href\", " +
				" \"urn:schemas-microsoft-com:office:office#Title\", " +
				" \"urn:schemas-microsoft-com:office:office#ContentType\", " +
				" \"urn:schemas-microsoft-com:office:office#KBID\", " +
				" \"urn:schemas.microsoft.com:fulltextqueryinfo:description\"," +
				" \"DAV:getContentLength\", " +
				" CAST(\"DAV:getlastmodified\" AS DATE) " +
				"FROM msodc..SCOPE() " +
				"WHERE " +
				"WITH " +
				"(\"urn:schemas-microsoft-com:office:office#KBID\", " +
				" \"urn:schemas-microsoft-com:office:office#Keywords\", " +
				" \"urn:schemas-microsoft-com:office:office#Subject\", " +
				" \"urn:schemas-microsoft-com:office:office#Title\", " +
				" \"urn:schemas.microsoft.com:fulltextqueryinfo:description\":1.0 ) " +
				"AS #AliasName" +
				"(FREETEXT (#AliasName , ' acrobat ')  OR " +
				"CONTAINS (\"DAV:displayname\", ' Q12345 ') ) " +
//				"AND (\"DAV:contentclass\" = 'urn:content-classes:categoryfolder') " +
				"</D:sql>" + 
				"</D:searchrequest>";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblWksp = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtWorkspace = new System.Windows.Forms.TextBox();
			this.txtWebDAVQuery = new System.Windows.Forms.TextBox();
			this.btnClearResp = new System.Windows.Forms.Button();
			this.lblSearchRes = new System.Windows.Forms.Label();
			this.txtWebDAVResult = new System.Windows.Forms.TextBox();
			this.btnQuery = new System.Windows.Forms.Button();
			this.btnClearReq = new System.Windows.Forms.Button();
			this.chkAuth = new System.Windows.Forms.CheckBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPasswd = new System.Windows.Forms.TextBox();
			this.lblRows = new System.Windows.Forms.Label();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.lblCaption = new System.Windows.Forms.Label();
			this.lblResponseTime = new System.Windows.Forms.Label();
			this.chkHeaders = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lblWksp
			// 
			this.lblWksp.AutoSize = true;
			this.lblWksp.Location = new System.Drawing.Point(-1, 11);
			this.lblWksp.Name = "lblWksp";
			this.lblWksp.Size = new System.Drawing.Size(108, 14);
			this.lblWksp.TabIndex = 0;
			this.lblWksp.Text = "Workspace Name:";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSearch.Location = new System.Drawing.Point(120, 280);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(104, 24);
			this.btnSearch.TabIndex = 9;
			this.btnSearch.Text = "&Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtWorkspace
			// 
			this.txtWorkspace.Location = new System.Drawing.Point(112, 8);
			this.txtWorkspace.Name = "txtWorkspace";
			this.txtWorkspace.Size = new System.Drawing.Size(328, 21);
			this.txtWorkspace.TabIndex = 3;
			this.txtWorkspace.Text = "http://mercury.wipro.com/msodc";
			// 
			// txtWebDAVQuery
			// 
			this.txtWebDAVQuery.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtWebDAVQuery.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtWebDAVQuery.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtWebDAVQuery.Location = new System.Drawing.Point(5, 94);
			this.txtWebDAVQuery.Multiline = true;
			this.txtWebDAVQuery.Name = "txtWebDAVQuery";
			this.txtWebDAVQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtWebDAVQuery.Size = new System.Drawing.Size(516, 179);
			this.txtWebDAVQuery.TabIndex = 8;
			this.txtWebDAVQuery.Text = "";
			// 
			// btnClearResp
			// 
			this.btnClearResp.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnClearResp.Location = new System.Drawing.Point(232, 280);
			this.btnClearResp.Name = "btnClearResp";
			this.btnClearResp.Size = new System.Drawing.Size(112, 24);
			this.btnClearResp.TabIndex = 12;
			this.btnClearResp.Text = "Clear Response";
			this.btnClearResp.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblSearchRes
			// 
			this.lblSearchRes.AutoSize = true;
			this.lblSearchRes.Location = new System.Drawing.Point(8, 72);
			this.lblSearchRes.Name = "lblSearchRes";
			this.lblSearchRes.Size = new System.Drawing.Size(97, 14);
			this.lblSearchRes.TabIndex = 7;
			this.lblSearchRes.Text = "WebDAV Query:";
			// 
			// txtWebDAVResult
			// 
			this.txtWebDAVResult.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtWebDAVResult.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtWebDAVResult.Location = new System.Drawing.Point(4, 312);
			this.txtWebDAVResult.Multiline = true;
			this.txtWebDAVResult.Name = "txtWebDAVResult";
			this.txtWebDAVResult.ReadOnly = true;
			this.txtWebDAVResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtWebDAVResult.Size = new System.Drawing.Size(520, 177);
			this.txtWebDAVResult.TabIndex = 11;
			this.txtWebDAVResult.Text = "";
			// 
			// btnQuery
			// 
			this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnQuery.Location = new System.Drawing.Point(400, 64);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(112, 23);
			this.btnQuery.TabIndex = 7;
			this.btnQuery.Text = "Generate &Query";
			this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
			// 
			// btnClearReq
			// 
			this.btnClearReq.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnClearReq.Location = new System.Drawing.Point(8, 280);
			this.btnClearReq.Name = "btnClearReq";
			this.btnClearReq.Size = new System.Drawing.Size(104, 24);
			this.btnClearReq.TabIndex = 10;
			this.btnClearReq.Text = "Clear Request";
			this.btnClearReq.Click += new System.EventHandler(this.btnClearReq_Click);
			// 
			// chkAuth
			// 
			this.chkAuth.Checked = true;
			this.chkAuth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAuth.Location = new System.Drawing.Point(8, 37);
			this.chkAuth.Name = "chkAuth";
			this.chkAuth.Size = new System.Drawing.Size(88, 24);
			this.chkAuth.TabIndex = 4;
			this.chkAuth.Text = "Credentials";
			this.chkAuth.CheckedChanged += new System.EventHandler(this.chkAuth_CheckedChanged);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(112, 37);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(104, 21);
			this.txtUserName.TabIndex = 5;
			this.txtUserName.Text = "administrator";
			// 
			// txtPasswd
			// 
			this.txtPasswd.Location = new System.Drawing.Point(224, 37);
			this.txtPasswd.Name = "txtPasswd";
			this.txtPasswd.PasswordChar = '*';
			this.txtPasswd.Size = new System.Drawing.Size(104, 21);
			this.txtPasswd.TabIndex = 6;
			this.txtPasswd.Text = "kscape";
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(344, 40);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(78, 14);
			this.lblRows.TabIndex = 13;
			this.lblRows.Text = "Max Results:";
			// 
			// txtRows
			// 
			this.txtRows.Location = new System.Drawing.Point(424, 35);
			this.txtRows.MaxLength = 4;
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(60, 21);
			this.txtRows.TabIndex = 14;
			this.txtRows.Text = "200";
			// 
			// lblCaption
			// 
			this.lblCaption.AutoSize = true;
			this.lblCaption.Location = new System.Drawing.Point(10, 504);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(95, 14);
			this.lblCaption.TabIndex = 15;
			this.lblCaption.Text = "Response Time:";
			// 
			// lblResponseTime
			// 
			this.lblResponseTime.Location = new System.Drawing.Point(112, 504);
			this.lblResponseTime.Name = "lblResponseTime";
			this.lblResponseTime.Size = new System.Drawing.Size(152, 23);
			this.lblResponseTime.TabIndex = 16;
			// 
			// chkHeaders
			// 
			this.chkHeaders.Location = new System.Drawing.Point(360, 282);
			this.chkHeaders.Name = "chkHeaders";
			this.chkHeaders.Size = new System.Drawing.Size(112, 24);
			this.chkHeaders.TabIndex = 17;
			this.chkHeaders.Text = "Show Headers";
			// 
			// frmWebDAVClient
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(528, 533);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.chkHeaders,
																		  this.lblResponseTime,
																		  this.lblCaption,
																		  this.lblRows,
																		  this.lblSearchRes,
																		  this.lblWksp,
																		  this.txtRows,
																		  this.txtPasswd,
																		  this.txtUserName,
																		  this.chkAuth,
																		  this.btnClearReq,
																		  this.btnQuery,
																		  this.txtWebDAVResult,
																		  this.btnClearResp,
																		  this.txtWebDAVQuery,
																		  this.txtWorkspace,
																		  this.btnSearch});
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = false;
			this.Name = "frmWebDAVClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Web DAV Client";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmWebDAVClient());
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			try
			{
				DateTime startTime = System.DateTime.Now;
				HttpWebRequest webRequest = 
					(HttpWebRequest)WebRequest.Create(txtWorkspace.Text.Trim() );

				// Setting the Protocol version to '1.0'
				webRequest.ProtocolVersion = HttpVersion.Version10;
				webRequest.ContentType = "text/xml";
				webRequest.Method = "SEARCH";

				WebHeaderCollection whc = new WebHeaderCollection();
						whc.Add("MS-SEARCH-MAXROWS", txtRows.Text  );
						whc.Add("MS-Search-UseContentIndex","t");
						whc.Add("MS-Search-TotalHits","t");

				webRequest.Headers = whc;

				string strWebDAVRequest = txtWebDAVQuery.Text;

				byte[] bQueryBytes = Encoding.UTF8.GetBytes(strWebDAVRequest);

				webRequest.ContentLength =  bQueryBytes.Length;

				if (chkAuth.Checked)
				{
					NetworkCredential myCred = new NetworkCredential(txtUserName.Text,txtPasswd.Text,"");
					webRequest.Credentials = myCred;
				}

				Stream stream = webRequest.GetRequestStream();
				stream.Write(bQueryBytes, 0, bQueryBytes.Length);
				stream.Close();

				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

				txtWebDAVResult.Text = httpWebResponse.StatusCode + "\r\n";
				// Display all the headers in the response.

				if (chkHeaders.Checked)
				{
					WebHeaderCollection whc2 = httpWebResponse.Headers;
					txtWebDAVResult.AppendText(whc2.ToString());
				}

				// Pipes the stream to a higher level stream reader with the required encoding format. 
				StreamReader readStream = new StreamReader(
										httpWebResponse.GetResponseStream(),
										Encoding.UTF8);

				txtWebDAVResult.AppendText(readStream.ReadToEnd());
				// Releases the resources of the response.
				httpWebResponse.Close();
				
				lblResponseTime.Text = System.DateTime.Now.Subtract(startTime).TotalSeconds.ToString() + " Sec(s)";
			}
			catch(WebException we)
			{
				txtWebDAVResult.AppendText( "Status: "+ we.Status + "\r\n" + we.ToString());
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			txtWebDAVResult.Text = "";
			lblResponseTime.Text = "";
		}

		private void btnQuery_Click(object sender, System.EventArgs e)
		{
			txtWebDAVQuery.Text = getASPQuery();
		}

		private void btnClearReq_Click(object sender, System.EventArgs e)
		{
			txtWebDAVQuery.Text = "";		
		}

		private void chkAuth_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkAuth.Checked)
			{
				txtUserName.Enabled = true;
				txtPasswd.Enabled = true;
			}
			else
			{
				txtUserName.Enabled = false;
				txtPasswd.Enabled = false;
			}
		}

/*
		private void btnFetch_Click(object sender, System.EventArgs e)
		{
			try
			{
//				HttpWebRequest webRequest = 
//					(HttpWebRequest)WebRequest.Create("http://go.microsoft.com/fwlink/?LinkId=6062&ID=sd;en-us;gn;searchprodlist");

				HttpWebRequest webRequest = 
					(HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

				
				webRequest.ContentType = "text/html";
				webRequest.Method = "GET";

//				WebHeaderCollection whc = new WebHeaderCollection();
//				whc.Add("MS-SEARCH-MAXROWS", "50");
//				whc.Add("MS-Search-UseContentIndex","t");
//				whc.Add("MS-Search-TotalHits","t");
//
//				webRequest.Headers = whc;
//
//				string strWebDAVRequest = txtWebDAVQuery.Text;

//				byte[] bQueryBytes = Encoding.UTF8.GetBytes(strWebDAVRequest);

//				webRequest.ContentLength =  bQueryBytes.Length;

				if ( chkAuth.Enabled)
				{
					NetworkCredential myCred = new NetworkCredential(txtUserName.Text,txtPasswd.Text,"");
					//webRequest.Credentials = myCred;
					
					WebProxy proxyObject = new WebProxy("http://moon.wipro.com:2000/proxy.pac",true,null,myCred);
					webRequest.Proxy = proxyObject;
				}

//				Stream stream = webRequest.GetRequestStream();
//				stream.Write(bQueryBytes,0,bQueryBytes.Length);
//				stream.Close();

				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();

				Stream receiveStream = httpWebResponse.GetResponseStream();
				Encoding encode = System.Text.Encoding.GetEncoding("utf-8");

				// Pipes the stream to a higher level stream reader with the required encoding format. 
				StreamReader readStream = new StreamReader( receiveStream, encode );
				// Reads 256 characters at a time.    
				Char[] read = new Char[256];
				int count = readStream.Read( read, 0, 256 );
				StringBuilder sb = new StringBuilder();

				while (count > 0) 
				{
					// Dumps the 256 characters on a string and displays the string to the console.
					String str = new String(read, 0, count);
					sb.Append(str);
					count = readStream.Read(read, 0, 256);
				}

				txtWebDAVResult.Text = sb.ToString();
				// Releases the resources of the response.
				httpWebResponse.Close();
			}
			catch(WebException we)
			{
				txtWebDAVResult.Text = "Status: "+ we.Status + "\r\n" + we.ToString();
			}
		
		}
*/
	}
}
