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
    public partial class StealeriumForm : Form
    {
		public static string Decrypt(byte[] bytesToBeDecrypted)
		{
			byte[] SaltBytes = new byte[]
			{
					102,
					51,
					111,
					51,
					75,
					45,
					49,
					49,
					61,
					71,
					45,
					78,
					55,
					86,
					74,
					116,
					111,
					122,
					79,
					87,
					82,
					114,
					61,
					40,
					116,
					78,
					90,
					66,
					102,
					75,
					43,
					98,
					83,
					55,
					70,
					121
			};
			byte[] CryptKey = new byte[]
			{
					59,
					38,
					75,
					70,
					33,
					77,
					33,
					104,
					56,
					94,
					105,
					84,
					58,
					60,
					41,
					97,
					63,
					126,
					109,
					88,
					101,
					78,
					42,
					126,
					111,
					63,
					103,
					78,
					91,
					118,
					64,
					114,
					81,
					61,
					66

			};

			byte[] bytes;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(CryptKey, SaltBytes, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cryptoStream.Close();
					}
					bytes = memoryStream.ToArray();
				}
			}
			return Encoding.UTF8.GetString(bytes);
		}
		public static string DecryptConfig(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return "";
			}
			if (!value.StartsWith("ENCRYPTED:"))
			{
				return value;
			}
			return Decrypt(Convert.FromBase64String(value.Replace("ENCRYPTED:", "")));
		}
		public StealeriumForm()
        {
            InitializeComponent();
        }

        private void btn_Decrypt_draganddrop_Click(object sender, EventArgs e)
        {
            string path = PathStealerium.Text.Replace("\"", null);
			ModuleDefMD Module = ModuleDefMD.Load(path);
			foreach (TypeDef type in Module.Types.Where(t => t.HasMethods))
			{
				foreach (MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions))
				{
					for (int i = 0; i < method.Body.Instructions.Count(); i++)
					{
						try
						{
							if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr && method.Body.Instructions[i].Operand.ToString().Contains("ENCRYPTED:"))
							{
								try
								{
									string encryptedWebhook = method.Body.Instructions[i].Operand.ToString();
									string decryptedConfigs = DecryptConfig(encryptedWebhook);
									if (decryptedConfigs.Contains("https://"))
									{
										PathStealerium.Text = $"\nWebhook: {decryptedConfigs}";
									}
									if (decryptedConfigs.StartsWith("bc1"))
									{
										PathStealerium.Text += $"\nBTC Address: {decryptedConfigs}";
									}
									if (decryptedConfigs.StartsWith("0x"))
									{
										PathStealerium.Text += $"\nEth Address: {decryptedConfigs}";
									}
									if (decryptedConfigs.StartsWith("L"))
									{
										PathStealerium.Text += $"\nLTC Adress: {decryptedConfigs}";
									}
									if (decryptedConfigs.StartsWith("M"))
									{
										PathStealerium.Text += $"\nLTC Adress: {decryptedConfigs}";
									}
								}
								catch
								{

								}
							}
						}
						catch (Exception ex)
						{
							PathStealerium.Text = ex.Message;
						}

					}
				}
			}
		}

        private void btn_troublveDecryptText_Click(object sender, EventArgs e)
        {
			string encrypted_webhook = InputTextBoxStealeriumWebhook.Text;
			string webhook = DecryptConfig(encrypted_webhook);
			if (webhook.Contains("https://"))
			{
				InputTextBoxStealeriumWebhook.Text = $"\nWebhook: {webhook}";
			}
			if (webhook.StartsWith("bc1"))
			{
				InputTextBoxStealeriumWebhook.Text = $"\nBTC Address: {webhook}";
			}
			if (webhook.StartsWith("0x"))
			{
				InputTextBoxStealeriumWebhook.Text = $"\nEth Address: {webhook}";
			}
			if (webhook.StartsWith("L"))
			{
				InputTextBoxStealeriumWebhook.Text = $"\nLTC Adress: {webhook}";
			}
			if (webhook.StartsWith("M"))
			{
				InputTextBoxStealeriumWebhook.Text = $"\nLTC Adress: {webhook}";
			}

		}

        private void PathStealerium_DragDrop(object sender, DragEventArgs e)
        {
			string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			PathStealerium.Text = fileList[0];
		}

        private void PathStealerium_DragEnter(object sender, DragEventArgs e)
        {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

        private void PathStealerium_DoubleClick(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			string path = ofd.FileName;
			PathStealerium.Text = path;
		}
    }
}
