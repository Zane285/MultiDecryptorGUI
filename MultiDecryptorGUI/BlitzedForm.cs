using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDecryptorGUI
{
    public partial class BlitzedForm : Form
    {
        public BlitzedForm()
        {
            InitializeComponent();
        }
			private void PathBlitzed_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            PathBlitzed.Text = fileList[0];
        }
		public static string Unniggerify(string cipherText, string passPhrase)
		{
			byte[] array = Convert.FromBase64String(cipherText);
			byte[] salt = array.Take(32).ToArray<byte>();
			byte[] rgbIV = array.Skip(32).Take(32).ToArray<byte>();
			byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray<byte>();
			string @string;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 1000))
			{
				byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.BlockSize = 256;
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.Padding = PaddingMode.PKCS7;
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes, rgbIV))
					{
						using (MemoryStream memoryStream = new MemoryStream(array2))
						{
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
							{
								byte[] array3 = new byte[array2.Length];
								int count = cryptoStream.Read(array3, 0, array3.Length);
								memoryStream.Close();
								cryptoStream.Close();
								@string = Encoding.UTF8.GetString(array3, 0, count);
							}
						}
					}
				}
			}
			return @string;
		}
		private void PathBlitzed_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void btn_BlitzedDecryptText_Click(object sender, EventArgs e)
        {
            string encrypted_webhook = InputTextBoxBlitzedWebhook.Text;
			string key = key_.Text;
            string webhook = Unniggerify(encrypted_webhook, key);
			InputTextBoxBlitzedWebhook.Text = $"Webhook: {webhook}";
			key_.Text = $"Webhook: {webhook}";

		}

        private void btn_Decrypt_DragAndDrop_Click(object sender, EventArgs e)
        {
			string path = PathBlitzed.Text.Replace("\"", null);
			ModuleDefMD Module = ModuleDefMD.Load(path);
			foreach (TypeDef type in Module.Types.Where(t => t.HasMethods))
			{
				foreach (MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions))
				{
					for (int i = 0; i < method.Body.Instructions.Count(); i++)
					{
						try
						{
							//Console.WriteLine(method.Body.Instructions[i].Operand.ToString());

							if (method.Body.Instructions[i].OpCode == OpCodes.Call && method.Body.Instructions[i].Operand.ToString().Contains("Unniggerify(System.String,System.String)"))
							{
								string encryptedWebhook = method.Body.Instructions[i - 2].Operand.ToString();
								string passPhrase = method.Body.Instructions[i - 1].Operand.ToString();
								string decryptedWebhook = Unniggerify(encryptedWebhook, passPhrase);
								PathBlitzed.Text = $"\nWebhook: {decryptedWebhook}";
							}
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex);
						}
					}
				}
			}
		}

        private void PathBlitzed_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathBlitzed_DoubleClick(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			string path = ofd.FileName;
			PathBlitzed.Text = path;
		}
    }
}
