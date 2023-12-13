using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypty
{
    public partial class ShaDetails : Form
    {

        private byte[] data { get; }
        public ShaDetails(byte[] b, string filename)
        {
            InitializeComponent();
            data = b;
            this.Text = "Hashes of " + filename;
        }

        private string CalculateMD5(byte[] b)
        {
            try
            {
                using (var algorithm = MD5.Create())
                {
                    return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", "").ToUpperInvariant();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string CalculateSHA1(byte[] b)
        {
            try
            {
                using (var algorithm = SHA1.Create())
                {
                    return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", "").ToUpperInvariant();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string CalculateSHA256(byte[] b)
        {
            try
            {
                using (var algorithm = SHA256.Create())
                {
                    return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", "").ToUpperInvariant();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string CalculateSHA384(byte[] b)
        {
            try
            {
                using (var algorithm = SHA384.Create())
                {
                    return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", "").ToUpperInvariant();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string CalculateSHA512(byte[] b)
        {
            try
            {
                using (var algorithm = SHA512.Create())
                {
                    return BitConverter.ToString(algorithm.ComputeHash(data)).Replace("-", "").ToUpperInvariant();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            tbMD5.Text = tbMD5.Text.ToUpperInvariant();
            tbSHA1.Text = tbSHA1.Text.ToUpperInvariant();
            tbSHA256.Text = tbSHA256.Text.ToUpperInvariant();
            tbSHA384.Text = tbSHA384.Text.ToUpperInvariant();
            tbSHA512.Text = tbSHA512.Text.ToUpperInvariant();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            tbMD5.Text = tbMD5.Text.ToLowerInvariant();
            tbSHA1.Text = tbSHA1.Text.ToLowerInvariant();
            tbSHA256.Text = tbSHA256.Text.ToLowerInvariant();
            tbSHA384.Text = tbSHA384.Text.ToLowerInvariant();
            tbSHA512.Text = tbSHA512.Text.ToLowerInvariant();
        }

        private void ShaDetails_Load(object sender, EventArgs e)
        {
            tbMD5.Text = CalculateMD5(data);
            tbSHA1.Text = CalculateSHA1(data);
            tbSHA256.Text = CalculateSHA256(data);
            tbSHA384.Text = CalculateSHA384(data);
            tbSHA512.Text = CalculateSHA512(data);
            btnUpperCase.Enabled = true;
            btnLowerCase.Enabled = true;
        }
    }
}
