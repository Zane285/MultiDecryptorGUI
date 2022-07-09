using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace MultiDecryptorGUI
{
    public partial class ItroublveForm : Form
    {
        public ItroublveForm()
        {
            InitializeComponent();
        }
		public static byte[] AES128(byte[] message)
		{
			byte[] result;
			try
			{
				result = new AesManaged
				{
					Key = new byte[]
					{
						88,
						105,
						179,
						95,
						179,
						135,
						116,
						246,
						101,
						235,
						150,
						231,
						111,
						77,
						22,
						131
					},
					IV = new byte[16],
					Mode = CipherMode.CBC,
					Padding = PaddingMode.Zeros
				}.CreateDecryptor().TransformFinalBlock(message, 0, message.Length);
			}
			catch
			{
				result = null;
			}
			return result;
		}
		private void btn_troublveDecryptText_Click(object sender, EventArgs e)
        {
			string encryptedWebhook = InputTextBoxItroublveWebhook.Text;
			byte[] bytes = AES128(Convert.FromBase64String(encryptedWebhook));
			encryptedWebhook = new Uri(Encoding.ASCII.GetString(bytes)).AbsoluteUri;
			InputTextBoxItroublveWebhook.Text = encryptedWebhook.Replace("%00", "");

		}

        private void guna2TextBox1_DragDrop(object sender, DragEventArgs e)
        {
			string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			PathItroublve.Text = fileList[0];
		}

        private void guna2TextBox1_DragEnter(object sender, DragEventArgs e)
        {
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
		}

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

		}

        private void btn_Decrypt_draganddrop_Click(object sender, EventArgs e)
        {
			string path = PathItroublve.Text.Replace("\"", null);
			if (checkbox_obfuscated.Checked)
            {
				string confexe = Directory.GetCurrentDirectory() + "\\Conf\\ConfuserEx-Unpacker.exe";
				string confpath = Directory.GetCurrentDirectory() + "\\Conf";
				string filename = Path.GetFileName(path);

				Process process = new Process();
				ProcessStartInfo startInfo = new ProcessStartInfo();
				startInfo.WindowStyle = ProcessWindowStyle.Hidden;
				startInfo.FileName = "cmd.exe";
				startInfo.Arguments = $"/C {confexe} {path}";
				process.StartInfo = startInfo;
				process.Start();
				PathItroublve.Text = "Unconfusing " + filename;
				Thread.Sleep(5000);

				string path_noextension = path.Replace(".exe", null);
				ModuleDefMD Module = ModuleDefMD.Load($"{path_noextension}-Cleaned.exe");
				foreach (TypeDef type in Module.Types.Where(t => t.HasMethods))
				{
					foreach (MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions))
					{
						for (int i = 0; i < method.Body.Instructions.Count(); i++)
						{
							try
							{

								if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
								{
									try
									{
										string encryptedWebhook = method.Body.Instructions[i].Operand.ToString();
										byte[] bytes = AES128(Convert.FromBase64String(encryptedWebhook));
										encryptedWebhook = new Uri(Encoding.ASCII.GetString(bytes)).AbsoluteUri;
										Console.ForegroundColor = ConsoleColor.Red;
										PathItroublve.Text = encryptedWebhook.Replace("%00", "");

									}
									catch
									{

									}
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
            else
            {
				ModuleDefMD Module = ModuleDefMD.Load(path);
				foreach (TypeDef type in Module.Types.Where(t => t.HasMethods))
				{
					foreach (MethodDef method in type.Methods.Where(m => m.HasBody && m.Body.HasInstructions))
					{
						for (int i = 0; i < method.Body.Instructions.Count(); i++)
						{
							try
							{
								if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
								{
									try
									{
										string encryptedWebhook = method.Body.Instructions[i].Operand.ToString();
										byte[] bytes = AES128(Convert.FromBase64String(encryptedWebhook));
										encryptedWebhook = new Uri(Encoding.ASCII.GetString(bytes)).AbsoluteUri;
										string cleanedDecryptedWebhook = encryptedWebhook.Replace("%00", "");
										PathItroublve.Text = cleanedDecryptedWebhook;
									}
									catch
									{

									}
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

		}

        private void checkbox_obfuscated_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PathItroublve_Click(object sender, EventArgs e)
        {

        }

        private void PathItroublve_DoubleClick(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			string path = ofd.FileName;
			PathItroublve.Text = path;

		}
    }
}
