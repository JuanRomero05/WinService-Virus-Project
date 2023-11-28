using EncryptDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceTest
{
    public partial class PruebaEncripta : ServiceBase
    {
        ClassEncrypt encrypt = new ClassEncrypt();
        /*private const string folderPath = "D:\\TestFolder";
        private const string encryptedFolderPath = "D:\\TestFolder\\Encrypts";*/
        public PruebaEncripta()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            encrypt.EncryptFilesInFolder();
        }
        /*
        private void EncryptFilesInFolder()
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.*"); // Obtener todos los archivos en la carpeta

                foreach (string file in files)
                {
                    string fileExtension = Path.GetExtension(file).ToLower();

                    if (fileExtension == ".txt" || fileExtension == ".pdf")
                    {
                        byte[] fileBytes = File.ReadAllBytes(file); // Leer el contenido del archivo

                        using (Aes aes = Aes.Create())
                        {
                            byte[] key = aes.Key;
                            byte[] iv = aes.IV;

                            // Realizar el proceso de encriptación
                            byte[] encryptedBytes = EncryptFile(fileBytes, key, iv);

                            // Crear la carpeta "Encryps" si no existe
                            Directory.CreateDirectory(encryptedFolderPath);

                            // Obtener el nombre del archivo sin la ruta
                            string fileName = Path.GetFileName(file);

                            // Guardar el archivo encriptado en la carpeta "Encrypts"
                            string encryptedFilePath = Path.Combine(encryptedFolderPath, fileName);
                            File.WriteAllBytes(encryptedFilePath, encryptedBytes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el proceso de encriptación
                Console.WriteLine("Error al encriptar los archivos: " + ex.Message);
            }
        }

        private byte[] EncryptFile(byte[] fileBytes, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(fileBytes, 0, fileBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }*/

        protected override void OnStop()
        {
        }
    }
}
