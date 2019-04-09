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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void button_gentext_Click(object sender, EventArgs e)
        {


            chart_total_time.Series.Clear();
            chart_total_time.Series.Add("Enc (ms)");
            chart_total_time.Series.Add("Dec (ms)");

            int sizeInMb = Convert.ToInt32(numericUpDownDataSize.Value);
            int rounds = Convert.ToInt32(numericUpDownRounds.Value);
            string plaintext = RandomString(sizeInMb * 1024 * 1024);

            listBox_log.Items.Add("Filesize set to  " + sizeInMb + " MB.");
            listBox_log.Items.Add("Number of rounds set to  " + rounds + ".");

            long totaltime_E = 0;
            long totaltime_D = 0;

            for (int i=0; i<rounds; i++)
            {
                using (Rijndael myRijndael = Rijndael.Create())
                {

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Encrypt the string to an array of bytes.
                    byte[] encrypted = Crypto.EncryptStringToBytes(plaintext, myRijndael.Key, myRijndael.IV);

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    listBox_log.Items.Add("AES Encrypted in " + elapsedMs + " Milliseconds.");

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // Decrypt the bytes to a string.
                    string roundtrip = Crypto.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;
                    listBox_log.Items.Add("AES Decrypted in " + elapsedMs + " Milliseconds.");
                }
                //Console.WriteLine("ElapsedMilliseconds:   {0}", elapsedMs);
            }

            totaltime_E /= rounds;
            totaltime_D /= rounds;

            chart_total_time.Series["Enc (ms)"].Points.AddXY("AES", totaltime_E);
            chart_total_time.Series["Dec (ms)"].Points.AddXY("AES", totaltime_D);

            listBox_log.Items.Add("AES Encrypted in (on average) " + totaltime_E + " Milliseconds.");
            listBox_log.Items.Add("AES Decrypted in (on average) " + totaltime_D + " Milliseconds.");

            chart_total_time.ResetAutoValues();




            totaltime_E = 0;
            totaltime_D = 0;

            for (int i = 0; i < rounds; i++)
            {
                using (Rijndael myRijndael = Rijndael.Create())
                {

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Encrypt the string to an array of bytes.
                    var encrypted = TripDES.Encrypt(plaintext);

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    listBox_log.Items.Add("Tripple DES Encrypted in " + elapsedMs + " Milliseconds.");

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // Decrypt the bytes to a string.
                    var roundtrip = TripDES.Decrypt(encrypted);

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;
                    listBox_log.Items.Add("Tripple DES Decrypted in " + elapsedMs + " Milliseconds.");
                }
                //Console.WriteLine("ElapsedMilliseconds:   {0}", elapsedMs);
            }

            totaltime_E /= rounds;
            totaltime_D /= rounds;

            chart_total_time.Series["Enc (ms)"].Points.AddXY("Trip DES", totaltime_E);
            chart_total_time.Series["Dec (ms)"].Points.AddXY("Trip DES", totaltime_D);

            listBox_log.Items.Add("Tripple DES Encrypted in (on average) " + totaltime_E + " Milliseconds.");
            listBox_log.Items.Add("Tripple DES Decrypted in (on average) " + totaltime_D + " Milliseconds.");

            chart_total_time.ResetAutoValues();



            totaltime_E = 0;
            totaltime_D = 0;

            for (int i = 0; i < rounds; i++)
            {
                using (Rijndael myRijndael = Rijndael.Create())
                {

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Encrypt the string to an array of bytes.
                    var encrypted = DES.Encrypt(plaintext, "password");

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    listBox_log.Items.Add("DES Encrypted in " + elapsedMs + " Milliseconds.");

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // Decrypt the bytes to a string.
                    var roundtrip = DES.Decrypt(encrypted, "password");

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;
                    listBox_log.Items.Add("DES Decrypted in " + elapsedMs + " Milliseconds.");
                }
                //Console.WriteLine("ElapsedMilliseconds:   {0}", elapsedMs);
            }

            totaltime_E /= rounds;
            totaltime_D /= rounds;

            chart_total_time.Series["Enc (ms)"].Points.AddXY("DES", totaltime_E);
            chart_total_time.Series["Dec (ms)"].Points.AddXY("DES", totaltime_D);

            listBox_log.Items.Add("DES Encrypted in (on average) " + totaltime_E + " Milliseconds.");
            listBox_log.Items.Add("DES Decrypted in (on average) " + totaltime_D + " Milliseconds.");

            chart_total_time.ResetAutoValues();




            totaltime_E = 0;
            totaltime_D = 0;

            for (int i = 0; i < rounds; i++)
            {
                using (Rijndael myRijndael = Rijndael.Create())
                {

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Encrypt the string to an array of bytes.
                    var encrypted = MD5.CreateMD5(plaintext);

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    listBox_log.Items.Add("MD5 Encoded in " + elapsedMs + " Milliseconds.");

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // Decrypt the bytes to a string.
                    var roundtrip = MD5.CreateMD5(plaintext);

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;
                    listBox_log.Items.Add("MD5 Encoded in " + elapsedMs + " Milliseconds.");
                }
                //Console.WriteLine("ElapsedMilliseconds:   {0}", elapsedMs);
            }

            totaltime_E /= rounds;
            totaltime_D /= rounds;

            chart_total_time.Series["Enc (ms)"].Points.AddXY("MD5", totaltime_E);
            chart_total_time.Series["Dec (ms)"].Points.AddXY("MD5", totaltime_D);

            listBox_log.Items.Add("MD5 Encoded in (on average) " + totaltime_E + " Milliseconds.");
            listBox_log.Items.Add("MD5 Encoded in (on average) " + totaltime_D + " Milliseconds.");

            chart_total_time.ResetAutoValues();



            totaltime_E = 0;
            totaltime_D = 0;

            for (int i = 0; i < rounds; i++)
            {
                using (Rijndael myRijndael = Rijndael.Create())
                {

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    // Encrypt the string to an array of bytes.
                    var encrypted = SHA1.Hash(plaintext);

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    listBox_log.Items.Add("SHA1 Encoded in " + elapsedMs + " Milliseconds.");

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // Decrypt the bytes to a string.
                    var roundtrip = SHA1.Hash(plaintext);

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;
                    listBox_log.Items.Add("SHA1 Encoded in " + elapsedMs + " Milliseconds.");
                }
                //Console.WriteLine("ElapsedMilliseconds:   {0}", elapsedMs);
            }

            totaltime_E /= rounds;
            totaltime_D /= rounds;

            chart_total_time.Series["Enc (ms)"].Points.AddXY("SHA1", totaltime_E);
            chart_total_time.Series["Dec (ms)"].Points.AddXY("SHA1", totaltime_D);

            listBox_log.Items.Add("SHA1 Encoded in (on average) " + totaltime_E + " Milliseconds.");
            listBox_log.Items.Add("SHA1 Encoded in (on average) " + totaltime_D + " Milliseconds.");

            chart_total_time.ResetAutoValues();


            /*
            clearLocalChart();

            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
                byte[] encryptedData = new byte[250];
                byte[] decryptedData;
                byte[] dataChunk = new byte[250];
                Array.Copy(dataToEncrypt, 0, dataChunk, 0, 250);

                totaltime_E = 0;
                totaltime_D = 0;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    //Pass the data to ENCRYPT, the public key information 
                    //(using RSACryptoServiceProvider.ExportParameters(false),
                    //and a boolean flag specifying no OAEP padding.

                    
                    

                    for (int i=0; i<dataToEncrypt.Length/250; i++)
                    {
                        encryptedData = Crypto.RSAEncrypt( dataChunk, RSA.ExportParameters(false), false);
                    }
                    
                    

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_E += elapsedMs;
                    chart_local_time.Series["avg ms E"].Points.AddXY("RSA E", elapsedMs);

                    watch = System.Diagnostics.Stopwatch.StartNew();

                    //Pass the data to DECRYPT, the private key information 
                    //(using RSACryptoServiceProvider.ExportParameters(true),
                    //and a boolean flag specifying no OAEP padding.

                    for (int i = 0; i < dataToEncrypt.Length / 250; i++)
                    {
                        decryptedData = Crypto.RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                    }

                    watch.Stop();
                    elapsedMs = watch.ElapsedMilliseconds;
                    totaltime_D += elapsedMs;

                    chart_local_time.Series["avg ms D"].Points.AddXY("RSA D", elapsedMs);

                    chart_local_time.ResetAutoValues();

                    //Display the decrypted plaintext to the console. 
                    //Console.WriteLine("Decrypted plaintext: {0}", ByteConverter.GetString(decryptedData));
                }

                totaltime_E /= rounds;
                totaltime_D /= rounds;

                chart_total_time.Series["avg ms E"].Points.AddXY("RSA E", totaltime_E);
                chart_total_time.Series["avg ms D"].Points.AddXY("RSA D", totaltime_D);

                chart_total_time.ResetAutoValues();
            }
            catch (ArgumentNullException)
            {
                //Catch this exception in case the encryption did
                //not succeed.
                Console.WriteLine("Encryption failed.");

            }
            */





        }


        public void showChart()
        {
            
        }






        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
