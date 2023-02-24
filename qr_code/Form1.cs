using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace qr_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text; //считываем текст из TextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаём новую "генерацию кода"
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }

      
    }
}
