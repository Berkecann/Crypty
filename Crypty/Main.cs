using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace Crypty
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cbAlgorithm.Items.Add(new ComboboxItem()
            {
                Text = "Aes",
                Value = Aes.Create()
            });
            cbAlgorithm.Items.Add(new ComboboxItem()
            {
                Text = "Des",
                Value = DES.Create()
            });
            cbAlgorithm.Items.Add(new ComboboxItem()
            {
                Text = "TripleDes",
                Value = TripleDES.Create()
            });

            cbAlgorithm.SelectedIndex = 0;
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() > 1)
            {
                if (args[1].StartsWith("crStart"))
                {
                    var location = Encoding.UTF8.GetString(Convert.FromBase64String(args[1].Replace("crStart", "")));
                    SetAssemblyInfo(location);
                }
                else
                {
                    SetAssemblyInfo(args[1]);
                }
            }
        }

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void SetAssemblyInfo(string location)
        {
            try
            {
                tbPath.Text = location;
                using (var info = File.Open(location, FileMode.Open))
                {
                    tbSize.Text = FormatSize(info.Length);
                    byte[] bytes = new byte[info.Length];
                    info.Read(bytes, 0, bytes.Length);
                    tbSha.Text = GetSHA1(bytes);
                    info.Close();
                }
                pbIcon.Image = Icon.ExtractAssociatedIcon(location).ToBitmap();
                btnShowMore.Visible = true;
                btnEncrypt.Visible = true;
                btnEncryptAs.Visible = true;
                btnDecrypt.Visible = true;
                btnDecryptAs.Visible = true;
            }
            catch (UnauthorizedAccessException)
            {
                var p = Process.Start(new ProcessStartInfo()
                {
                    FileName = Process.GetCurrentProcess().MainModule.FileName,
                    Arguments = "crStart" + Convert.ToBase64String(Encoding.UTF8.GetBytes(location)),
                    Verb = "runas"
                });
                SetForegroundWindow(p.Handle);
                Application.Exit();
            }
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var OFD = new OpenFileDialog();
                OFD.Title = "Select file to encrypt";
                OFD.Multiselect = false;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    SetAssemblyInfo(OFD.FileName);
                }
            }
            catch (UnauthorizedAccessException)
            {
                var p = Process.Start(new ProcessStartInfo()
                {
                    FileName = Process.GetCurrentProcess().MainModule.FileName,
                    Verb = "runas"
                });
                SetForegroundWindow(p.Handle);
                Application.Exit();
            }
        }

        public static string GetSHA1(byte[] b)
        {
            using (var algorithm = SHA1.Create())
            {
                return BitConverter.ToString(algorithm.ComputeHash(b)).Replace("-", "").ToUpperInvariant();
            }
        }

        private byte[] CalculateMD5(byte[] b)
        {

            using (var algorithm = MD5.Create())
            {
                return algorithm.ComputeHash(b);
            }
        }

        public static string FormatSize(Int64 bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1} {1}", number, suffixes[counter]);
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            var bytes = File.ReadAllBytes(tbPath.Text);
            new ShaDetails(bytes, Path.GetFileName(tbPath.Text)).ShowDialog();
        }

        private void rbBase64Key_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBase64Key.Checked)
            {
                pBase64Key.Visible = true;
                pPassword.Visible = false;
            }
        }

        private void rbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPassword.Checked)
            {
                pBase64Key.Visible = false;
                pPassword.Visible = true;
            }
        }

        private void btnGenerateBase64Key_Click(object sender, EventArgs e)
        {
            switch (cbAlgorithm.SelectedIndex)
            {
                case 0:
                    using (var algorithm = Aes.Create())
                    {
                        algorithm.GenerateKey();
                        algorithm.GenerateIV();
                        tbBase64Key.Text = Convert.ToBase64String(algorithm.Key);
                        tbBase64IV.Text = Convert.ToBase64String(algorithm.IV);
                    }
                    break;
                case 1:
                    using (var algorithm = DES.Create())
                    {
                        algorithm.GenerateKey();
                        algorithm.GenerateIV();
                        tbBase64Key.Text = Convert.ToBase64String(algorithm.Key);
                        tbBase64IV.Text = Convert.ToBase64String(algorithm.IV);
                    }
                    break;
                case 2:
                    using (var algorithm = TripleDES.Create())
                    {
                        algorithm.GenerateKey();
                        algorithm.GenerateIV();
                        tbBase64Key.Text = Convert.ToBase64String(algorithm.Key);
                        tbBase64IV.Text = Convert.ToBase64String(algorithm.IV);
                    }
                    break;
                default:
                    using (var algorithm = Aes.Create())
                    {
                        algorithm.GenerateKey();
                        algorithm.GenerateIV();
                        tbBase64Key.Text = Convert.ToBase64String(algorithm.Key);
                        tbBase64IV.Text = Convert.ToBase64String(algorithm.IV);
                    }
                    break;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                var base64Key = tbBase64Key.Text;
                var base64IV = tbBase64IV.Text;
                var Password = Encoding.UTF8.GetBytes(tbPassword.Text);
                byte[] Key;
                byte[] IV;
                if (rbBase64Key.Checked)
                {
                    Key = Convert.FromBase64String(base64Key);
                    IV = Convert.FromBase64String(base64IV);
                }
                else
                {
                    var md5 = CalculateMD5(Password);
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                        case 1:
                            Key = md5.Take(8).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        case 2:
                            Key = md5.Take(24).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        default:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                    }
                }
                using (var file = File.Open(tbPath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var bytes = new byte[file.Length];
                    file.Read(bytes, 0, bytes.Length);
                    var encryptedBytes = new byte[32];
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            encryptedBytes = Encryption.AesEncrypt(bytes, Key, IV);
                            break;
                        case 1:
                            encryptedBytes = Encryption.DesEncrypt(bytes, Key, IV);
                            break;
                        case 2:
                            encryptedBytes = Encryption.TripleDesEncrypt(bytes, Key, IV);
                            break;
                        default:
                            encryptedBytes = Encryption.AesEncrypt(bytes, Key, IV);
                            break;
                    }
                    file.Seek(0, SeekOrigin.Begin);
                    file.Write(encryptedBytes, 0, encryptedBytes.Length);
                }
                SetAssemblyInfo(tbPath.Text);
                MessageBox.Show("File Encrypted Sucessfully", "Crypty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                var base64Key = tbBase64Key.Text;
                var base64IV = tbBase64IV.Text;
                var Password = Encoding.UTF8.GetBytes(tbPassword.Text);
                byte[] Key;
                byte[] IV;
                if (rbBase64Key.Checked)
                {
                    Key = Convert.FromBase64String(base64Key);
                    IV = Convert.FromBase64String(base64IV);
                }
                else
                {
                    var md5 = CalculateMD5(Password);
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                        case 1:
                            Key = md5.Take(8).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        case 2:
                            Key = md5.Take(24).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        default:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                    }
                }
                using (var file = File.Open(tbPath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var bytes = new byte[file.Length];
                    file.Read(bytes, 0, bytes.Length);
                    var decryptedBytes = new byte[32];
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            decryptedBytes = Encryption.AesDecrypt(bytes, Key, IV);
                            break;
                        case 1:
                            decryptedBytes = Encryption.DesDecrypt(bytes, Key, IV);
                            break;
                        case 2:
                            decryptedBytes = Encryption.TripleDesDecrypt(bytes, Key, IV);
                            break;
                        default:
                            decryptedBytes = Encryption.AesDecrypt(bytes, Key, IV);
                            break;
                    }
                    file.Seek(0, SeekOrigin.Begin);
                    file.Write(decryptedBytes, 0, decryptedBytes.Length);
                    file.SetLength(decryptedBytes.Length);
                }
                SetAssemblyInfo(tbPath.Text);
                MessageBox.Show("File Decrypted Sucessfully", "Crypty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
        }

        private void btnEncryptAs_Click(object sender, EventArgs e)
        {
            try
            {
                var base64Key = tbBase64Key.Text;
                var base64IV = tbBase64IV.Text;
                var Password = Encoding.UTF8.GetBytes(tbPassword.Text);
                byte[] Key;
                byte[] IV;
                if (rbBase64Key.Checked)
                {
                    Key = Convert.FromBase64String(base64Key);
                    IV = Convert.FromBase64String(base64IV);
                }
                else
                {
                    var md5 = CalculateMD5(Password);
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                        case 1:
                            Key = md5.Take(8).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        case 2:
                            Key = md5.Take(24).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        default:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                    }
                }
                var encryptedBytes = new byte[32];
                using (var file = File.Open(tbPath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var bytes = new byte[file.Length];
                    file.Read(bytes, 0, bytes.Length);

                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            encryptedBytes = Encryption.AesEncrypt(bytes, Key, IV);
                            break;
                        case 1:
                            encryptedBytes = Encryption.DesEncrypt(bytes, Key, IV);
                            break;
                        case 2:
                            encryptedBytes = Encryption.TripleDesEncrypt(bytes, Key, IV);
                            break;
                        default:
                            encryptedBytes = Encryption.AesEncrypt(bytes, Key, IV);
                            break;
                    }
                }
                var SFD = new SaveFileDialog();
                SFD.Title = "Save Encrypted File";
                SFD.Filter = "|*" + Path.GetExtension(tbPath.Text);
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(SFD.FileName, encryptedBytes);
                    SetAssemblyInfo(SFD.FileName);
                    MessageBox.Show("File Encrypted Sucessfully", "Crypty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
        }

        private void btnDecryptAs_Click(object sender, EventArgs e)
        {
            try
            {
                var base64Key = tbBase64Key.Text;
                var base64IV = tbBase64IV.Text;
                var Password = Encoding.UTF8.GetBytes(tbPassword.Text);

                byte[] Key;
                byte[] IV;
                if (rbBase64Key.Checked)
                {
                    Key = Convert.FromBase64String(base64Key);
                    IV = Convert.FromBase64String(base64IV);
                }
                else
                {
                    var md5 = CalculateMD5(Password);
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                        case 1:
                            Key = md5.Take(8).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        case 2:
                            Key = md5.Take(24).ToArray();
                            IV = md5.Take(8).ToArray();
                            break;
                        default:
                            Key = md5;
                            IV = md5.Take(16).ToArray();
                            break;
                    }
                }

                var decryptedBytes = new byte[32];
                using (var file = File.Open(tbPath.Text, FileMode.Open, FileAccess.ReadWrite))
                {
                    var bytes = new byte[file.Length];
                    file.Read(bytes, 0, bytes.Length);
                    switch (cbAlgorithm.SelectedIndex)
                    {
                        case 0:
                            decryptedBytes = Encryption.AesDecrypt(bytes, Key, IV);
                            break;
                        case 1:
                            decryptedBytes = Encryption.DesDecrypt(bytes, Key, IV);
                            break;
                        case 2:
                            decryptedBytes = Encryption.TripleDesDecrypt(bytes, Key, IV);
                            break;
                        default:
                            decryptedBytes = Encryption.AesDecrypt(bytes, Key, IV);
                            break;
                    }
                }

                var SFD = new SaveFileDialog();
                SFD.Title = "Save Decrypted File";
                SFD.Filter = "|*" + Path.GetExtension(tbPath.Text);
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(SFD.FileName, decryptedBytes);
                    SetAssemblyInfo(SFD.FileName);
                    MessageBox.Show("File Decrypted Sucessfully", "Crypty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.GetType().ToString());
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public static class Encryption
    {
        public static byte[] AesEncrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                return aes.CreateEncryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }

        public static byte[] AesDecrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                return aes.CreateDecryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }

        public static byte[] DesEncrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                return des.CreateEncryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }

        public static byte[] DesDecrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                des.Mode = CipherMode.CBC;
                return des.CreateDecryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }

        public static byte[] TripleDesEncrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var tripledes = TripleDES.Create())
            {
                tripledes.Key = key;
                tripledes.IV = iv;
                tripledes.Mode = CipherMode.CBC;
                return tripledes.CreateEncryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }

        public static byte[] TripleDesDecrypt(byte[] b, byte[] key, byte[] iv)
        {
            using (var tripledes = TripleDES.Create())
            {
                tripledes.Key = key;
                tripledes.IV = iv;
                tripledes.Mode = CipherMode.CBC;
                return tripledes.CreateDecryptor().TransformFinalBlock(b, 0, b.Length);
            }
        }
    }
}
