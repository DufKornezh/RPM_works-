using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] pbSegments;
        Bitmap Picture;
        int numRect = 9;
        EventHandler PB_Click;

        private void toolStripButtonLoadPicture_Click(object sender, EventArgs e)
        {
            LoadPicture();
        }
        private void LoadPicture()
        {
            var ofDlg = new OpenFileDialog();

            // Фильтр показа изображений с определенным расширением.
            ofDlg.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;*.gif;)|";
            ofDlg.Filter += "*.bmp;*.jpg;**.png;*.jpeg;*.gif|All files (*.*)|*.*";
            ofDlg.FilterIndex = 1;
            ofDlg.RestoreDirectory = true;

            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                // Загружаем выбранную картинку.
                Picture = new Bitmap(ofDlg.FileName);

                // Создание сегментов
                CreatePictureSegments();
            }
        }
        private void CreatePictureSegments()
{
    // Удалим предыдущий массив, чтобы создать новый.
    if (pbSegments != null)
    {
        for (int i = 0; i < pbSegments.Length; i++)
        {
            pbSegments[i].Dispose();
        }
        pbSegments = null;
    }


    // Создаем массив прямоугольников установленного размера.
    pbSegments = new PictureBox[numRect * numRect];

    // Вычислим габаритные размеры прямоугольников.
    int w = ClientSize.Width / numRect;
    int h = ClientSize.Height / numRect;

    // Счетчики порядкового номера по координатам Х и Y.
    int countX = 0;
    int countY = 0;

    for (int i = 0; i < pbSegments.Length; i++)
    {
        // Размеры и координаты размещения созданного прямоугольника.
        pbSegments[i] = new PictureBox
        {
            Width = w,
            Height = h,
            Left = countX * w,
            Top = countY * h
        };


        // Запомним начальные координаты прямоугольника для
        // восстановления перемешанной картинки,
        // и определения полной сборки картинки.
        Point pt = new Point();
        pt.X = pbSegments[i].Left;
        pt.Y = pbSegments[i].Top;

        // сохраним координаты в свойстве Tag каждого прямоугольника
        pbSegments[i].Tag = pt;

        // Считаем прямоугольники по рядам и столбцам.
        countX++;
        if (countX == numRect)
        {
            countX = 0;
            countY++;
        }


        pbSegments[i].Parent = this;
        pbSegments[i].BorderStyle = BorderStyle.None;
        pbSegments[i].SizeMode = PictureBoxSizeMode.StretchImage;

        // Новые сегменты должны быть все видимы.
        pbSegments[i].Show();


        // Для всех прямоугольников массива событие клика мыши
        // будет обрабатываться в одной и том же методе.
        pbSegments[i].Click += new EventHandler(PB_Click);

    }// for (int i = 0; i < pbSegments.Length; i++)

    DrawPicture();
}
        private void DrawPicture()
        {
            if (Picture == null) return;

            int countX = 0;
            int countY = 0;

            for (int i = 0; i < pbSegments.Length; i++)
            {
                int w = Picture.Width / numRect;
                int h = Picture.Height / numRect;
                pbSegments[i].Image =
                    Picture.Clone(new RectangleF(countX * w, countY * h, w, h),
                        Picture.PixelFormat);
                countX++;
                if (countX == numRect)
                {
                    countX = 0;
                    countY++;
                }
            }
        }
        private void CorrectSizeSegments()
        {
            if (pbSegments == null) return;

            // Предыдущие размеры сегментов
            int oldwidth = pbSegments[0].Width;
            int oldheight = pbSegments[0].Height;


            // Новые размеры прямоугольников.
            int w = ClientSize.Width / numRect;
            int h = ClientSize.Height / numRect;



            //int countX = 0; // счетчик прямоугольников по координате X в одном ряду
            //int countY = 0; // счетчик прямоугольников по координате Y в одном столбце
            for (int i = 0; i < pbSegments.Length; i++)
            {
                pbSegments[i].Width = w;
                pbSegments[i].Height = h;

                // Получим порядковый номер сегмента по координате Х
                int countX = pbSegments[i].Left /= oldwidth;

                // Получим порядковый номер сегмента по координате Y
                int countY = pbSegments[i].Top /= oldheight;

                pbSegments[i].Left = countX * w;
                pbSegments[i].Top = countY * h;
            }
        }
        private void MixedSegments()
        {
            if (Picture == null) return;

            // Создаем объект генерирования псевдослучайных чисел,
            // для различного набора случайных чисел инициализацию
            // объекта Random производим от счетчика количества
            // миллисекунд прошедших со времени запуска операционной системы.
            Random rand = new Random(Environment.TickCount);
            for (int i = 0; i < pbSegments.Length; i++)
            {
                pbSegments[i].Visible = true;
                int temp = rand.Next(0, pbSegments.Length);
                Point ptR = pbSegments[temp].Location;
                Point ptI = pbSegments[i].Location;
                pbSegments[i].Location = ptR;
                pbSegments[temp].Location = ptI;

                // Бордюр чтобы видно было прямоугольники
                pbSegments[i].BorderStyle = BorderStyle.Fixed3D;
            }

            // Случайным образом выбираем пустой прямоугольник,
            // делаем его невидимым.
            int r = rand.Next(0, pbSegments.Length);
            pbSegments[r].Visible = false;
        }



    }
}
